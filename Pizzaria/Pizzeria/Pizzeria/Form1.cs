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
    public partial class Panel : Form
    {

        List<System.Windows.Forms.Panel> listPanel = new List<System.Windows.Forms.Panel>();
        int index;

        public Panel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel[index].BringToFront();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Navn_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Main 3 Pizza's

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

            //Make self Pizza.

            if (radioButton4.Checked || radioButton5.Checked || radioButton6.Checked == true)
            {
                Total += 13.75;
            }

            if (radioButton7.Checked || radioButton8.Checked || radioButton9.Checked == true)
            {
                Total += 13.75;
            }

            if (radioButton10.Checked || radioButton11.Checked || radioButton12.Checked == true)
            {
                Total += 13.75;
            }

            if (radioButton13.Checked || radioButton14.Checked || radioButton15.Checked == true)
            {
                Total += 13.75;
            }

            for (double makeSelf = 0; makeSelf < 4;)
            {
                if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked || checkBox6.Checked || checkBox7.Checked || checkBox8.Checked || checkBox9.Checked || checkBox10.Checked)
                {
                    Total += 5;
                }
            }

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
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            Large.Checked = false;
        }
    }
}
