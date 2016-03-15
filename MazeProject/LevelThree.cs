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
    public partial class LevelThree : Form
    {
        // creates instance of LevelThree
        private static readonly LevelThree LvLThree = new LevelThree();
        // let's other forms use LevelThree instance
        public static LevelThree LevelThreeInstance
        {
            get { return LvLThree; }
        }

        public LevelThree()
        {
            InitializeComponent();
            this.Controls.Add(charLabel);
            // KeyDown event handler
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        // let's other forms access this label image
        public Image charImage
        {
            get { return charLabel.Image; }
            set { charLabel.Image = value; }
        }

        // let's other forms access box image
        public Boolean blockVisible
        {
            get { return block.Visible; }
            set { block.Visible = value; }
        }
        // let's other forms access this label
        public Label characterLabel
        {
            get { return charLabel; }
            set { charLabel = value; }
        }

        // let's other forms access this label location
        public Point charLabelPoint
        {
            get { return charLabel.Location; }
            set { charLabel.Location = value; }
        }

        // let's other forms access box1 location
        public Point box1Point
        {
            get { return box1.Location; }
            set { box1.Location = value; }
        }

        // let's other forms access box2 location
        public Point box2Point
        {
            get { return box2.Location; }
            set { box2.Location = value; }
        }

        // let's other forms access box3 location
        public Point box3Point
        {
            get { return box3.Location; }
            set { box3.Location = value; }
        }

        public Point box4Point
        {
            get { return box4.Location; }
            set { box4.Location = value; }
        }

        // let's other forms access block location
        public Point blockPoint
        {
            get { return block.Location; }
            set { block.Location = value; }
        }


        // method for Stay()
        private void Stay()
        {
            // character label doesn't move
            charLabel.Location = new Point(charLabel.Location.X, charLabel.Location.Y);
        }

        // method for charSelect
        private void charSelect()
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

        // method for resetlocation
        private void resetLocation()
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
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            charLabel.BringToFront();
            CheckComplete();
            // left arrow key
            if (e.KeyData == Keys.Left)
            {
                LeftKey();
                if (Options.OptionsInstance.clownIsChecked == true)
                {
                    charLabel.Image = Properties.Resources.ClownLeft;
                }
                if (Options.OptionsInstance.zorroIsChecked == true)
                {
                    charLabel.Image = Properties.Resources.ZorroLeft;
                }
            }
            // right arrow key
            if (e.KeyData == Keys.Right)
            {
                RightKey();
                if (Options.OptionsInstance.clownIsChecked == true)
                {
                    charLabel.Image = Properties.Resources.ClownRight;
                }
                if (Options.OptionsInstance.zorroIsChecked == true)
                {
                    charLabel.Image = Properties.Resources.ZorroRight;
                }
            }
            // up arrow key
            if (e.KeyData == Keys.Up)
            {
                UpKey();
                if (Options.OptionsInstance.clownIsChecked == true)
                {
                    charLabel.Image = Properties.Resources.ClownBack;
                }
                if (Options.OptionsInstance.zorroIsChecked == true)
                {
                    charLabel.Image = Properties.Resources.ZorroBack;
                }
            }
            // down arrow key
            if (e.KeyData == Keys.Down)
            {
                DownKey();
                if (Options.OptionsInstance.clownIsChecked == true)
                {
                    charLabel.Image = Properties.Resources.ClownFront;
                }
                if (Options.OptionsInstance.zorroIsChecked == true)
                {
                    charLabel.Image = Properties.Resources.ZorroFront;
                }
            }
        }
        // int variables
        public int i, x, z, index;


        // creates picturebox array
        PictureBox[] wall = new PictureBox[45];

        // method for PicArray()
        private void PicArray()
        {
            // assigns values for wall array
            wall[0] = pictureBox1;
            wall[1] = block;
            wall[2] = pictureBox3;
            wall[3] = pictureBox4;
            wall[4] = pictureBox5;
            wall[5] = pictureBox6;
            wall[6] = pictureBox7;
            wall[7] = pictureBox8;
            wall[8] = pictureBox9;
            wall[9] = pictureBox10;
            wall[10] = pictureBox11;
            wall[11] = pictureBox12;
            wall[12] = pictureBox13;
            wall[13] = pictureBox14;
            wall[14] = pictureBox15;
            wall[15] = pictureBox16;
            wall[16] = pictureBox17;
            wall[17] = pictureBox18;
            wall[18] = pictureBox19;
            wall[19] = pictureBox20;
            wall[20] = pictureBox21;
            wall[21] = pictureBox22;
            wall[22] = pictureBox23;
            wall[23] = pictureBox24;
            wall[24] = pictureBox25;
            wall[25] = pictureBox26;
            wall[26] = pictureBox27;
            wall[27] = pictureBox28;
            wall[28] = pictureBox29;
            wall[29] = pictureBox30;
            wall[30] = pictureBox31;
            wall[31] = pictureBox32;
            wall[32] = pictureBox33;
            wall[33] = pictureBox34;
            wall[34] = pictureBox35;
            wall[35] = pictureBox36;
            wall[36] = pictureBox37;
            wall[37] = pictureBox38;
            wall[38] = pictureBox39;
            wall[39] = pictureBox40;
            wall[40] = pictureBox41;
            wall[41] = box1;
            wall[42] = box2;
            wall[43] = box3;
            wall[44] = box4;
        }

        // method for LeftKey()
        private void LeftKey()
        {
            for (i = 0; i <= 40; i++)
            {
                // if picturebox detected, breaks method
                if (charLabel.Location.X - 40 == wall[i].Location.X && charLabel.Location.Y == wall[i].Location.Y)
                {
                    Stay();
                    break;
                }

                // character goes left
                else if (i == 40)
                {
                    BoxLeft();
                }
            }
        }

        // method for RightKey()
        private void RightKey()
        {
            for (i = 0; i <= 40; i++)
            {
                // if picturebox detected, breaks method
                if (charLabel.Location.X + 40 == wall[i].Location.X && charLabel.Location.Y == wall[i].Location.Y)
                {
                    Stay();
                    break;
                }

                // if character reaches finish flag, messagebox shows up
                else if (charLabel.Location.X + 40 == finishBox.Location.X && charLabel.Location.Y == finishBox.Location.Y)
                {
                    charLabel.SendToBack();
                    charLabel.Location = new Point(charLabel.Location.X + 40, charLabel.Location.Y);
                    MessageBox.Show("Congratulations!");
                    charSelect();
                    resetLocation();
                    this.Hide();
                    LevelFour.LevelFourInstance.Show();
                }
                // character goes right
                else if (i == 40)
                {
                    BoxRight();
                }
            }
        }

        // method for UpKey()
        private void UpKey()
        {
            for (i = 0; i <= 40; i++)
            {
                // if picturebox detected, breaks method
                if (charLabel.Location.X == wall[i].Location.X && charLabel.Location.Y - 40 == wall[i].Location.Y)
                {
                    Stay();
                    break;
                }

                // character goes up
                else if (i == 40)
                {
                    BoxUp();
                }
            }
        }

        // method for DownKey()
        private void DownKey()
        {
            for (i = 0; i <= 40; i++)
            {

                // if picturebox detected, breaks method
                if (charLabel.Location.X == wall[i].Location.X && charLabel.Location.Y + 40 == wall[i].Location.Y)
                {
                    Stay();
                    break;
                }


                // character goes down
                else if (i == 40)
                {
                    BoxDown();
                }
            }
        }

        // creates picture box array
        PictureBox[] box = new PictureBox[4];
        PictureBox[] dot = new PictureBox[4];

        // method for PicArray2
        private void PicArray2()
        {
            box[0] = box1;
            box[1] = box2;
            box[2] = box3;
            box[3] = box4;
        }

        // method for PicArray3
        private void PicArray3()
        {
            dot[0] = dot1;
            dot[1] = dot2;
            dot[2] = dot3;
            dot[3] = dot4;
        }

        // method for BoxLeft
        private void BoxLeft()
        {
            for (x = 0; x <= 3; x++)
            {
                // if character detects box on its left
                if (charLabel.Location.Y == box[x].Location.Y && charLabel.Location.X - 40 == box[x].Location.X)
                {
                    for (z = 0; z <= 44; z++)
                    {
                        // if box detects wall on its left, breaks loop
                        if (box[x].Location.Y == wall[z].Location.Y && box[x].Location.X - 40 == wall[z].Location.X)
                        {
                            Stay();
                            break;
                        }
                        // if no wall is detected on box's left, character and box moves left
                        else if (z == 44)
                        {
                            charLabel.Location = new Point(charLabel.Location.X - 40, charLabel.Location.Y);
                            box[x].Location = new Point(box[x].Location.X - 40, box[x].Location.Y);
                            break;
                        }
                    }
                    //key
                    break;
                }
                // if no box is on character's left, character moves left
                else if (x == 3)
                {
                    charLabel.Location = new Point(charLabel.Location.X - 40, charLabel.Location.Y);
                    break;
                }
            }
        }
        // method for BoxRight
        private void BoxRight()
        {
            for (x = 0; x <= 3; x++)
            {
                // if character detects box on its right
                if (charLabel.Location.Y == box[x].Location.Y && charLabel.Location.X + 40 == box[x].Location.X)
                {
                    for (z = 0; z <= 44; z++)
                    {
                        // if box detects wall on its right, breaks loop
                        if (box[x].Location.Y == wall[z].Location.Y && box[x].Location.X + 40 == wall[z].Location.X)
                        {
                            Stay();
                            break;
                        }
                        // if no wall is detected on box's right, character and box moves right
                        else if (z == 44)
                        {
                            charLabel.Location = new Point(charLabel.Location.X + 40, charLabel.Location.Y);
                            box[x].Location = new Point(box[x].Location.X + 40, box[x].Location.Y);
                            break;
                        }
                    }
                    //key
                    break;
                }
                // if no box is on character's right, character moves right
                else if (x == 3)
                {
                    charLabel.Location = new Point(charLabel.Location.X + 40, charLabel.Location.Y);
                    break;
                }
            }
        }

        // method for BoxUp
        private void BoxUp()
        {
            for (x = 0; x <= 3; x++)
            {
                // if character detects box above
                if (charLabel.Location.Y - 40 == box[x].Location.Y && charLabel.Location.X == box[x].Location.X)
                {
                    for (z = 0; z <= 44; z++)
                    {
                        // if box detects wall above, breaks loop
                        if (box[x].Location.Y - 40 == wall[z].Location.Y && box[x].Location.X == wall[z].Location.X)
                        {
                            Stay();
                            break;
                        }
                        // if no wall is detected above box, character and box moves up
                        else if (z == 44)
                        {
                            charLabel.Location = new Point(charLabel.Location.X, charLabel.Location.Y - 40);
                            box[x].Location = new Point(box[x].Location.X, box[x].Location.Y - 40);
                            break;
                        }
                    }
                    //key
                    break;
                }
                // if no box is above character, character moves up
                else if (x == 3)
                {
                    charLabel.Location = new Point(charLabel.Location.X, charLabel.Location.Y - 40);
                    break;
                }
            }
        }

        // method for BoxDown
        private void BoxDown()
        {
            for (x = 0; x <= 3; x++)
            {
                // if character detects box underneath
                if (charLabel.Location.Y + 40 == box[x].Location.Y && charLabel.Location.X == box[x].Location.X)
                {
                    for (z = 0; z <= 44; z++)
                    {
                        // if box detects wall underneath, breaks loop
                        if (box[x].Location.Y + 40 == wall[z].Location.Y && box[x].Location.X == wall[z].Location.X)
                        {
                            Stay();
                            break;
                        }
                        // if no wall is detected underneath box, character and box moves down
                        else if (z == 44)
                        {
                            charLabel.Location = new Point(charLabel.Location.X, charLabel.Location.Y + 40);
                            box[x].Location = new Point(box[x].Location.X, box[x].Location.Y + 40);
                            break;
                        }
                    }
                    //key
                    break;
                }
                // if no box is underneath character, character moves down
                else if (x == 3)
                {
                    charLabel.Location = new Point(charLabel.Location.X, charLabel.Location.Y + 40);
                    break;
                }
            }
        }


        // method for CheckComplete
        private void CheckComplete()
        {
            for (index = 0; index <= 3; index++)
            {
                if (box[index].Location == dot1.Location)
                {

                    for (index = 0; index <= 3; index++)
                    {
                        if (box[index].Location == dot2.Location)
                        {

                            for (index = 0; index <= 3; index++)
                            {
                                if (box[index].Location == dot3.Location)
                                {
                                    for (index = 0; index <= 3; index++)
                                    {
                                        if (box[index].Location == dot4.Location)
                                        {
                                            block.Location = new Point(block.Location.X + 40, block.Location.Y);
                                            block.Visible = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        // method for reset
        private void reset()
        {
            // resets location of all movable objects
            charLabel.Location = new Point(100, 220);
            box1.Location = new Point(300, 220);
            box2.Location = new Point(100, 180);
            box3.Location = new Point(260, 260);
            box4.Location = new Point(180, 220);
            block.Visible = true;
            block.Location = new Point(260, 340);
        }

        private void LevelThree_Load_1(object sender, EventArgs e)
        {
            PicArray();
            PicArray2();
            PicArray3();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // uses reset method
            reset();
        }

        // hides this form and shows levelselect form
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LevelSelect.LevelSelectInstance.Show();
        }

        private void LevelThree_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {

        }
    }
}

