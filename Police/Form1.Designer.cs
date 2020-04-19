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
            this.PDS = new System.Windows.Forms.TextBox();
            this.PMEN = new System.Windows.Forms.TextBox();
            this.SALARY = new System.Windows.Forms.TextBox();
            this.PB = new System.Windows.Forms.TextBox();
            this.CRLGOVCARE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PDS
            // 
            this.PDS.Location = new System.Drawing.Point(113, 39);
            this.PDS.Name = "PDS";
            this.PDS.Size = new System.Drawing.Size(100, 22);
            this.PDS.TabIndex = 0;
            // 
            // PMEN
            // 
            this.PMEN.Location = new System.Drawing.Point(253, 49);
            this.PMEN.Name = "PMEN";
            this.PMEN.Size = new System.Drawing.Size(100, 22);
            this.PMEN.TabIndex = 1;
            // 
            // SALARY
            // 
            this.SALARY.Location = new System.Drawing.Point(312, 161);
            this.SALARY.Name = "SALARY";
            this.SALARY.Size = new System.Drawing.Size(100, 22);
            this.SALARY.TabIndex = 2;
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(85, 298);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(100, 22);
            this.PB.TabIndex = 3;
            // 
            // CRLGOVCARE
            // 
            this.CRLGOVCARE.Location = new System.Drawing.Point(169, 428);
            this.CRLGOVCARE.Name = "CRLGOVCARE";
            this.CRLGOVCARE.Size = new System.Drawing.Size(100, 22);
            this.CRLGOVCARE.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Police.Properties.Resources.scheme;
            this.ClientSize = new System.Drawing.Size(906, 479);
            this.Controls.Add(this.CRLGOVCARE);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.SALARY);
            this.Controls.Add(this.PMEN);
            this.Controls.Add(this.PDS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PDS;
        private System.Windows.Forms.TextBox PMEN;
        private System.Windows.Forms.TextBox SALARY;
        private System.Windows.Forms.TextBox PB;
        private System.Windows.Forms.TextBox CRLGOVCARE;
    }
}

