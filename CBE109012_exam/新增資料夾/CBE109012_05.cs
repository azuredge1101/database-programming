using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (checkBox1.Checked)
                total += 0;
            if (checkBox2.Checked)
                total += 2;
            if (checkBox3.Checked)
                total -= 5;
            label2.Text = total.ToString("C");
            if (radioButton4.Checked)
            {
                total += 25;
                label2.Text = "小杯";
            }
            else
            {
                total += 35;
                label2.Text = "大杯";
            }
            if (radioButton1.Checked == true)
            {
                label2.Text = "紅茶";
            }
            else if (radioButton2.Checked == true)
            {
                label2.Text = "綠茶";
            }
            else
            {
                label2.Text = "奶茶";
            }


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           

        }
    }
}
