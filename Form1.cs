using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculated
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double a, b, answer;

        private void btnPlus_Click(object sender, EventArgs e)
        {
            answer = a + b;
            txtOut.Text = Convert.ToString(answer);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            answer = a - b;
            txtOut.Text = Convert.ToString(answer);
        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToDouble(txtb.Text);
                txtb.BackColor = Color.White;
            }
            catch
            {
                txtb.BackColor = Color.IndianRed;
            }

            if (txta.BackColor == Color.White && txtb.BackColor == Color.White)
            {
                btnMinus.Enabled = true;
                btnPlus.Enabled = true;
            }
            else
            {
                btnMinus.Enabled = false;
                btnPlus.Enabled = false;
            }
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(txta.Text);
                txta.BackColor = Color.White;
            }
            catch
            {
                txta.BackColor = Color.IndianRed;
            }

            if (txta.BackColor == Color.White && txtb.BackColor == Color.White)
            {
                btnMinus.Enabled = true;
                btnPlus.Enabled = true;
            }
            else
            {
                btnMinus.Enabled = false;
                btnPlus.Enabled = false;
            }
        }
    }
}
