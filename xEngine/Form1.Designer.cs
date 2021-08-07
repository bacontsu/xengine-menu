
namespace xEngine
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
            this.label1 = new System.Windows.Forms.Label();
            this.benchBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.settingBtn = new System.Windows.Forms.Button();
            this.discordBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.highlighter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(31, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 115);
            this.label1.TabIndex = 0;
            this.label1.Text = "xEngine";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // benchBtn
            // 
            this.benchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.benchBtn.FlatAppearance.BorderSize = 0;
            this.benchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.benchBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benchBtn.ForeColor = System.Drawing.Color.White;
            this.benchBtn.Location = new System.Drawing.Point(51, 396);
            this.benchBtn.Name = "benchBtn";
            this.benchBtn.Size = new System.Drawing.Size(151, 36);
            this.benchBtn.TabIndex = 1;
            this.benchBtn.Text = "Benchmark";
            this.benchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.benchBtn.UseVisualStyleBackColor = true;
            this.benchBtn.Click += new System.EventHandler(this.benchBtn_Click);
            this.benchBtn.MouseEnter += new System.EventHandler(this.benchBtn_MouseEnter);
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(51, 438);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(151, 36);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Play";
            this.startBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            this.startBtn.MouseEnter += new System.EventHandler(this.startBtn_MouseEnter);
            // 
            // settingBtn
            // 
            this.settingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingBtn.FlatAppearance.BorderSize = 0;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingBtn.ForeColor = System.Drawing.Color.White;
            this.settingBtn.Location = new System.Drawing.Point(51, 480);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(151, 36);
            this.settingBtn.TabIndex = 3;
            this.settingBtn.Text = "Settings";
            this.settingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingBtn.UseVisualStyleBackColor = true;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            this.settingBtn.MouseEnter += new System.EventHandler(this.settingBtn_MouseEnter);
            // 
            // discordBtn
            // 
            this.discordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.discordBtn.FlatAppearance.BorderSize = 0;
            this.discordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discordBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordBtn.ForeColor = System.Drawing.Color.White;
            this.discordBtn.Location = new System.Drawing.Point(51, 522);
            this.discordBtn.Name = "discordBtn";
            this.discordBtn.Size = new System.Drawing.Size(151, 36);
            this.discordBtn.TabIndex = 4;
            this.discordBtn.Text = "Join our Discord";
            this.discordBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.discordBtn.UseVisualStyleBackColor = true;
            this.discordBtn.MouseEnter += new System.EventHandler(this.discordBtn_MouseEnter);
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quitBtn.FlatAppearance.BorderSize = 0;
            this.quitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.ForeColor = System.Drawing.Color.White;
            this.quitBtn.Location = new System.Drawing.Point(51, 564);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(151, 36);
            this.quitBtn.TabIndex = 5;
            this.quitBtn.Text = "Quit";
            this.quitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.button5_Click);
            this.quitBtn.MouseEnter += new System.EventHandler(this.quitBtn_MouseEnter);
            // 
            // highlighter
            // 
            this.highlighter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.highlighter.BackColor = System.Drawing.Color.White;
            this.highlighter.FlatAppearance.BorderSize = 0;
            this.highlighter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highlighter.Location = new System.Drawing.Point(39, 396);
            this.highlighter.Name = "highlighter";
            this.highlighter.Size = new System.Drawing.Size(6, 36);
            this.highlighter.TabIndex = 6;
            this.highlighter.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1097, 673);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Version 0.0.1 Beta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Location = new System.Drawing.Point(30, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 236);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(989, 692);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "For Beta Testing Purposes Only";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.highlighter);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.discordBtn);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.benchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button benchBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.Button discordBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button highlighter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

