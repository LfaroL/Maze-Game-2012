namespace MazeProject
{
    partial class Options
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
            this.exitButton = new System.Windows.Forms.Button();
            this.charLabel = new System.Windows.Forms.Label();
            this.clownBox = new System.Windows.Forms.PictureBox();
            this.zorroBox = new System.Windows.Forms.PictureBox();
            this.charPanel = new System.Windows.Forms.Panel();
            this.zorroButton = new System.Windows.Forms.RadioButton();
            this.clownButton = new System.Windows.Forms.RadioButton();
            this.musicLabel = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.musicPanel = new System.Windows.Forms.Panel();
            this.offButton = new System.Windows.Forms.RadioButton();
            this.onButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.clownBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zorroBox)).BeginInit();
            this.charPanel.SuspendLayout();
            this.musicPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::MazeProject.Properties.Resources.Back;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.Location = new System.Drawing.Point(264, 404);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(302, 67);
            this.exitButton.TabIndex = 3;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // charLabel
            // 
            this.charLabel.AutoSize = true;
            this.charLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charLabel.Location = new System.Drawing.Point(85, 225);
            this.charLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.charLabel.Name = "charLabel";
            this.charLabel.Size = new System.Drawing.Size(221, 29);
            this.charLabel.TabIndex = 4;
            this.charLabel.Text = "Character Select: ";
            // 
            // clownBox
            // 
            this.clownBox.Image = global::MazeProject.Properties.Resources.ClownFront;
            this.clownBox.Location = new System.Drawing.Point(318, 262);
            this.clownBox.Margin = new System.Windows.Forms.Padding(4);
            this.clownBox.Name = "clownBox";
            this.clownBox.Size = new System.Drawing.Size(40, 40);
            this.clownBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clownBox.TabIndex = 5;
            this.clownBox.TabStop = false;
            // 
            // zorroBox
            // 
            this.zorroBox.Image = global::MazeProject.Properties.Resources.ZorroFront;
            this.zorroBox.Location = new System.Drawing.Point(470, 258);
            this.zorroBox.Margin = new System.Windows.Forms.Padding(4);
            this.zorroBox.Name = "zorroBox";
            this.zorroBox.Size = new System.Drawing.Size(40, 40);
            this.zorroBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zorroBox.TabIndex = 6;
            this.zorroBox.TabStop = false;
            // 
            // charPanel
            // 
            this.charPanel.Controls.Add(this.zorroButton);
            this.charPanel.Controls.Add(this.clownButton);
            this.charPanel.Location = new System.Drawing.Point(316, 225);
            this.charPanel.Margin = new System.Windows.Forms.Padding(4);
            this.charPanel.Name = "charPanel";
            this.charPanel.Size = new System.Drawing.Size(439, 29);
            this.charPanel.TabIndex = 7;
            // 
            // zorroButton
            // 
            this.zorroButton.AutoSize = true;
            this.zorroButton.Location = new System.Drawing.Point(153, 4);
            this.zorroButton.Margin = new System.Windows.Forms.Padding(4);
            this.zorroButton.Name = "zorroButton";
            this.zorroButton.Size = new System.Drawing.Size(64, 21);
            this.zorroButton.TabIndex = 3;
            this.zorroButton.Text = "Zorro";
            this.zorroButton.UseVisualStyleBackColor = true;
            // 
            // clownButton
            // 
            this.clownButton.AutoSize = true;
            this.clownButton.Location = new System.Drawing.Point(7, 4);
            this.clownButton.Margin = new System.Windows.Forms.Padding(4);
            this.clownButton.Name = "clownButton";
            this.clownButton.Size = new System.Drawing.Size(66, 21);
            this.clownButton.TabIndex = 2;
            this.clownButton.Text = "Clown";
            this.clownButton.UseVisualStyleBackColor = true;
            // 
            // musicLabel
            // 
            this.musicLabel.AutoSize = true;
            this.musicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicLabel.Location = new System.Drawing.Point(211, 150);
            this.musicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.musicLabel.Name = "musicLabel";
            this.musicLabel.Size = new System.Drawing.Size(95, 29);
            this.musicLabel.TabIndex = 8;
            this.musicLabel.Text = "Music: ";
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsLabel.Location = new System.Drawing.Point(337, 72);
            this.optionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(154, 42);
            this.optionsLabel.TabIndex = 9;
            this.optionsLabel.Text = "Options";
            // 
            // musicPanel
            // 
            this.musicPanel.Controls.Add(this.offButton);
            this.musicPanel.Controls.Add(this.onButton);
            this.musicPanel.Location = new System.Drawing.Point(316, 150);
            this.musicPanel.Margin = new System.Windows.Forms.Padding(4);
            this.musicPanel.Name = "musicPanel";
            this.musicPanel.Size = new System.Drawing.Size(207, 36);
            this.musicPanel.TabIndex = 8;
            // 
            // offButton
            // 
            this.offButton.AutoSize = true;
            this.offButton.Location = new System.Drawing.Point(153, 6);
            this.offButton.Margin = new System.Windows.Forms.Padding(4);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(48, 21);
            this.offButton.TabIndex = 1;
            this.offButton.Text = "Off";
            this.offButton.UseVisualStyleBackColor = true;
            this.offButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // onButton
            // 
            this.onButton.AutoSize = true;
            this.onButton.Location = new System.Drawing.Point(7, 5);
            this.onButton.Margin = new System.Windows.Forms.Padding(4);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(48, 21);
            this.onButton.TabIndex = 0;
            this.onButton.Text = "On";
            this.onButton.UseVisualStyleBackColor = true;
            this.onButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::MazeProject.Properties.Resources.Border;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 549);
            this.Controls.Add(this.musicPanel);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.musicLabel);
            this.Controls.Add(this.charPanel);
            this.Controls.Add(this.zorroBox);
            this.Controls.Add(this.clownBox);
            this.Controls.Add(this.charLabel);
            this.Controls.Add(this.exitButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.clownBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zorroBox)).EndInit();
            this.charPanel.ResumeLayout(false);
            this.charPanel.PerformLayout();
            this.musicPanel.ResumeLayout(false);
            this.musicPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label charLabel;
        private System.Windows.Forms.PictureBox clownBox;
        private System.Windows.Forms.PictureBox zorroBox;
        private System.Windows.Forms.Panel charPanel;
        private System.Windows.Forms.Label musicLabel;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Panel musicPanel;
        private System.Windows.Forms.RadioButton offButton;
        private System.Windows.Forms.RadioButton zorroButton;
        private System.Windows.Forms.RadioButton onButton;
        private System.Windows.Forms.RadioButton clownButton;
    }
}