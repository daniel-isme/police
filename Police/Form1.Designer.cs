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
            this.PDStext = new System.Windows.Forms.TextBox();
            this.PMENtext = new System.Windows.Forms.TextBox();
            this.SALARYtext = new System.Windows.Forms.TextBox();
            this.PBtext = new System.Windows.Forms.TextBox();
            this.CRLGOVCAREtext = new System.Windows.Forms.TextBox();
            this.CRtext = new System.Windows.Forms.TextBox();
            this.PEtext = new System.Windows.Forms.TextBox();
            this.PWEtext = new System.Windows.Forms.TextBox();
            this.CRLtext = new System.Windows.Forms.TextBox();
            this.MORALtext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CORRtext = new System.Windows.Forms.TextBox();
            this.NItext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PDStext
            // 
            this.PDStext.Location = new System.Drawing.Point(106, 49);
            this.PDStext.Name = "PDStext";
            this.PDStext.Size = new System.Drawing.Size(100, 22);
            this.PDStext.TabIndex = 0;
            // 
            // PMENtext
            // 
            this.PMENtext.Location = new System.Drawing.Point(264, 59);
            this.PMENtext.Name = "PMENtext";
            this.PMENtext.Size = new System.Drawing.Size(100, 22);
            this.PMENtext.TabIndex = 1;
            // 
            // SALARYtext
            // 
            this.SALARYtext.Location = new System.Drawing.Point(324, 161);
            this.SALARYtext.Name = "SALARYtext";
            this.SALARYtext.Size = new System.Drawing.Size(100, 22);
            this.SALARYtext.TabIndex = 2;
            // 
            // PBtext
            // 
            this.PBtext.Location = new System.Drawing.Point(81, 314);
            this.PBtext.Name = "PBtext";
            this.PBtext.Size = new System.Drawing.Size(100, 22);
            this.PBtext.TabIndex = 3;
            // 
            // CRLGOVCAREtext
            // 
            this.CRLGOVCAREtext.Location = new System.Drawing.Point(173, 445);
            this.CRLGOVCAREtext.Name = "CRLGOVCAREtext";
            this.CRLGOVCAREtext.Size = new System.Drawing.Size(100, 22);
            this.CRLGOVCAREtext.TabIndex = 4;
            // 
            // CRtext
            // 
            this.CRtext.Location = new System.Drawing.Point(741, 339);
            this.CRtext.Name = "CRtext";
            this.CRtext.Size = new System.Drawing.Size(100, 22);
            this.CRtext.TabIndex = 0;
            // 
            // PEtext
            // 
            this.PEtext.Location = new System.Drawing.Point(815, 176);
            this.PEtext.Name = "PEtext";
            this.PEtext.Size = new System.Drawing.Size(100, 22);
            this.PEtext.TabIndex = 1;
            // 
            // PWEtext
            // 
            this.PWEtext.Location = new System.Drawing.Point(684, 140);
            this.PWEtext.Name = "PWEtext";
            this.PWEtext.Size = new System.Drawing.Size(100, 22);
            this.PWEtext.TabIndex = 2;
            // 
            // CRLtext
            // 
            this.CRLtext.Location = new System.Drawing.Point(523, 431);
            this.CRLtext.Name = "CRLtext";
            this.CRLtext.Size = new System.Drawing.Size(100, 22);
            this.CRLtext.TabIndex = 3;
            // 
            // MORALtext
            // 
            this.MORALtext.Location = new System.Drawing.Point(542, 161);
            this.MORALtext.Name = "MORALtext";
            this.MORALtext.Size = new System.Drawing.Size(100, 22);
            this.MORALtext.TabIndex = 4;
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
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CORRtext
            // 
            this.CORRtext.Location = new System.Drawing.Point(411, 339);
            this.CORRtext.Name = "CORRtext";
            this.CORRtext.Size = new System.Drawing.Size(100, 22);
            this.CORRtext.TabIndex = 6;
            // 
            // NItext
            // 
            this.NItext.Location = new System.Drawing.Point(794, 445);
            this.NItext.Name = "NItext";
            this.NItext.Size = new System.Drawing.Size(100, 22);
            this.NItext.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Police.Properties.Resources.scheme;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 503);
            this.Controls.Add(this.NItext);
            this.Controls.Add(this.CORRtext);
            this.Controls.Add(this.CRLGOVCAREtext);
            this.Controls.Add(this.PBtext);
            this.Controls.Add(this.SALARYtext);
            this.Controls.Add(this.PMENtext);
            this.Controls.Add(this.PDStext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MORALtext);
            this.Controls.Add(this.CRLtext);
            this.Controls.Add(this.PWEtext);
            this.Controls.Add(this.PEtext);
            this.Controls.Add(this.CRtext);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PDStext;
        private System.Windows.Forms.TextBox PMENtext;
        private System.Windows.Forms.TextBox SALARYtext;
        private System.Windows.Forms.TextBox PBtext;
        private System.Windows.Forms.TextBox CRLGOVCAREtext;

        private System.Windows.Forms.TextBox CRtext;
        private System.Windows.Forms.TextBox PEtext;
        private System.Windows.Forms.TextBox PWEtext;
        private System.Windows.Forms.TextBox CRLtext;
        private System.Windows.Forms.TextBox MORALtext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox CORRtext;
        private System.Windows.Forms.TextBox NItext;
    }
}

