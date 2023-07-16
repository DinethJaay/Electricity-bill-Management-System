using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electricitybill2
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

        private void button2_Click(object sender, EventArgs e)
        {
            txtunits.Text = " ";
            txttotal.Text = " ";

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            string units=txtunits.Text;
            double charge = 0;
            

            double uni=Convert.ToDouble(txtunits.Text);
           

            if(cmbcustype.SelectedIndex == 0)
            {
                if(uni<=100)
                {
                    charge = 500 + 200;
                }
                else
                {
                    charge = 500 + 200 + (uni - 100) * 20;
                }
            }
            else if(cmbcustype.SelectedIndex == 1)
            {
                if(uni<=100)
                {
                    charge = 800 + 600;
                }
                else
                {
                    charge = 800 + 600 + (uni - 100) * 50;
                }
            }
            txttotal.Text = Convert.ToString(charge);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
