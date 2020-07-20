namespace ShopWinForms
{
    partial class Form1
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
            this.quantityBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.durationBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationBar)).BeginInit();
            this.SuspendLayout();
            // 
            // quantityBar
            // 
            this.quantityBar.LargeChange = 1;
            this.quantityBar.Location = new System.Drawing.Point(151, 33);
            this.quantityBar.Name = "quantityBar";
            this.quantityBar.Size = new System.Drawing.Size(306, 56);
            this.quantityBar.TabIndex = 0;
            this.quantityBar.Scroll += new System.EventHandler(this.quantityBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество\r\n продавцов";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(467, 41);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(16, 17);
            this.quantity.TabIndex = 2;
            this.quantity.Text = "0";
            // 
            // durationBar
            // 
            this.durationBar.Location = new System.Drawing.Point(151, 566);
            this.durationBar.Maximum = 18;
            this.durationBar.Minimum = 6;
            this.durationBar.Name = "durationBar";
            this.durationBar.Size = new System.Drawing.Size(306, 56);
            this.durationBar.TabIndex = 6;
            this.durationBar.Value = 6;
            this.durationBar.Scroll += new System.EventHandler(this.durationBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Длительность\r\n рабочего дня";
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Location = new System.Drawing.Point(470, 568);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(16, 17);
            this.duration.TabIndex = 8;
            this.duration.Text = "6";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(166, 628);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(199, 51);
            this.calculate.TabIndex = 9;
            this.calculate.Text = "Рассчитать";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // flowLayout
            // 
            this.flowLayout.AutoScroll = true;
            this.flowLayout.Location = new System.Drawing.Point(33, 95);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(516, 440);
            this.flowLayout.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 799);
            this.Controls.Add(this.flowLayout);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.durationBar);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityBar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.quantityBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.TrackBar durationBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.TrackBar quantityBar;
    }
}

