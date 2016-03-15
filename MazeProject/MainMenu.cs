using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace MazeProject
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Options.OptionsInstance.onButtonIsChecked = true;
            Options.OptionsInstance.offButtonIsChecked = true;
            Options.OptionsInstance.onButtonIsChecked = true;
            Options.OptionsInstance.clownIsChecked = true;
        }
        // closes window
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // creates new options object


        private void optionsButton_Click(object sender, EventArgs e)
        {
            // declares this form as owner
            Options.OptionsInstance.Owner = this;
            // shows option form
            Options.OptionsInstance.Show();
            // hides main menu form
            this.Hide();
        }


        private void playButton_Click(object sender, EventArgs e)
        {
            // declares this form as owner
            LevelSelect.LevelSelectInstance.Owner = this;
            // shows LevelSelect form
            LevelSelect.LevelSelectInstance.Show();
            // hides main menu form
            this.Hide();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
