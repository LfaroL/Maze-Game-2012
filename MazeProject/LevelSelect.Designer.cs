namespace MazeProject
{
    partial class LevelSelect
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
            this.newButton = new System.Windows.Forms.Button();
            this.levelButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newButton
            // 
            this.newButton.BackgroundImage = global::MazeProject.Properties.Resources.NewGame;
            this.newButton.Location = new System.Drawing.Point(264, 150);
            this.newButton.Margin = new System.Windows.Forms.Padding(4);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(302, 67);
            this.newButton.TabIndex = 1;
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // levelButton
            // 
            this.levelButton.BackgroundImage = global::MazeProject.Properties.Resources.LevelSelect;
            this.levelButton.Location = new System.Drawing.Point(264, 250);
            this.levelButton.Margin = new System.Windows.Forms.Padding(4);
            this.levelButton.Name = "levelButton";
            this.levelButton.Size = new System.Drawing.Size(302, 67);
            this.levelButton.TabIndex = 2;
            this.levelButton.UseVisualStyleBackColor = true;
            this.levelButton.Click += new System.EventHandler(this.levelButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::MazeProject.Properties.Resources.Back;
            this.backButton.Location = new System.Drawing.Point(264, 350);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(302, 67);
            this.backButton.TabIndex = 3;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // LevelSelect
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::MazeProject.Properties.Resources.Border;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 549);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.levelButton);
            this.Controls.Add(this.newButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LevelSelect";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LevelSelect";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button levelButton;
        private System.Windows.Forms.Button backButton;
    }
}