using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Created by Ray Ketcham
//Date: 7/5/2018
//Class: CST-117

namespace TemperatureConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double C;
            double F;

            C = double.Parse(finput1.Text);
            F = (C * 2) + 30;

            label3.Text = F.ToString(label3.Text);
        }

        private void exit1_Click(object sender, EventArgs e)
        {
         //Closes the application
         this.Close();
         }

        private void clear1_Click(object sender, EventArgs e)
        {
            finput1.Text = "";
            label3.Text = "";
            cinput1.Text = "";
            label4.Text = "";
         }
        //
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            double C;
            double F;

            F = double.Parse(finput1.Text);
            C = 5.0 / 9.0 * (F - 32);

            label4.Text = C.ToString(label4.Text);
         

        }
    }
}
