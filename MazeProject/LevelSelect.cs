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
    public partial class LevelSelect : Form
    {
        // creates instance of LevelSelect
        private static readonly LevelSelect LvLSelect = new LevelSelect();
        // let's other forms use LevelSelect instance
        public static LevelSelect LevelSelectInstance
        {
            get { return LvLSelect; }
        }
        public LevelSelect()
        {
            InitializeComponent();
        }
 
        private void backButton_Click(object sender, EventArgs e)
        {
            // shows Main Menu
            this.Owner.Show();
            // closes this form
            this.Hide();
        }
        
        private void newButton_Click(object sender, EventArgs e)
        {
            locationLvLOne();
            charSelectLvLOne();
            // declares this form as owner
            LevelOne.LevelOneInstance.Owner = this;
            // shows level one form
            LevelOne.LevelOneInstance.Show();
            // hides this form
            this.Hide();
        }

        // method for charselectlvlone
        private void charSelectLvLOne()
        {
            // if character selected is clown
            if (Options.OptionsInstance.clownIsChecked == true)
            {
                LevelOne.LevelOneInstance.charImage = Properties.Resources.ClownFront;
            }
            // if character selected is zorro
            else if (Options.OptionsInstance.zorroIsChecked == true)
            {
                LevelOne.LevelOneInstance.charImage = Properties.Resources.ZorroFront;
            }
        }

        // method for locationLvLOne
        private void locationLvLOne()
        {
            // resets starting points of all movable objects
            LevelOne.LevelOneInstance.charLabelPoint = new Point(190, 175);
            LevelOne.LevelOneInstance.box1Point = new Point(150, 175);
            LevelOne.LevelOneInstance.box2Point = new Point(230, 135);
            LevelOne.LevelOneInstance.box3Point = new Point(150, 135);
            LevelOne.LevelOneInstance.blockVisible = true;
            LevelOne.LevelOneInstance.blockPoint = new Point(230, 415);
        }

        private void levelButton_Click(object sender, EventArgs e)
        {
            // shows levelselectoptions form
            LevelSelectOptions.LevelSelectOptionsInstance.Show();
            // hides this form
            this.Hide();
        }
    }
}
