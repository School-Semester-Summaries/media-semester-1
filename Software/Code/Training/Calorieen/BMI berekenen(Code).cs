using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorieen
{
    public partial class Form : System.Windows.Forms.Form
    {
        
        public Form()
        {
            InitializeComponent();
        }

        private void GB_geslacht_Enter(object sender, EventArgs e)
        {

        }
        private void RB_man_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void RB_vrouw_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void GB_levensstijl_Enter(object sender, EventArgs e)
        {

        }
        private void RB_actief_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void RB_nietActief_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void LBL_leeftijd_Click(object sender, EventArgs e)
        {

        }
        private void TB_leeftijd_TextChanged(object sender, EventArgs e)
        {

        }
        private void BTN_bereken_Click(object sender, EventArgs e)
        {
            int leeftijd = Convert.ToInt32(TB_leeftijd.Text); 
            int cal;

            /* ik wilde de calorieen berekenen door steeds + en - te doen, 
             * dan kun je bijna alles kopieren en plakken maar dat lukte me niet :/ */

            if (RB_man.Checked) 
            {
                if (RB_nee.Checked)
                {

                    if (RB_actief.Checked)
                    {
                        if (leeftijd > 50)
                        {
                            cal = 2300;
                            MessageBox.Show(cal + " Calorieën");
                        }
                        else if (leeftijd < 12)
                        {
                            cal = 2320;
                            MessageBox.Show(cal + " Calorieën");
                        }
                        else
                        {
                            cal = 2500;
                            MessageBox.Show(cal + " Calorieën");
                        }
                    }


                    if (RB_nietActief.Checked)
                    {
                        if (leeftijd > 50)
                        {
                            cal = 2050;
                            MessageBox.Show(cal + " Calorieën");
                        }
                        else if (leeftijd < 12)
                        {
                            cal = 2070;
                            MessageBox.Show(cal + " Calorieën");
                        }
                        else
                        {
                            cal = 2250;
                            MessageBox.Show(cal + " Calorieën");
                        }
                    }
                }
                             
            }

            if (RB_vrouw.Checked)
            {
                if (RB_ja.Checked) // zwanger
                {
                    if(leeftijd>30)
                    {
                        cal = 2500;
                        MessageBox.Show(cal + " Calorieën");
                    }

                    else if(leeftijd < 31 & leeftijd > 14)
                    {
                        cal = 2600;
                        MessageBox.Show(cal + " Calorieën");
                    }
                    else
                    {
                        MessageBox.Show("...");
                    }
                }
                if (RB_actief.Checked & RB_nee.Checked)
                {
                    if (leeftijd > 50)
                    {
                        cal = 1800;
                        MessageBox.Show(cal + " Calorieën");
                    }
                    else if (leeftijd < 12)
                    {
                        cal = 1820;
                        MessageBox.Show(cal + " Calorieën");
                    }
                    else
                    {
                        cal = 2000;
                        MessageBox.Show(cal + " Calorieën");
                    }
                }

                if (RB_nietActief.Checked & RB_nee.Checked)
                {
                    if (leeftijd > 50)
                    {
                        cal = 1600;
                        MessageBox.Show(cal + " Calorieën");
                    }
                    else if (leeftijd < 12)
                    {
                        cal = 1620;
                        MessageBox.Show(cal + " Calorieën");
                    }
                    else
                    {
                        cal = 1800;
                        MessageBox.Show(cal + " Calorieën");
                    }
                }

            }
        }
    }
}
