namespace Police
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pmSalary = new System.Windows.Forms.Label();
            this.moralLevel = new System.Windows.Forms.Label();
            this.pEValue = new System.Windows.Forms.Label();
            this.pDValue = new System.Windows.Forms.Label();
            this.pB = new System.Windows.Forms.Label();
            this.govCareLevel = new System.Windows.Forms.Label();
            this.CorrLevel = new System.Windows.Forms.Label();
            this.crimeLevel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.thiefsValue = new System.Windows.Forms.NumericUpDown();
            this.depsValue = new System.Windows.Forms.NumericUpDown();
            this.crimesValue = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPolice = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thiefsValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depsValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimesValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPolice)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pmSalary);
            this.panel1.Controls.Add(this.moralLevel);
            this.panel1.Controls.Add(this.pEValue);
            this.panel1.Controls.Add(this.pDValue);
            this.panel1.Controls.Add(this.pB);
            this.panel1.Controls.Add(this.govCareLevel);
            this.panel1.Controls.Add(this.CorrLevel);
            this.panel1.Controls.Add(this.crimeLevel);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.thiefsValue);
            this.panel1.Controls.Add(this.depsValue);
            this.panel1.Controls.Add(this.crimesValue);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1762, 150);
            this.panel1.TabIndex = 0;
            // 
            // pmSalary
            // 
            this.pmSalary.AutoSize = true;
            this.pmSalary.Location = new System.Drawing.Point(589, 123);
            this.pmSalary.Name = "pmSalary";
            this.pmSalary.Size = new System.Drawing.Size(0, 17);
            this.pmSalary.TabIndex = 23;
            // 
            // moralLevel
            // 
            this.moralLevel.AutoSize = true;
            this.moralLevel.Location = new System.Drawing.Point(577, 106);
            this.moralLevel.Name = "moralLevel";
            this.moralLevel.Size = new System.Drawing.Size(0, 17);
            this.moralLevel.TabIndex = 22;
            // 
            // pEValue
            // 
            this.pEValue.AutoSize = true;
            this.pEValue.Location = new System.Drawing.Point(560, 90);
            this.pEValue.Name = "pEValue";
            this.pEValue.Size = new System.Drawing.Size(0, 17);
            this.pEValue.TabIndex = 21;
            // 
            // pDValue
            // 
            this.pDValue.AutoSize = true;
            this.pDValue.Location = new System.Drawing.Point(620, 72);
            this.pDValue.Name = "pDValue";
            this.pDValue.Size = new System.Drawing.Size(0, 17);
            this.pDValue.TabIndex = 20;
            // 
            // pB
            // 
            this.pB.AutoSize = true;
            this.pB.Location = new System.Drawing.Point(578, 55);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(0, 17);
            this.pB.TabIndex = 19;
            // 
            // govCareLevel
            // 
            this.govCareLevel.AutoSize = true;
            this.govCareLevel.Location = new System.Drawing.Point(669, 38);
            this.govCareLevel.Name = "govCareLevel";
            this.govCareLevel.Size = new System.Drawing.Size(0, 17);
            this.govCareLevel.TabIndex = 18;
            // 
            // CorrLevel
            // 
            this.CorrLevel.AutoSize = true;
            this.CorrLevel.Location = new System.Drawing.Point(538, 21);
            this.CorrLevel.Name = "CorrLevel";
            this.CorrLevel.Size = new System.Drawing.Size(0, 17);
            this.CorrLevel.TabIndex = 17;
            // 
            // crimeLevel
            // 
            this.crimeLevel.AutoSize = true;
            this.crimeLevel.Location = new System.Drawing.Point(616, 4);
            this.crimeLevel.Name = "crimeLevel";
            this.crimeLevel.Size = new System.Drawing.Size(0, 17);
            this.crimeLevel.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(448, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "З.П. полицейского:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(448, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Мораль полиции:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(448, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Штат полиции:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(448, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Количество отделений:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Бюджет полиции:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Обеспокоенность государства:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Коррупция:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Уровень преступности:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Преступники:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кол-во отделений полиции:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Кол-во преступлений на данный момент:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Начальные значения";
            // 
            // thiefsValue
            // 
            this.thiefsValue.Location = new System.Drawing.Point(108, 91);
            this.thiefsValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.thiefsValue.Name = "thiefsValue";
            this.thiefsValue.Size = new System.Drawing.Size(120, 22);
            this.thiefsValue.TabIndex = 3;
            // 
            // depsValue
            // 
            this.depsValue.Location = new System.Drawing.Point(198, 63);
            this.depsValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.depsValue.Name = "depsValue";
            this.depsValue.Size = new System.Drawing.Size(120, 22);
            this.depsValue.TabIndex = 2;
            // 
            // crimesValue
            // 
            this.crimesValue.Location = new System.Drawing.Point(291, 35);
            this.crimesValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.crimesValue.Name = "crimesValue";
            this.crimesValue.Size = new System.Drawing.Size(120, 22);
            this.crimesValue.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(234, 91);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(81, 50);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Старт!!!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // chart1
            // 
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            // 
            // chart2
            // 
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 0;
            // 
            // chart3
            // 
            this.chart3.Location = new System.Drawing.Point(0, 0);
            this.chart3.Name = "chart3";
            this.chart3.Size = new System.Drawing.Size(300, 300);
            this.chart3.TabIndex = 0;
            // 
            // chart4
            // 
            this.chart4.Location = new System.Drawing.Point(0, 0);
            this.chart4.Name = "chart4";
            this.chart4.Size = new System.Drawing.Size(300, 300);
            this.chart4.TabIndex = 0;
            // 
            // chartPolice
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPolice.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPolice.Legends.Add(legend1);
            this.chartPolice.Location = new System.Drawing.Point(13, 169);
            this.chartPolice.Name = "chartPolice";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Crimes";
            this.chartPolice.Series.Add(series1);
            this.chartPolice.Size = new System.Drawing.Size(1762, 697);
            this.chartPolice.TabIndex = 1;
            this.chartPolice.Text = "chart5";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 878);
            this.Controls.Add(this.chartPolice);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thiefsValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depsValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimesValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPolice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown thiefsValue;
        private System.Windows.Forms.NumericUpDown depsValue;
        private System.Windows.Forms.NumericUpDown crimesValue;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPolice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pmSalary;
        private System.Windows.Forms.Label moralLevel;
        private System.Windows.Forms.Label pEValue;
        private System.Windows.Forms.Label pDValue;
        private System.Windows.Forms.Label pB;
        private System.Windows.Forms.Label govCareLevel;
        private System.Windows.Forms.Label CorrLevel;
        private System.Windows.Forms.Label crimeLevel;

    }
}

