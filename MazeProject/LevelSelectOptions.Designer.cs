namespace MazeProject
{
    partial class LevelSelectOptions
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
            this.optionsLabel = new System.Windows.Forms.Label();
            this.leveloneButton = new System.Windows.Forms.Button();
            this.leveltwoButton = new System.Windows.Forms.Button();
            this.levelthreeButton = new System.Windows.Forms.Button();
            this.levelfourButton = new System.Windows.Forms.Button();
            this.levelfiveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsLabel.Location = new System.Drawing.Point(283, 54);
            this.optionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(234, 42);
            this.optionsLabel.TabIndex = 10;
            this.optionsLabel.Text = "Level Select";
            // 
            // leveloneButton
            // 
            this.leveloneButton.BackgroundImage = global::MazeProject.Properties.Resources.LevelOne;
            this.leveloneButton.Location = new System.Drawing.Point(248, 109);
            this.leveloneButton.Margin = new System.Windows.Forms.Padding(4);
            this.leveloneButton.Name = "leveloneButton";
            this.leveloneButton.Size = new System.Drawing.Size(301, 58);
            this.leveloneButton.TabIndex = 11;
            this.leveloneButton.UseVisualStyleBackColor = true;
            this.leveloneButton.Click += new System.EventHandler(this.leveloneButton_Click);
            // 
            // leveltwoButton
            // 
            this.leveltwoButton.BackgroundImage = global::MazeProject.Properties.Resources.LevelTwo;
            this.leveltwoButton.Location = new System.Drawing.Point(248, 175);
            this.leveltwoButton.Margin = new System.Windows.Forms.Padding(4);
            this.leveltwoButton.Name = "leveltwoButton";
            this.leveltwoButton.Size = new System.Drawing.Size(301, 58);
            this.leveltwoButton.TabIndex = 12;
            this.leveltwoButton.UseVisualStyleBackColor = true;
            this.leveltwoButton.Click += new System.EventHandler(this.leveltwoButton_Click);
            // 
            // levelthreeButton
            // 
            this.levelthreeButton.BackgroundImage = global::MazeProject.Properties.Resources.LevelThree;
            this.levelthreeButton.Location = new System.Drawing.Point(248, 241);
            this.levelthreeButton.Margin = new System.Windows.Forms.Padding(4);
            this.levelthreeButton.Name = "levelthreeButton";
            this.levelthreeButton.Size = new System.Drawing.Size(301, 58);
            this.levelthreeButton.TabIndex = 13;
            this.levelthreeButton.UseVisualStyleBackColor = true;
            this.levelthreeButton.Click += new System.EventHandler(this.levelthreeButton_Click);
            // 
            // levelfourButton
            // 
            this.levelfourButton.BackgroundImage = global::MazeProject.Properties.Resources.LevelFour;
            this.levelfourButton.Location = new System.Drawing.Point(248, 307);
            this.levelfourButton.Margin = new System.Windows.Forms.Padding(4);
            this.levelfourButton.Name = "levelfourButton";
            this.levelfourButton.Size = new System.Drawing.Size(301, 52);
            this.levelfourButton.TabIndex = 14;
            this.levelfourButton.UseVisualStyleBackColor = true;
            this.levelfourButton.Click += new System.EventHandler(this.levelfourButton_Click);
            // 
            // levelfiveButton
            // 
            this.levelfiveButton.BackgroundImage = global::MazeProject.Properties.Resources.LevelFive;
            this.levelfiveButton.Location = new System.Drawing.Point(248, 367);
            this.levelfiveButton.Margin = new System.Windows.Forms.Padding(4);
            this.levelfiveButton.Name = "levelfiveButton";
            this.levelfiveButton.Size = new System.Drawing.Size(301, 58);
            this.levelfiveButton.TabIndex = 15;
            this.levelfiveButton.UseVisualStyleBackColor = true;
            this.levelfiveButton.Click += new System.EventHandler(this.levelfiveButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::MazeProject.Properties.Resources.Back;
            this.backButton.Location = new System.Drawing.Point(248, 433);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(301, 58);
            this.backButton.TabIndex = 16;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // LevelSelectOptions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::MazeProject.Properties.Resources.Border;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 549);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.levelfiveButton);
            this.Controls.Add(this.levelfourButton);
            this.Controls.Add(this.levelthreeButton);
            this.Controls.Add(this.leveltwoButton);
            this.Controls.Add(this.leveloneButton);
            this.Controls.Add(this.optionsLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LevelSelectOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LevelSelectOptions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LevelSelectOptions_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Button leveloneButton;
        private System.Windows.Forms.Button leveltwoButton;
        private System.Windows.Forms.Button levelthreeButton;
        private System.Windows.Forms.Button levelfourButton;
        private System.Windows.Forms.Button levelfiveButton;
        private System.Windows.Forms.Button backButton;
    }
}