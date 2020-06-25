namespace HuabaLauncher
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.install_client = new System.Windows.Forms.Button();
            this.download_panel = new System.Windows.Forms.Panel();
            this.install_panel = new System.Windows.Forms.Panel();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.play_panel = new System.Windows.Forms.Panel();
            this.play = new System.Windows.Forms.Button();
            this.website = new System.Windows.Forms.Button();
            this.download_panel.SuspendLayout();
            this.install_panel.SuspendLayout();
            this.play_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 322);
            this.panel1.TabIndex = 1;
            // 
            // install_client
            // 
            this.install_client.Location = new System.Drawing.Point(147, 16);
            this.install_client.Name = "install_client";
            this.install_client.Size = new System.Drawing.Size(75, 23);
            this.install_client.TabIndex = 1;
            this.install_client.Text = "Install Client";
            this.install_client.UseVisualStyleBackColor = true;
            this.install_client.Click += new System.EventHandler(this.install_client_Click);
            // 
            // download_panel
            // 
            this.download_panel.Controls.Add(this.circularProgressBar1);
            this.download_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.download_panel.Location = new System.Drawing.Point(0, 328);
            this.download_panel.Name = "download_panel";
            this.download_panel.Size = new System.Drawing.Size(369, 133);
            this.download_panel.TabIndex = 2;
            // 
            // install_panel
            // 
            this.install_panel.Controls.Add(this.install_client);
            this.install_panel.Location = new System.Drawing.Point(0, 328);
            this.install_panel.Name = "install_panel";
            this.install_panel.Size = new System.Drawing.Size(369, 133);
            this.install_panel.TabIndex = 3;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(134, 16);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.OuterMargin = -5;
            this.circularProgressBar1.OuterWidth = 5;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Lime;
            this.circularProgressBar1.ProgressWidth = 5;
            this.circularProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Step = 1;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 0;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 100;
            // 
            // play_panel
            // 
            this.play_panel.Controls.Add(this.website);
            this.play_panel.Controls.Add(this.play);
            this.play_panel.Location = new System.Drawing.Point(0, 328);
            this.play_panel.Name = "play_panel";
            this.play_panel.Size = new System.Drawing.Size(369, 133);
            this.play_panel.TabIndex = 4;
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(147, 16);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 23);
            this.play.TabIndex = 1;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // website
            // 
            this.website.Location = new System.Drawing.Point(147, 66);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(75, 23);
            this.website.TabIndex = 2;
            this.website.Text = "Visit Website";
            this.website.UseVisualStyleBackColor = true;
            this.website.Click += new System.EventHandler(this.website_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(369, 461);
            this.Controls.Add(this.install_panel);
            this.Controls.Add(this.download_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.play_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.download_panel.ResumeLayout(false);
            this.install_panel.ResumeLayout(false);
            this.play_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel download_panel;
        private System.Windows.Forms.Panel install_panel;
        private System.Windows.Forms.Button install_client;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Panel play_panel;
        private System.Windows.Forms.Button website;
        private System.Windows.Forms.Button play;
    }
}

