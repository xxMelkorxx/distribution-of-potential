
namespace DistributionOfPotential
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox groupBox_Potential;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.GroupBox groupBox_paramsSystem;
            System.Windows.Forms.Label label_Size;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label_Accuracy;
            System.Windows.Forms.Label labelValueN0;
            System.Windows.Forms.Label label_N0;
            System.Windows.Forms.Label label_rightBC;
            System.Windows.Forms.Label label_Na;
            System.Windows.Forms.Label label_L;
            this.chart_Potential = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numUpDown_Size = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_Accuracy = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_N0 = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_leftBC = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_Na = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_L = new System.Windows.Forms.NumericUpDown();
            this.button_Solve = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            groupBox_Potential = new System.Windows.Forms.GroupBox();
            groupBox_paramsSystem = new System.Windows.Forms.GroupBox();
            label_Size = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label_Accuracy = new System.Windows.Forms.Label();
            labelValueN0 = new System.Windows.Forms.Label();
            label_N0 = new System.Windows.Forms.Label();
            label_rightBC = new System.Windows.Forms.Label();
            label_Na = new System.Windows.Forms.Label();
            label_L = new System.Windows.Forms.Label();
            groupBox_Potential.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Potential)).BeginInit();
            groupBox_paramsSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Accuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_N0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_leftBC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Na)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_L)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Potential
            // 
            groupBox_Potential.Controls.Add(this.chart_Potential);
            groupBox_Potential.Location = new System.Drawing.Point(12, 12);
            groupBox_Potential.Name = "groupBox_Potential";
            groupBox_Potential.Size = new System.Drawing.Size(608, 411);
            groupBox_Potential.TabIndex = 0;
            groupBox_Potential.TabStop = false;
            groupBox_Potential.Text = "График распределения потенциала по пластине:";
            // 
            // chart_Potential
            // 
            this.chart_Potential.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.Title = "x, μm";
            chartArea2.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic);
            chartArea2.AxisY.Title = "φ/Фo";
            chartArea2.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic);
            chartArea2.Name = "ChartArea1";
            this.chart_Potential.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Name = "Legend1";
            this.chart_Potential.Legends.Add(legend2);
            this.chart_Potential.Location = new System.Drawing.Point(6, 19);
            this.chart_Potential.Name = "chart_Potential";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Распределение потенциала";
            this.chart_Potential.Series.Add(series2);
            this.chart_Potential.Size = new System.Drawing.Size(596, 386);
            this.chart_Potential.TabIndex = 0;
            this.chart_Potential.Text = "chart1";
            // 
            // groupBox_paramsSystem
            // 
            groupBox_paramsSystem.Controls.Add(this.numUpDown_Size);
            groupBox_paramsSystem.Controls.Add(label_Size);
            groupBox_paramsSystem.Controls.Add(label3);
            groupBox_paramsSystem.Controls.Add(this.numUpDown_Accuracy);
            groupBox_paramsSystem.Controls.Add(label_Accuracy);
            groupBox_paramsSystem.Controls.Add(labelValueN0);
            groupBox_paramsSystem.Controls.Add(this.numUpDown_N0);
            groupBox_paramsSystem.Controls.Add(label_N0);
            groupBox_paramsSystem.Controls.Add(this.numUpDown_leftBC);
            groupBox_paramsSystem.Controls.Add(label_rightBC);
            groupBox_paramsSystem.Controls.Add(this.numUpDown_Na);
            groupBox_paramsSystem.Controls.Add(label_Na);
            groupBox_paramsSystem.Controls.Add(this.numUpDown_L);
            groupBox_paramsSystem.Controls.Add(label_L);
            groupBox_paramsSystem.Location = new System.Drawing.Point(626, 12);
            groupBox_paramsSystem.Name = "groupBox_paramsSystem";
            groupBox_paramsSystem.Size = new System.Drawing.Size(246, 375);
            groupBox_paramsSystem.TabIndex = 2;
            groupBox_paramsSystem.TabStop = false;
            groupBox_paramsSystem.Text = "Параметра задачи:";
            // 
            // numUpDown_Size
            // 
            this.numUpDown_Size.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpDown_Size.Location = new System.Drawing.Point(9, 230);
            this.numUpDown_Size.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numUpDown_Size.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpDown_Size.Name = "numUpDown_Size";
            this.numUpDown_Size.Size = new System.Drawing.Size(47, 20);
            this.numUpDown_Size.TabIndex = 14;
            this.numUpDown_Size.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label_Size
            // 
            label_Size.AutoSize = true;
            label_Size.Location = new System.Drawing.Point(6, 214);
            label_Size.Name = "label_Size";
            label_Size.Size = new System.Drawing.Size(74, 13);
            label_Size.TabIndex = 13;
            label_Size.Text = "Число узлов:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 193);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(25, 13);
            label3.TabIndex = 12;
            label3.Text = "10^";
            // 
            // numUpDown_Accuracy
            // 
            this.numUpDown_Accuracy.Location = new System.Drawing.Point(37, 191);
            this.numUpDown_Accuracy.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDown_Accuracy.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.numUpDown_Accuracy.Name = "numUpDown_Accuracy";
            this.numUpDown_Accuracy.Size = new System.Drawing.Size(47, 20);
            this.numUpDown_Accuracy.TabIndex = 11;
            this.numUpDown_Accuracy.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // label_Accuracy
            // 
            label_Accuracy.AutoSize = true;
            label_Accuracy.Location = new System.Drawing.Point(6, 175);
            label_Accuracy.Name = "label_Accuracy";
            label_Accuracy.Size = new System.Drawing.Size(104, 13);
            label_Accuracy.TabIndex = 9;
            label_Accuracy.Text = "Точность решения:";
            // 
            // labelValueN0
            // 
            labelValueN0.AutoSize = true;
            labelValueN0.Location = new System.Drawing.Point(6, 115);
            labelValueN0.Name = "labelValueN0";
            labelValueN0.Size = new System.Drawing.Size(25, 13);
            labelValueN0.TabIndex = 8;
            labelValueN0.Text = "10^";
            // 
            // numUpDown_N0
            // 
            this.numUpDown_N0.Location = new System.Drawing.Point(37, 113);
            this.numUpDown_N0.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numUpDown_N0.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_N0.Name = "numUpDown_N0";
            this.numUpDown_N0.Size = new System.Drawing.Size(47, 20);
            this.numUpDown_N0.TabIndex = 7;
            this.numUpDown_N0.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // label_N0
            // 
            label_N0.AutoSize = true;
            label_N0.Location = new System.Drawing.Point(6, 97);
            label_N0.Name = "label_N0";
            label_N0.Size = new System.Drawing.Size(145, 13);
            label_N0.TabIndex = 6;
            label_N0.Text = "Опорная концентрация N0:";
            // 
            // numUpDown_leftBC
            // 
            this.numUpDown_leftBC.DecimalPlaces = 3;
            this.numUpDown_leftBC.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numUpDown_leftBC.Location = new System.Drawing.Point(9, 152);
            this.numUpDown_leftBC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numUpDown_leftBC.Name = "numUpDown_leftBC";
            this.numUpDown_leftBC.Size = new System.Drawing.Size(75, 20);
            this.numUpDown_leftBC.TabIndex = 5;
            this.numUpDown_leftBC.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label_rightBC
            // 
            label_rightBC.AutoSize = true;
            label_rightBC.Location = new System.Drawing.Point(6, 136);
            label_rightBC.Name = "label_rightBC";
            label_rightBC.Size = new System.Drawing.Size(189, 13);
            label_rightBC.TabIndex = 4;
            label_rightBC.Text = "Значение потенциала на границе V:";
            // 
            // numUpDown_Na
            // 
            this.numUpDown_Na.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDown_Na.Location = new System.Drawing.Point(9, 74);
            this.numUpDown_Na.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDown_Na.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_Na.Name = "numUpDown_Na";
            this.numUpDown_Na.Size = new System.Drawing.Size(75, 20);
            this.numUpDown_Na.TabIndex = 3;
            this.numUpDown_Na.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label_Na
            // 
            label_Na.AutoSize = true;
            label_Na.Location = new System.Drawing.Point(6, 58);
            label_Na.Name = "label_Na";
            label_Na.Size = new System.Drawing.Size(223, 13);
            label_Na.TabIndex = 2;
            label_Na.Text = "Относительная концентрация бора Na (%):";
            // 
            // numUpDown_L
            // 
            this.numUpDown_L.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDown_L.Location = new System.Drawing.Point(9, 35);
            this.numUpDown_L.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDown_L.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_L.Name = "numUpDown_L";
            this.numUpDown_L.Size = new System.Drawing.Size(75, 20);
            this.numUpDown_L.TabIndex = 1;
            this.numUpDown_L.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label_L
            // 
            label_L.AutoSize = true;
            label_L.Location = new System.Drawing.Point(6, 19);
            label_L.Name = "label_L";
            label_L.Size = new System.Drawing.Size(213, 13);
            label_L.TabIndex = 0;
            label_L.Text = "Толщина кремниевой пластины L (мкм):";
            // 
            // button_Solve
            // 
            this.button_Solve.Location = new System.Drawing.Point(626, 393);
            this.button_Solve.Name = "button_Solve";
            this.button_Solve.Size = new System.Drawing.Size(246, 30);
            this.button_Solve.TabIndex = 1;
            this.button_Solve.Text = "Решить";
            this.button_Solve.UseVisualStyleBackColor = true;
            this.button_Solve.Click += new System.EventHandler(this.OnClickButtonSolve);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.OnTickTimer);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 429);
            this.Controls.Add(groupBox_paramsSystem);
            this.Controls.Add(this.button_Solve);
            this.Controls.Add(groupBox_Potential);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "ИТФИ ННГУ | Задача 2. Решение уравнения Пуассона";
            groupBox_Potential.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Potential)).EndInit();
            groupBox_paramsSystem.ResumeLayout(false);
            groupBox_paramsSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Accuracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_N0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_leftBC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Na)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_L)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Potential;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown numUpDown_leftBC;
        private System.Windows.Forms.NumericUpDown numUpDown_Na;
        private System.Windows.Forms.NumericUpDown numUpDown_L;
        private System.Windows.Forms.NumericUpDown numUpDown_N0;
        private System.Windows.Forms.NumericUpDown numUpDown_Accuracy;
        private System.Windows.Forms.NumericUpDown numUpDown_Size;
        private System.Windows.Forms.Button button_Solve;
    }
}

