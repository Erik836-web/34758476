using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formmozg
{
    public partial class Form1 : Form
    {
        //osztályvátozók
        private int valtmagas=6, 
            valtszeleseg=10,
            maxwidth =0,
            maxheight =0,
            minwidth = 0,
            minheight = 0;

        private void btnfelul_Click(object sender, EventArgs e)
        {
            Location = new Point(Location.X,0);
        }

        public Form1()
        {
            InitializeComponent();
            maxwidth = Screen.GetWorkingArea(this).Width;
            maxheight = Screen.GetWorkingArea(this).Height;
            minwidth = Screen.GetWorkingArea(this).Width / 3;
            minheight = Screen.GetWorkingArea(this).Height / 3;
        }
        private void btncsok_Click(object sender, EventArgs e)
        {
            Width -= Width - valtszeleseg >= minwidth ? valtszeleseg : 0;
            Height -= Height - valtmagas >= minheight ? valtmagas : 0;
        }

        private void btnMeretno_Click(object sender, EventArgs e)
        {
            if ((Location.X + Height )<= maxheight)
            {
                Height += valtmagas;
            }
            if ((Location.Y + Width) <= maxwidth)
            {
                Width += valtszeleseg;
            }

        }
    }
}
