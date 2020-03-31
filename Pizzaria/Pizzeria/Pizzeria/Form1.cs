using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Total = 0;
            double Antal;

            if (radioButton1.Checked == true)
            {
                Total += 65;
            }

            if (radioButton2.Checked == true)
            {
                Total += 75;
            }

            if (radioButton3.Checked == true)
            {
                Total += 65;
            }

            if (Large.Checked == true)
            {
                Total += Total + 65;
            }

            //Ingredienser for make self Pizza.

            //if

            //Operations.

            Antal = Convert.ToDouble(nrAntal.Value);
            Total = Convert.ToDouble(nrAntal.Value) * Total;

            //Imprestion.

            txtTotal.Text = Total.ToString("c2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            nrAntal.Value = 1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            Large.Checked = false;
        }

    }
}
