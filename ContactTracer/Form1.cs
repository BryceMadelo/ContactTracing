using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContactTracer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*private void btnSaveandSub_Click(object sender, EventArgs e)
        {
            StreamWriter file = File.AppendText(@"C:\Users\Bryce\ContactTracing\KonohaVisitors.txt");
            //Personal Information Section
            file.WriteLine("-----PERSONAL INFORMATION-----");
            file.WriteLine("Name: " + TxtboxName.Text);
            file.WriteLine("Address: " + TxtboxAdd.Text);
            if (RadiobtnMale.Checked)
            {
                file.WriteLine("Sex: " + RadiobtnMale.Text);
            }
            else
            {
                file.WriteLine("Sex: " + RadiobtnFemale.Text);
            }
            file.WriteLine("Age: " + TxtboxAge.Text);
            file.WriteLine("Date of Birth: " + TxtboxBday.Text);
            file.WriteLine("Nationality: " + TxtboxNat.Text);
            //Contact Information Section
            file.WriteLine("-----CONTACT INFORMATION-----");
            file.WriteLine("E-mail: " + TxtboxEmail.Text);
            file.WriteLine("Phone #: " + TxtboxPhnum.Text);
            file.WriteLine("Facebook Account: " + TxtboxFb.Text);
            file.WriteLine("Instagram Account: " + TxtboxInsta.Text);
            file.WriteLine("Name of Guardian: " + TxtboxGuarName.Text);
            file.WriteLine("Guardian's Phone #: " + TxtboxGuarPhnum.Text);
            //Health Information
            file.WriteLine("-----HEALTH INFORMATION-----");
            file.WriteLine("Have you been exepriencing the following symptoms in the past few days?");
            if (RadiobtnCoughYes.Checked)
            {
                file.WriteLine("Cough: " + RadiobtnCoughYes.Text);
            }
            else
            {
                file.WriteLine("Cough: " + RadiobtnCoughNo.Text);
            }
            if (RadiobtnFeverYes.Checked)
            {
                file.WriteLine("Fever: " + RadiobtnFeverYes.Text);
            }
            else
            {
                file.WriteLine("Fever: " + RadiobtnFeverNo.Text);
            }
            if (RadiobtnSoarThrtYes.Checked)
            {
                file.WriteLine("Soar Throat: " + RadiobtnSoarThrtYes.Text);
            }
            else
            {
                file.WriteLine("Soar Throat: " + RadiobtnSoarThrtNo.Text);
            }
            if (RadiobtnLossTasteYes.Checked)
            {
                file.WriteLine("Loss of taste or smell: " + RadiobtnLossTasteYes.Text);
            }
            else
            {
                file.WriteLine("Loss of taste or smell: " + RadiobtnLossTasteNo.Text);
            }
            if (RadiobtnRunNoseYes.Checked)
            {
                file.WriteLine("Runny Nose: " + RadiobtnRunNoseYes.Text);
            }
            else
            {
                file.WriteLine("Runny Nose: " + RadiobtnRunNoseNo.Text);
            }
            if (RadiobtnDiffBreathYes.Checked)
            {
                file.WriteLine("Difficulty breathing: " + RadiobtnDiffBreathYes.Text);
            }
            else
            {
                file.WriteLine("Diffculty breathing: " + RadiobtnDiffBreathNo.Text);
            }
            if (RadiobtnCovidContactYes.Checked)
            {
                file.WriteLine("Have you been in close contact with a Covid - 19 case?: " + RadiobtnCovidContactYes.Text);
            }
            else
            {
                file.WriteLine("Have you been in close contact with a Covid - 19 case?: " + RadiobtnCovidContactNo.Text);
            }
            if (RadiobtnTraveledYes.Checked)
            {
                file.WriteLine("Have you traveled outside the country in the last 14 days?: " + RadiobtnTraveledYes.Text);
            }
            else
            {
                file.WriteLine("Have you traveled outside the country in the last 14 days?: " + RadiobtnTraveledNo.Text);
            }
            if (RadiobtnFullyVaxYes.Checked)
            {
                file.WriteLine("Have you received vaccine doses?: " + RadiobtnFullyVaxYes.Text);
            }
            else
            {
                file.WriteLine("Have you received vaccine doses?: " + RadiobtnVaxNo.Text);
            }
            if (RadiobtnFullyVaxwithBoosterYes.Checked)
            {
                file.WriteLine("Have you received vaccine doses?: " + RadiobtnFullyVaxwithBoosterYes.Text);
            }
            file.Close();
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            Page2.Visible = false;
            Page3.Visible = false;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

       

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nxt1_Click(object sender, EventArgs e)
        {
            Page1.Visible = false;
            Page2.Visible = true;
        }

        private void Prev1_Click(object sender, EventArgs e)
        {
            Page1.Visible = true;
            Page2.Visible = false;
        }

        private void Nxt2_Click(object sender, EventArgs e)
        {
            Page1.Visible = false;
            Page2.Visible = false;
            Page3.Visible = true;
        }

        private void Prev2_Click(object sender, EventArgs e)
        {
            Page1.Visible = false;
            Page2.Visible = true;
            Page3.Visible = false;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
