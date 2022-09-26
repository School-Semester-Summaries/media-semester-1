using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dobbelsteen
{
    public partial class Dobbelsteen : Form
    {
        public Dobbelsteen()
        {
            InitializeComponent();
        }

        private void Dobbelsteen_Load(object sender, EventArgs e)
        {

        }

        private void DS1_Click(object sender, EventArgs e)
        {

        }
        private void DS2_Click(object sender, EventArgs e)
        {

        }
        private void DS3_Click(object sender, EventArgs e)
        {

        }
        private void DS4_Click(object sender, EventArgs e)
        {

        }
        private void DS5_Click(object sender, EventArgs e)
        {

        }
        private void DS6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int roll = ran.Next(1, 7);
            MessageBox.Show(roll + "");
        }
    }
}

// het lukte me niet om de picturebox een afbeelding te laten displayen, ik ga verder met de volgende opdracht
