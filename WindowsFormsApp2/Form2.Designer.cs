﻿namespace WindowsFormsApp2
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.startButton = new System.Windows.Forms.Button();
            this.randBar = new System.Windows.Forms.TrackBar();
            this.AlphaBar = new System.Windows.Forms.TrackBar();
            this.GammaBar = new System.Windows.Forms.TrackBar();
            this.durationBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CoeffBar = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.Coeff = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PeopleLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.randBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GammaBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoeffBar)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(731, 36);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(174, 81);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // randBar
            // 
            this.randBar.Location = new System.Drawing.Point(92, 170);
            this.randBar.Name = "randBar";
            this.randBar.Size = new System.Drawing.Size(506, 56);
            this.randBar.TabIndex = 1;
            this.randBar.Scroll += new System.EventHandler(this.randBar_Scroll);
            // 
            // AlphaBar
            // 
            this.AlphaBar.Location = new System.Drawing.Point(92, 64);
            this.AlphaBar.Maximum = 100;
            this.AlphaBar.Name = "AlphaBar";
            this.AlphaBar.Size = new System.Drawing.Size(506, 56);
            this.AlphaBar.TabIndex = 2;
            this.AlphaBar.Scroll += new System.EventHandler(this.AlphaBar_Scroll);
            // 
            // GammaBar
            // 
            this.GammaBar.Location = new System.Drawing.Point(92, 118);
            this.GammaBar.Maximum = 100;
            this.GammaBar.Minimum = 1;
            this.GammaBar.Name = "GammaBar";
            this.GammaBar.Size = new System.Drawing.Size(506, 56);
            this.GammaBar.TabIndex = 3;
            this.GammaBar.Value = 1;
            this.GammaBar.Scroll += new System.EventHandler(this.GammaBar_Scroll);
            // 
            // durationBar
            // 
            this.durationBar.Location = new System.Drawing.Point(92, 12);
            this.durationBar.Maximum = 100;
            this.durationBar.Minimum = 10;
            this.durationBar.Name = "durationBar";
            this.durationBar.Size = new System.Drawing.Size(506, 56);
            this.durationBar.TabIndex = 4;
            this.durationBar.Value = 10;
            this.durationBar.Scroll += new System.EventHandler(this.durationBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Событий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Альфа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Гамма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(604, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(604, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(604, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 34);
            this.label9.TabIndex = 14;
            this.label9.Text = "Диапозон\r\n рандома";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(38, 281);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1051, 404);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // CoeffBar
            // 
            this.CoeffBar.Location = new System.Drawing.Point(92, 219);
            this.CoeffBar.Maximum = 100;
            this.CoeffBar.Minimum = 10;
            this.CoeffBar.Name = "CoeffBar";
            this.CoeffBar.Size = new System.Drawing.Size(506, 56);
            this.CoeffBar.TabIndex = 20;
            this.CoeffBar.Value = 10;
            this.CoeffBar.Scroll += new System.EventHandler(this.CoeffBar_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(-2, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 32);
            this.label11.TabIndex = 21;
            this.label11.Text = "Коэффициент \r\nвремени";
            // 
            // Coeff
            // 
            this.Coeff.AutoSize = true;
            this.Coeff.Location = new System.Drawing.Point(599, 223);
            this.Coeff.Name = "Coeff";
            this.Coeff.Size = new System.Drawing.Size(24, 17);
            this.Coeff.TabIndex = 22;
            this.Coeff.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(731, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Всего людей:";
            // 
            // PeopleLb
            // 
            this.PeopleLb.AutoSize = true;
            this.PeopleLb.Location = new System.Drawing.Point(833, 143);
            this.PeopleLb.Name = "PeopleLb";
            this.PeopleLb.Size = new System.Drawing.Size(16, 17);
            this.PeopleLb.TabIndex = 24;
            this.PeopleLb.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 697);
            this.Controls.Add(this.PeopleLb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Coeff);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CoeffBar);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.durationBar);
            this.Controls.Add(this.GammaBar);
            this.Controls.Add(this.AlphaBar);
            this.Controls.Add(this.randBar);
            this.Controls.Add(this.startButton);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.randBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GammaBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoeffBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TrackBar randBar;
        private System.Windows.Forms.TrackBar AlphaBar;
        private System.Windows.Forms.TrackBar GammaBar;
        private System.Windows.Forms.TrackBar durationBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TrackBar CoeffBar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Coeff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PeopleLb;
    }
}