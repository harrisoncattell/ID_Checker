using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID_Check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Current_Date_Label.Text = DateTime.Now.ToShortDateString();
            
        }

        private void btn_Number_1_Click(object sender, EventArgs e)
        {

            if (txtDoB.TextLength < 8)
            {

                txtDoB.Text = txtDoB.Text + "1";

            }

        }

        private void btn_Number_2_Click(object sender, EventArgs e)
        {

            if (txtDoB.TextLength < 8)
            {

                txtDoB.Text = txtDoB.Text + "2";

            }

        }

        private void btn_Number_3_Click(object sender, EventArgs e)
        {

            if (txtDoB.TextLength < 8)
            {

                txtDoB.Text = txtDoB.Text + "3";

            }

        }

        private void btn_Number_4_Click(object sender, EventArgs e)
        {

            if (txtDoB.TextLength < 8)
            {

                txtDoB.Text = txtDoB.Text + "4";

            }

        }

        private void btn_Number_5_Click(object sender, EventArgs e)
        {

            if (txtDoB.TextLength < 8)
            {

                txtDoB.Text = txtDoB.Text + "5";

            }

        }

        private void btn_Number_6_Click(object sender, EventArgs e)
        {

           if (txtDoB.TextLength < 8)
            {

                txtDoB.Text = txtDoB.Text + "6";

            }

        }

        private void btn_Number_7_Click(object sender, EventArgs e)
        {

            if (txtDoB.TextLength < 8)
            {

                txtDoB.Text = txtDoB.Text + "7";

            }

        }

        private void btn_Number_8_Click(object sender, EventArgs e)
        {

            if (txtDoB.TextLength < 8)
            {

                txtDoB.Text = txtDoB.Text + "8";

            }

        }

        private void btn_Number_9_Click(object sender, EventArgs e)
        {

            if (txtDoB.TextLength < 8)
            {

                txtDoB.Text = txtDoB.Text + "9";

            }

        }

        private void btn_Number_0_Click(object sender, EventArgs e)
        {

            if (txtDoB.TextLength < 8)
            {

                txtDoB.Text = txtDoB.Text + "0";

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtDoB.TextLength > 0)
            {

                txtDoB.Text = txtDoB.Text.Substring(0, txtDoB.TextLength - 1);

            }
             
        }

        private 
    }
}
