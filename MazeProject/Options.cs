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
    public partial class Options : Form
    {
        // creates instance of Options
        private static readonly Options Opt = new Options();
        // let's other forms use Options instance
        public static Options OptionsInstance
        {
            get { return Opt; }
        }

        public Options()
        {
            InitializeComponent();
            // declares new timer object
            Timer t = new Timer();
            // declares timer interval
            t.Interval = 1000;
            // declares timer eventhandler
            t.Tick += new EventHandler(t_Tick);
            // starts timer
            t.Start();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // shows Main Menu
            this.Owner.Show();
            // closes this form
            Options.OptionsInstance.Hide();
        }

        void t_Tick(object sender, EventArgs e)
        {
            // new image arrays
            Image[] c = new Image[4];
            Image[] z = new Image[4];

            if (counter <= 3)
            {
                // assigns images to image array
                c[0] = MazeProject.Properties.Resources.ClownLeft;
                c[1] = MazeProject.Properties.Resources.ClownBack;
                c[2] = MazeProject.Properties.Resources.ClownRight;
                c[3] = MazeProject.Properties.Resources.ClownFront;
                z[0] = MazeProject.Properties.Resources.ZorroLeft;
                z[1] = MazeProject.Properties.Resources.ZorroBack;
                z[2] = MazeProject.Properties.Resources.ZorroRight;
                z[3] = MazeProject.Properties.Resources.ZorroFront;
                // sets new image
                clownBox.Image = c[counter];
                zorroBox.Image = z[counter];
                // adds to counter
                counter++;
            }
            else
            {
                counter = 0;
            }

        }
        // int variable
        int counter = 0;
        // stops music
        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Track1);
            sp.Stop();
        }
        // plays music
        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Stream str = Properties.Resources.Track1;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
        }
        // let's other forms access onButton control
        public bool onButtonIsChecked
        {
            get { return onButton.Checked; }
            set { onButton.Checked = value; }
        }

        // let's other forms access offButton control
        public bool offButtonIsChecked
        {
            get { return offButton.Checked; }
            set { offButton.Checked = value; }
        }
        // let's other forms access clownButton control
        public bool clownIsChecked
        {
            get { return clownButton.Checked; }
            set { clownButton.Checked = value; }
        }
        
        // let's other forms access zorroButton control
        public bool zorroIsChecked
        {
            get { return zorroButton.Checked; }
            set { zorroButton.Checked = value; }
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
