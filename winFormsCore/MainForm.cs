using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFormsCore
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            button2.Text = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
        }



        int speedX = 2;
        int speedY = 2;

        Random ran = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            button2.Left += speedX;
            button2.Top += speedY;

            if (button2.Right >= ClientRectangle.Right || button2.Left <= 0)
            {
                speedX *= -1;
                Task.Run(() => Console.Beep());

                button2.BackColor = Color.FromArgb(ran.Next(255), ran.Next(255), ran.Next(255));
                BackColor = Color.FromArgb(ran.Next(255), ran.Next(255), ran.Next(255));
            }



            if (button2.Bottom >= ClientRectangle.Bottom || button2.Top <= 0)
            {
                speedY *= -1;
                Task.Run(() => Console.Beep());
                button2.BackColor = Color.FromArgb(ran.Next(255), ran.Next(255), ran.Next(255));
                BackColor = Color.FromArgb(ran.Next(255), ran.Next(255), ran.Next(255));
            }

        }
    }
}
