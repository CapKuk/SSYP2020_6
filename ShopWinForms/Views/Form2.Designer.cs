namespace ShopWinForms
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.profit = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Прибыль за день:";
            // 
            // profit
            // 
            this.profit.AutoSize = true;
            this.profit.Location = new System.Drawing.Point(357, 245);
            this.profit.Name = "profit";
            this.profit.Size = new System.Drawing.Size(16, 17);
            this.profit.TabIndex = 3;
            this.profit.Text = "0";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(400, 197);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(16, 17);
            this.count.TabIndex = 1;
            this.count.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Обслужано покупателей: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(209, 107);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(207, 23);
            this.progress.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 368);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.profit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label profit;
        public System.Windows.Forms.Label count;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ProgressBar progress;
    }
}