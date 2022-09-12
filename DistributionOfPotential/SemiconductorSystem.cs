using System;

namespace DistributionOfPotential
{
    class SemiconductorSystem
    {
        // Массив иксов.
        public double[] arrayX;
        // Массив значений потенциалов.
        public double[] arrayFi;

        // Толщина пластины.
        private double L;
        // Относительная концентрация примеси.
        private double na;
        // "Опорная" концентрация.
        private double N0;

        // Левое граничное условие.
        private double leftBC;
        // Правое граничное условие.
        private double rightBC;
        // Длина Дебая.
        private double Ld;
        // Число узлов.
        private int size;
        // Шаг между узлами..
        private double step;
        // Точность решения.
        public double accuracy;

        // Диэлектрическая проницаемость кремния.
        private const double eps = 11.7;
        // Диэлектрическая постоянная.
        private const double eps0 = 8.85418e-12;
        // Постоянная Больцмана.
        private const double k = 1.380649e-23;
        // Комнатная температура в Кельвинах.
        private const double T = 300;
        // Заряд электрона.
        private const double q = -1.6021766208e-19;

        // Массив потенциалов текущий.
        private double[] arrayCurrFi;
        // Массив потенциалов следующий.
        private double[] arrayNextFi;
        // Массив коэффициентов альфа.
        private double[] a;
        // Массив коэффициентов бета.
        private double[] b;
        // 
        private double[] arrayPsi;


        /// <summary>
        /// Конструктор системы.
        /// </summary>
        /// <param name="leftBC">Левое граничное условие.</param>
        /// <param name="rightBC">Правое граничное условие.</param>
        /// <param name="L">Толщина пластины.</param>
        /// <param name="na">Относительная концентрация бора.</param>
        /// <param name="N0">Опорная концентрация</param>
        /// <param name="size">Число узлов.</param>
        /// <param name="accuracy">Точность решения.</param>
        public SemiconductorSystem(double leftBC, double rightBC, double L, double na, double N0 = 1e15, int size = 100, double accuracy = 1e-5)
        {
            this.L = L * 10e-6;
            this.na = na;
            this.N0 = N0;
            this.leftBC = leftBC;
            this.rightBC = rightBC;
            this.size = size + 1;
            this.accuracy = accuracy;

            // Определение длины Дебая.
            Ld = Math.Sqrt(eps * eps0 * k * T / (q * q * this.N0 * this.na));
            // Толщина пластины зависит от длины Дебая.
            this.L /= Ld;

            step = this.L / this.size;

            arrayX = new double[this.size];
            arrayFi = new double[this.size];
            arrayPsi = new double[this.size];
            arrayCurrFi = new double[this.size];
            arrayNextFi = new double[this.size];
            for (int i = 0; i < this.size; i++)
            {
                arrayX[i] = step * i;
                arrayNextFi[i] = this.leftBC + (this.rightBC - this.leftBC) * i / this.size;
            }
            a = new double[this.size];
            b = new double[this.size];
        }

        /// <summary>
        /// Решение уравнения Пуассона методом прогонки Гельфанда-Локуциевского.
        /// </summary>
        public void Solve()
        {
            for (int i = 0; i < arrayCurrFi.Length; i++)
                arrayCurrFi[i] = arrayNextFi[i];
            
            // Прямой ход прогонки.
            a[0] = 0;
            b[0] = leftBC;

            for (int i = 1; i < size; i++)
            {
                a[i] = a[i - 1] + (a[i - 1] * a[i - 1] * Q(arrayCurrFi[i - 1]) + 1) * step;
                b[i] = b[i - 1] + (a[i - 1] * b[i - 1] * Q(arrayCurrFi[i - 1]) - a[i - 1] * R(arrayCurrFi[i - 1])) * step;
            }
            arrayNextFi[size - 1] = rightBC;
            arrayPsi[size - 1] = (arrayNextFi[size - 1] - b[size - 1]) / a[size - 1];

            // Обратный ход прогонки.
            for (int i = size - 2; i >= 0; i--)
                arrayPsi[i] = arrayPsi[i + 1] - (R(arrayCurrFi[i + 1]) - Q(arrayCurrFi[i + 1]) * (a[i + 1] * arrayPsi[i + 1] + b[i + 1])) * step;

            for (int i = 0; i < size - 1; i++)
                arrayNextFi[i] = a[i] * arrayPsi[i] + b[i];

            // Выход результат итерации
            for (int i = 0; i < arrayFi.Length; i++)
                arrayFi[i] = arrayNextFi[i];
        }

        /// <summary>
        /// Сравнение норм.
        /// </summary>
        /// <returns></returns>
        public double DiffNorm()
        {
            double sum = 0;
            for (int i = 0; i < size; i++)
                sum += Math.Abs(arrayNextFi[i] - arrayCurrFi[i]);
            return sum;
        }

        /// <summary>
        /// Правая часть уравнения Пуассона.
        /// </summary>
        /// <param name="pot"></param>
        /// <returns></returns>
        private double F(double pot)
        {
            return -na * (1 - Math.Exp(pot));
        }
        /// <summary>
        /// Производная функции F по pot.
        /// </summary>
        /// <param name="pot"></param>
        /// <returns></returns>
        private double Q(double pot)
        {
            return -na * Math.Exp(pot);
        }
        /// <summary>
        /// Линейное приближение.
        /// </summary>
        /// <param name="pot"></param>
        /// <returns></returns>
        private double R(double pot)
        {
            return F(pot) + Q(pot) * pot;
        }
    }
}