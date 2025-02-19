using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahahahahahaahha
{
    public partial class Form1 : Form
    {
        private bool iranyFel = true;
        private bool iranyBalra = true;
        private int lepesFel = 30;
        private int lepesOldalt = 30;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Point point = button1.Location;

            if (iranyFel && (point.Y - lepesFel) <= 0)
            {
                iranyFel = false;
            }
            if (iranyBalra && (point.X - lepesOldalt) <= 0)
            {
                iranyBalra = false;
            }
            if (!iranyFel && ((point.Y + button1.Height) + lepesFel) >= Height)
            {
                iranyFel = true;
            }
            if (!iranyBalra && ((point.X + button1.Width) + lepesOldalt) >= Width)
            {
                iranyBalra = true;
            }

            point.X += iranyBalra ? -lepesOldalt : lepesOldalt;
            point.Y += iranyFel ? -lepesFel : lepesFel;
            button1.Location = point;
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.AntiqueWhite;
            button1.Text = "Kattints rám!";
        }
    }
}
