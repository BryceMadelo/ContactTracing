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

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void btnSaveandSub_Click(object sender, EventArgs e)
        {
            StreamWriter file = File.AppendText(@"C:\Users\Bryce\ContactTracing\UpsideDownVisitors.txt");
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

            file.Close();
        }
    }
}
