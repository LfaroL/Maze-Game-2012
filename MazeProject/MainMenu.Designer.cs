namespace MazeProject
{
    partial class MainMenu
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
            this.playButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackgroundImage = global::MazeProject.Properties.Resources.Play;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playButton.Location = new System.Drawing.Point(264, 150);
            this.playButton.Margin = new System.Windows.Forms.Padding(4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(302, 67);
            this.playButton.TabIndex = 0;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.BackgroundImage = global::MazeProject.Properties.Resources.Options;
            this.optionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.optionsButton.Location = new System.Drawing.Point(264, 250);
            this.optionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(302, 67);
            this.optionsButton.TabIndex = 1;
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::MazeProject.Properties.Resources.Exit;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.Location = new System.Drawing.Point(264, 350);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(302, 67);
            this.exitButton.TabIndex = 2;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::MazeProject.Properties.Resources.Border;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 549);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.playButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button exitButton;
    }
}

