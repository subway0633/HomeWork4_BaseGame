using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baseball
{
    public partial class Form1 : Form
    {
        private Ball ball;
        private Roles 裁判一號, 裁判二號, 球迷一號, 球迷二號;
        public List<Roles> Role;
        private Random ran;

        private int totalClick = 0;

        public Form1()
        {
            InitializeComponent();
            Role = new List<Roles>();
            ball = new Ball();
            ran = new Random();
            Role.Add(裁判一號 = new Roles(ball, "裁判一號", false));
            Role.Add(裁判二號 = new Roles(ball, "裁判二號", false));
            Role.Add(球迷一號 = new Roles(ball, "球迷一號", true));
            Role.Add(球迷二號 = new Roles(ball, "球迷二號", true));
        }

        private void btnPlayball_Click(object sender, EventArgs e)
        {
            totalClick++;
            bool isHitted = false;
            BallEventArgs ballEventArgs = new BallEventArgs()
            {
                Angle = double.Parse(txtAngle.Text),
                Distance = double.Parse(txtDistance.Text)
            };

            int randomNumber = ran.Next(1, 100);
            isHitted = (randomNumber >= 1 && randomNumber <= 100);

            if (totalClick <= 3)
            {
                txtResult.Text += string.Format("現在是第{0}次上場打擊\n", totalClick);
                if (isHitted)
                {
                    txtResult.Text += string.Format("打中了,仰角是{0},距離是{1}\n", ballEventArgs.Angle, ballEventArgs.Distance);
                    ball.OnBallInPlay(ballEventArgs);
                    foreach (var v in Role)
                    {
                        txtResult.Text += v.Name + "\n";
                        txtResult.Text += v.Message;
                    }
                }
                else
                {
                    txtResult.Text += string.Format("沒打中了,你還有{0}次機會\n", 3 - totalClick);
                }
            }
            else
            {
                MessageBox.Show("Gameover");
            }
        }

        private void btnBallFly_Click(object sender, EventArgs e)
        {
            txtAngle.Text = ran.Next(20, 60).ToString();
            txtDistance.Text = ran.Next(300, 500).ToString();
            totalClick = 0;
        }
    }
}