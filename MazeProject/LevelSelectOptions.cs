using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MazeProject
{
    public partial class LevelSelectOptions : Form
    {

        // creates instance of LevelSelectOptions
        private static readonly LevelSelectOptions LvLSelectOptions = new LevelSelectOptions();
        // let's other forms use LevelSelectOptions instance
        public static LevelSelectOptions LevelSelectOptionsInstance
        {
            get { return LvLSelectOptions; }
        }
        public LevelSelectOptions()
        {
            InitializeComponent();
        }

        // let's other lvlbuttonbutton status
        public Boolean lvltwo
        {
            get { return leveltwoButton.Enabled; }
            set { leveltwoButton.Enabled = value; }
        }

        // method for leveloneButton
        private void leveloneButton_Click(object sender, EventArgs e)
        {
            locationLvLOne();
            charSelectLvLOne();
            // shows level one form
            LevelOne.LevelOneInstance.Show();
            // hides this form
            this.Hide();
        }

        // method for leveltwoButton
        private void leveltwoButton_Click(object sender, EventArgs e)
        {
            locationLvLTwo();
            charSelectLvLTwo();
            // shows level two form
            LevelTwo.LevelTwoInstance.Show();
            // hides this form
            this.Hide();
        }
        // method for levelthreeButton
        private void levelthreeButton_Click(object sender, EventArgs e)
        {
            locationLvLThree();
            charSelectLvLThree();
            // shows level three form
            LevelThree.LevelThreeInstance.Show();
            // hides this form
            this.Hide();
        }

        // method for levelfourButton
        private void levelfourButton_Click(object sender, EventArgs e)
        {
            locationLvLFour();
            charSelectLvLFour();
            // shows level Four form
            LevelFour.LevelFourInstance.Show();
            // hides this form
            this.Hide();
        }

        // method for levelfiveButton
        private void levelfiveButton_Click(object sender, EventArgs e)
        {
            locationLvLFive();
            charSelectLvLFive();
            // shows level Five form
            LevelFive.LevelFiveInstance.Show();
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


        // method for charselectlvltwo
        private void charSelectLvLTwo()
        {
            // if character selected is clown
            if (Options.OptionsInstance.clownIsChecked == true)
            {
                LevelTwo.LevelTwoInstance.charImage = Properties.Resources.ClownFront;
            }
            // if character selected is zorro
            else if (Options.OptionsInstance.zorroIsChecked == true)
            {
                LevelTwo.LevelTwoInstance.charImage = Properties.Resources.ZorroFront;
            }
        }

        // method for locationLvLTwo
        private void locationLvLTwo()
        {
            // resets starting points of all movable objects
            LevelTwo.LevelTwoInstance.charLabelPoint = new Point(160, 160);
            LevelTwo.LevelTwoInstance.box1Point = new Point(120, 200);
            LevelTwo.LevelTwoInstance.box2Point = new Point(120, 240);
            LevelTwo.LevelTwoInstance.box3Point= new Point(160, 200);
            LevelTwo.LevelTwoInstance.blockVisible = true;
            LevelTwo.LevelTwoInstance.blockPoint = new Point(160, 120);
        }

        // hides this form and opens levelselect form
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LevelSelect.LevelSelectInstance.Show();
        }

        // method for charselectlvlthree
        private void charSelectLvLThree()
        {
            // if character selected is clown
            if (Options.OptionsInstance.clownIsChecked == true)
            {
                LevelThree.LevelThreeInstance.charImage = Properties.Resources.ClownFront;
            }
            // if character selected is zorro
            else if (Options.OptionsInstance.zorroIsChecked == true)
            {
                LevelThree.LevelThreeInstance.charImage = Properties.Resources.ZorroFront;
            }
        }

        // method for locationLvLThree
        private void locationLvLThree()
        {
            // resets starting points of all movable objects
            LevelThree.LevelThreeInstance.charLabelPoint = new Point(100, 220);
            LevelThree.LevelThreeInstance.box1Point = new Point(300, 220);
            LevelThree.LevelThreeInstance.box2Point = new Point(100, 180);
            LevelThree.LevelThreeInstance.box3Point = new Point(260, 260);
            LevelThree.LevelThreeInstance.box4Point = new Point(180, 220);
            LevelThree.LevelThreeInstance.blockVisible = true;
            LevelThree.LevelThreeInstance.blockPoint = new Point(260, 340);
        }

        // method for charselectlvlFour
        private void charSelectLvLFour()
        {
            // if character selected is clown
            if (Options.OptionsInstance.clownIsChecked == true)
            {
                LevelFour.LevelFourInstance.charImage = Properties.Resources.ClownFront;
            }
            // if character selected is zorro
            else if (Options.OptionsInstance.zorroIsChecked == true)
            {
                LevelFour.LevelFourInstance.charImage = Properties.Resources.ZorroFront;
            }
        }

        // method for locationLvLFour
        private void locationLvLFour()
        {
            // resets starting points of all movable objects
            LevelFour.LevelFourInstance.charLabelPoint = new Point(100, 150);
            LevelFour.LevelFourInstance.box1Point = new Point(180, 230);
            LevelFour.LevelFourInstance.box2Point = new Point(140, 150);
            LevelFour.LevelFourInstance.box3Point = new Point(140, 270);
            LevelFour.LevelFourInstance.box4Point = new Point(140, 190);
            LevelFour.LevelFourInstance.blockVisible = true;
            LevelFour.LevelFourInstance.blockPoint = new Point(220, 150);
        }

        // method for charselectlvlfive
        private void charSelectLvLFive()
        {
            // if character selected is clown
            if (Options.OptionsInstance.clownIsChecked == true)
            {
                LevelFive.LevelFiveInstance.charImage = Properties.Resources.ClownFront;
            }
            // if character selected is zorro
            else if (Options.OptionsInstance.zorroIsChecked == true)
            {
                LevelFive.LevelFiveInstance.charImage = Properties.Resources.ZorroFront;
            }
        }

        // method for locationLvLFive
        private void locationLvLFive()
        {
            // resets starting points of all movable objects
            LevelFive.LevelFiveInstance.charLabelPoint = new Point(150, 160);
            LevelFive.LevelFiveInstance.box1Point = new Point(270, 360);
            LevelFive.LevelFiveInstance.box2Point = new Point(150, 320);
            LevelFive.LevelFiveInstance.box3Point = new Point(190, 200);
            LevelFive.LevelFiveInstance.blockVisible = true;
            LevelFive.LevelFiveInstance.blockPoint = new Point(150, 120);
        }

        private void LevelSelectOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
