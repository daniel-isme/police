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
            this.CR = new System.Windows.Forms.TextBox();
            this.PE = new System.Windows.Forms.TextBox();
            this.PWE = new System.Windows.Forms.TextBox();
            this.CRL = new System.Windows.Forms.TextBox();
            this.MORAL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CR
            // 
            this.CR.Location = new System.Drawing.Point(731, 327);
            this.CR.Name = "CR";
            this.CR.Size = new System.Drawing.Size(100, 22);
            this.CR.TabIndex = 0;
            // 
            // PE
            // 
            this.PE.Location = new System.Drawing.Point(794, 178);
            this.PE.Name = "PE";
            this.PE.Size = new System.Drawing.Size(100, 22);
            this.PE.TabIndex = 1;
            // 
            // PWE
            // 
            this.PWE.Location = new System.Drawing.Point(675, 130);
            this.PWE.Name = "PWE";
            this.PWE.Size = new System.Drawing.Size(100, 22);
            this.PWE.TabIndex = 2;
            // 
            // CRL
            // 
            this.CRL.Location = new System.Drawing.Point(523, 431);
            this.CRL.Name = "CRL";
            this.CRL.Size = new System.Drawing.Size(100, 22);
            this.CRL.TabIndex = 3;
            // 
            // MORAL
            // 
            this.MORAL.Location = new System.Drawing.Point(548, 155);
            this.MORAL.Name = "MORAL";
            this.MORAL.Size = new System.Drawing.Size(100, 22);
            this.MORAL.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "StartButton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Police.Properties.Resources.scheme;
            this.ClientSize = new System.Drawing.Size(906, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MORAL);
            this.Controls.Add(this.CRL);
            this.Controls.Add(this.PWE);
            this.Controls.Add(this.PE);
            this.Controls.Add(this.CR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CR;
        private System.Windows.Forms.TextBox PE;
        private System.Windows.Forms.TextBox PWE;
        private System.Windows.Forms.TextBox CRL;
        private System.Windows.Forms.TextBox MORAL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

