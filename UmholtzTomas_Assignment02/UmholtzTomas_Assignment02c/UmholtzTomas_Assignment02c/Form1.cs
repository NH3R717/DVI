using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UmholtzTomas_Assignment02c
{
    public partial class Form1 : Form
    {
        int ImageClicked = 0;
        int FirstClick = 0;
        int LionImageUsedCount = 0;
        int TigerImageUsedCount = 0;
        string AvailableCombination = "1-2-3,4-5-6,7-8-9,1-4-7,2-5-8,3-6-9,1-5-9,3-5-7";
        StringBuilder LionCombination = new StringBuilder();
        StringBuilder TigerCombination = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Creating circle around Lion on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picLion_Click(object sender, EventArgs e)
        {
            ImageClicked = 1;
            if (FirstClick == 0)
            {
                Pen myPen = new Pen(Color.FromArgb(255, 128, 0));
                myPen.Width = 2;
                Graphics formGraphics = this.CreateGraphics();
                formGraphics.DrawEllipse(myPen, new Rectangle(275, 540, 110, 110));
                myPen.Dispose();
                formGraphics.Dispose();
                FirstClick = 1;
            }
        }
        /// <summary>
        /// Creating circle around Tiger on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picTiger_Click(object sender, EventArgs e)
        {
            ImageClicked = 2;
            if (FirstClick == 0)
            {
                Pen myPen = new Pen(Color.FromArgb(255, 128, 0));
                myPen.Width = 2;
                Graphics formGraphics = this.CreateGraphics();
                formGraphics.DrawEllipse(myPen, new Rectangle(400, 540, 110, 110));
                myPen.Dispose();
                formGraphics.Dispose();
                FirstClick = 1;
            }
        }
        /// <summary>
        /// Resetting controls to their default state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            pic1.Image = null;
            pic2.Image = null;
            pic3.Image = null;
            pic4.Image = null;
            pic5.Image = null;
            pic6.Image = null;
            pic7.Image = null;
            pic8.Image = null;
            pic9.Image = null;
            pic1.Enabled = true;
            pic2.Enabled = true;
            pic3.Enabled = true;
            pic4.Enabled = true;
            pic5.Enabled = true;
            pic6.Enabled = true;
            pic7.Enabled = true;
            pic8.Enabled = true;
            pic9.Enabled = true;
            picTiger.Enabled = true;
            picLion.Enabled = true;
            ImageClicked = 0;
            FirstClick = 0;
            LionImageUsedCount = 0;
            TigerImageUsedCount = 0;
            LionCombination.Clear();
            TigerCombination.Clear();
            lblwin.Visible = false;
        }
        /// <summary>
        /// allotting images to boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pic_Click(object sender, EventArgs e)
        {
            if (ImageClicked == 1)
            {
                if (LionImageUsedCount < 1)
                {
                    ImageClicked = 1;
                    if (sender == pic1)
                    {
                        pic1.Image = picLion.Image;
                        pic1.Enabled = false;
                        LionImageUsedCount = 1;
                        TigerImageUsedCount = 0;
                        LionCombination.Append("1");
                    }
                    else if (sender == pic2)
                    {
                        pic2.Image = picLion.Image;
                        pic2.Enabled = false;
                        LionImageUsedCount = 1;
                        TigerImageUsedCount = 0;
                        LionCombination.Append("2");
                    }
                    else if (sender == pic3)
                    {
                        pic3.Image = picLion.Image;
                        pic3.Enabled = false;
                        LionImageUsedCount = 1;
                        TigerImageUsedCount = 0;
                        LionCombination.Append("3");
                    }
                    else if (sender == pic4)
                    {
                        pic4.Image = picLion.Image;
                        pic4.Enabled = false;
                        LionImageUsedCount = 1;
                        TigerImageUsedCount = 0;
                        LionCombination.Append("4");
                    }
                    else if (sender == pic5)
                    {
                        pic5.Image = picLion.Image;
                        pic5.Enabled = false;
                        LionImageUsedCount = 1;
                        TigerImageUsedCount = 0;
                        LionCombination.Append("5");
                    }
                    else if (sender == pic6)
                    {
                        pic6.Image = picLion.Image;
                        pic6.Enabled = false;
                        LionImageUsedCount = 1;
                        TigerImageUsedCount = 0;
                        LionCombination.Append("6");
                    }
                    else if (sender == pic7)
                    {
                        pic7.Image = picLion.Image;
                        pic7.Enabled = false;
                        LionImageUsedCount = 1;
                        TigerImageUsedCount = 0;
                        LionCombination.Append("7");
                    }
                    else if (sender == pic8)
                    {
                        pic8.Image = picLion.Image;
                        pic8.Enabled = false;
                        LionImageUsedCount = 1;
                        TigerImageUsedCount = 0;
                        LionCombination.Append("8");
                    }
                    else if (sender == pic9)
                    {
                        pic9.Image = picLion.Image;
                        pic9.Enabled = false;
                        LionImageUsedCount = 1;
                        TigerImageUsedCount = 0;
                        LionCombination.Append("9");
                    }
                    CheckCombination(ImageClicked);
                }
                else
                {
                    ImageClicked = 2;
                    if (sender == pic1)
                    {
                        pic1.Image = picTiger.Image;
                        pic1.Enabled = false;
                        TigerImageUsedCount = 1;
                        LionImageUsedCount = 0;
                        TigerCombination.Append("1");
                    }
                    else if (sender == pic2)
                    {
                        pic2.Image = picTiger.Image;
                        pic2.Enabled = false;
                        TigerImageUsedCount = 1;
                        LionImageUsedCount = 0;
                        TigerCombination.Append("2");
                    }
                    else if (sender == pic3)
                    {
                        pic3.Image = picTiger.Image;
                        pic3.Enabled = false;
                        TigerImageUsedCount = 1;
                        LionImageUsedCount = 0;
                        TigerCombination.Append("3");
                    }
                    else if (sender == pic4)
                    {
                        pic4.Image = picTiger.Image;
                        pic4.Enabled = false;
                        TigerImageUsedCount = 1;
                        LionImageUsedCount = 0;
                        TigerCombination.Append("4");
                    }
                    else if (sender == pic5)
                    {
                        pic5.Image = picTiger.Image;
                        pic5.Enabled = false;
                        TigerImageUsedCount = 1;
                        LionImageUsedCount = 0;
                        TigerCombination.Append("5");
                    }
                    else if (sender == pic6)
                    {
                        pic6.Image = picTiger.Image;
                        pic6.Enabled = false;
                        TigerImageUsedCount = 1;
                        LionImageUsedCount = 0;
                        TigerCombination.Append("6");
                    }
                    else if (sender == pic7)
                    {
                        pic7.Image = picTiger.Image;
                        pic7.Enabled = false;
                        TigerImageUsedCount = 1;
                        LionImageUsedCount = 0;
                        TigerCombination.Append("7");
                    }
                    else if (sender == pic8)
                    {
                        pic8.Image = picTiger.Image;
                        pic8.Enabled = false;
                        TigerImageUsedCount = 1;
                        LionImageUsedCount = 0;
                        TigerCombination.Append("8");
                    }
                    else if (sender == pic9)
                    {
                        pic9.Image = picTiger.Image;
                        pic9.Enabled = false;
                        TigerImageUsedCount = 1;
                        LionImageUsedCount = 0;
                        TigerCombination.Append("9");
                    }
                    CheckCombination(ImageClicked);
                }
            }
            else if(ImageClicked==2)
            {
                if (TigerImageUsedCount < 1)
                {
                    ImageClicked = 2;
                    if (sender == pic1)
                    {
                        pic1.Image = picTiger.Image;
                        pic1.Enabled = false;
                        TigerImageUsedCount = 1;
                        LionImageUsedCount = 0;
                        TigerCombination.Append("1");
                    }
                    else if (sender == pic2)
                    {
                        pic2.Image = picTiger.Image;
                        pic2.Enabled = false;
                        TigerImageUsedCount = 1;
                        LionImageUsedCount = 0;
                        TigerCombination.Append("2");
                    }
                    else if (sender == pic3)
                    {
                        pic3.Image = picTiger.Image;
                        pic3.Enabled = false;
                        TigerImageUsedCount = 1;
                        LionImageUsedCount = 0;
                        TigerCombination.Append("3");
                    }
                    else if (sender == pic4)
                    {
                        pic4.Image = picTiger.Image;
                        pic4.Enabled = false;
                        TigerImageUsedCount = 1;
                        LionImageUsedCount = 0;
                        TigerCombination.Append("4");
                    }
                    else if (sender == pic5)
                    {
                        pic5.Image = picTiger.Image;
                        pic5.Enabled = false;
                        TigerImageUsedCount = 1;
                        LionImageUsedCount = 0;
                        TigerCombination.Append("5");
                    }
                    else if (sender == pic6)
                    {
                        pic6.Image = picTiger.Image;
                        pic6.Enabled = false;
                        TigerImageUsedCount = 1;
                        LionImageUsedCount = 0;
                        TigerCombination.Append("6");
                    }
                    else if (sender == pic7)
                    {
                        pic7.Image = picTiger.Image;
                        pic7.Enabled = false;
                        TigerImageUsedCount = 1;
                        LionImageUsedCount = 0;
                        TigerCombination.Append("7");
                    }
                    else if (sender == pic8)
                    {
                        pic8.Image = picTiger.Image;
                        pic8.Enabled = false;
                        TigerImageUsedCount = 1;
                        LionImageUsedCount = 0;
                        TigerCombination.Append("8");
                    }
                    else if (sender == pic9)
                    {
                        pic9.Image = picTiger.Image;
                        pic9.Enabled = false;
                        TigerImageUsedCount = 1;
                        LionImageUsedCount = 0;
                        TigerCombination.Append("9");
                    }
                    CheckCombination(ImageClicked);
                }
                else
                {
                    ImageClicked = 1;
                    if (sender == pic1)
                    {
                        pic1.Image = picLion.Image;
                        pic1.Enabled = false;
                        LionImageUsedCount = 1;
                        TigerImageUsedCount = 0;
                        LionCombination.Append("1");
                    }
                    else if (sender == pic2)
                    {
                        pic2.Image = picLion.Image;
                        pic2.Enabled = false;
                        LionImageUsedCount = 1;
                        TigerImageUsedCount = 0;
                        LionCombination.Append("2");
                    }
                    else if (sender == pic3)
                    {
                        pic3.Image = picLion.Image;
                        pic3.Enabled = false;
                        LionImageUsedCount = 1;
                        TigerImageUsedCount = 0;
                        LionCombination.Append("3");
                    }
                    else if (sender == pic4)
                    {
                        pic4.Image = picLion.Image;
                        pic4.Enabled = false;
                        LionImageUsedCount = 1;
                        TigerImageUsedCount = 0;
                        LionCombination.Append("4");
                    }
                    else if (sender == pic5)
                    {
                        pic5.Image = picLion.Image;
                        pic5.Enabled = false;
                        LionImageUsedCount = 1;
                        TigerImageUsedCount = 0;
                        LionCombination.Append("5");
                    }
                    else if (sender == pic6)
                    {
                        pic6.Image = picLion.Image;
                        pic6.Enabled = false;
                        LionImageUsedCount = 1;
                        TigerImageUsedCount = 0;
                        LionCombination.Append("6");
                    }
                    else if (sender == pic7)
                    {
                        pic7.Image = picLion.Image;
                        pic7.Enabled = false;
                        LionImageUsedCount = 1;
                        TigerImageUsedCount = 0;
                        LionCombination.Append("7");
                    }
                    else if (sender == pic8)
                    {
                        pic8.Image = picLion.Image;
                        pic8.Enabled = false;
                        LionImageUsedCount = 1;
                        TigerImageUsedCount = 0;
                        LionCombination.Append("8");
                    }
                    else if (sender == pic9)
                    {
                        pic9.Image = picLion.Image;
                        pic9.Enabled = false;
                        LionImageUsedCount = 1;
                        TigerImageUsedCount = 0;
                        LionCombination.Append("9");
                    }
                    CheckCombination(ImageClicked);
                }
            }
        }
        /// <summary>
        /// checking combination where images are placed to declare game
        /// </summary>
        /// <param name="imgClicked"></param>
        private void CheckCombination(int imgClicked)
        {
            string[] combinations = AvailableCombination.Split(',');
            for (int i = 0; i < combinations.Length; i++)
            {
                string[] comb = combinations[i].Split('-');
                if(imgClicked==1)
                {
                    if (LionCombination.ToString().Contains(comb[0]))
                        if (LionCombination.ToString().Contains(comb[1]))
                            if (LionCombination.ToString().Contains(comb[2]))
                            {
                                lblwin.Text = "*Lion is the winner of the game.";
                                FreezeAll();
                                lblwin.Visible = true;
                                return;
                            }
                }
                else
                {
                    if (TigerCombination.ToString().Contains(comb[0]))
                        if (TigerCombination.ToString().Contains(comb[1]))
                            if (TigerCombination.ToString().Contains(comb[2]))
                            {
                                lblwin.Text = "*Tiger is the winner of the game.";
                                FreezeAll();
                                lblwin.Visible = true;
                                return;
                            }
                }
            }
            
        }
        /// <summary>
        /// freezing all controls after declaring game
        /// </summary>
        private void FreezeAll()
        {
            pic1.Enabled = false;
            pic2.Enabled = false;
            pic3.Enabled = false;
            pic4.Enabled = false;
            pic5.Enabled = false;
            pic6.Enabled = false;
            pic7.Enabled = false;
            pic8.Enabled = false;
            pic9.Enabled = false;
            picTiger.Enabled = false;
            picLion.Enabled = false;
        }
    }
}
