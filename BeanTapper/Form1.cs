using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeanTapper
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight;
        int speed = 10;
        int score = 0;
        int level = 1;
        bool havBeans = false;
        int custCount = 0;
        int maxCust=2;
        List<PictureBox> pictureList = new List<PictureBox>();
        List<PictureBox> customerList = new List<PictureBox>();
        private string[] charImages = { "mikeyt", "50cent", "shaggyside", "snoopdog", "tupac" };
        Random rndm = new Random();
        public Form1()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            charTimer.Tick += (s, e) =>
            {
                if (custCount < maxCust)
                {
                    generateCustomers();
                    custCount++;
                }
                else
                {
                  //  charTimer.Stop();
                    level++;
                    maxCust++;
                    custCount = 0;
                }
            };
            charTimer.Start();
            generateCustomers();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {

            txtScore.Text = "Score: " + score;
            txtLevel.Text = "Level: " + level;

            for (int i = customerList.Count -1; i>=0; i--)
            {
                PictureBox customer = customerList[i];
                customer.Left += speed + 10;
                if (customer.Left+customer.Width > barTable.Width)
                {
                    customer.Dispose();
                    customerList.RemoveAt(i);
                    score -= 500;
                }
            }

            if (goLeft == true && Player.Left > Door.Left + Door.Width)
            {
                Player.Left -= 12;
                Player.Image = Properties.Resources.facingleft;
            }
            if (goRight == true && Player.Left + Player.Width < keg.Left)
            {
                Player.Left += 12;
                Player.Image = Properties.Resources.facingright;

            }
        }

        private void generateCustomers()
        {
            for (int i = 0; i < level +2; i++)
            {
                PictureBox customer = new PictureBox();
                customer.SizeMode = PictureBoxSizeMode.StretchImage;
                customer.Location = new Point(Door.Left, Door.Top);
                customer.Size = new Size(60, 156);
                customer.Image = Properties.Resources.ResourceManager.GetObject(charImages[rndm.Next(0,5)]) as Image;
                this.Controls.Add(customer);
                customer.BringToFront();
                customerList.Add(customer);
            }

        }



        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Enter && Player.Bounds.IntersectsWith(keg.Bounds))
            {
                Player.Image = Properties.Resources.facingrightbeans;
                beanReceive.Visible = true;
                havBeans = true;
            }
        }


        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Enter && havBeans == true)
            {
                beanReceive.Visible = false;
                Player.Image = Properties.Resources.facingleft;
                havBeans = false;
                PictureBox beanCan = new PictureBox();
                beanCan.SizeMode = PictureBoxSizeMode.StretchImage;
                beanCan.Location = new Point(Player.Left - 5, 305);
                beanCan.Size = new Size(41, 50);
                this.Controls.Add(beanCan);
                beanCan.BringToFront();
                beanCan.Image = Properties.Resources.beansz;
                pictureList.Add(beanCan);
                while (beanCan.Left + beanCan.Width > barTable.Left)
                {
                    score += 150;
                    foreach (PictureBox pictureBox in pictureList)
                    {
                        pictureBox.Left -= speed;
                    }
                    Application.DoEvents();
                    Thread.Sleep(1);

                }
            }
        }

    }
}
