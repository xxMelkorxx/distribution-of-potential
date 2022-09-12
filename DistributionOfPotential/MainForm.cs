using System;
using System.Windows.Forms;

namespace DistributionOfPotential
{
    public partial class MainForm : Form
    {
        SemiconductorSystem ss;
        int iter = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnClickButtonSolve(object sender, EventArgs e)
        {
            // Инициализация системы.
            ss = new SemiconductorSystem(
                (double)numUpDown_leftBC.Value,                 // Левое граничное условие.
                0,                                              // Правое граничное условие.
                (double)numUpDown_L.Value,                      // Толщина пластинки.
                (double)numUpDown_Na.Value / 100,               // Относительная концентрация бора.
                Math.Pow(10, (int)numUpDown_N0.Value),          // Опорная концентрация.
                (int)numUpDown_Size.Value,                      // Кол-во точек отсчёта.
                Math.Pow(10, (int)numUpDown_Accuracy.Value)     // Точность решения.
                );
            // Запуск таймера.
            timer.Start();
            iter = 0;
            button_Solve.Enabled = false;
        }

        private void OnTickTimer(object sender, EventArgs e)
        {
            // Решение системы.
            if (ss.DiffNorm() > ss.accuracy && iter < 100)
            {
                ss.Solve();
                iter++;
            }
            else
            {
                timer.Stop();
                button_Solve.Enabled = true;
            }
            // Отрисовка графика.
            chart_Potential.Series[0].Points.Clear();
            for (int i = 0; i < ss.arrayX.Length; i++)
                chart_Potential.Series[0].Points.AddXY(ss.arrayX[i], ss.arrayFi[i]);
        }
    }
}
