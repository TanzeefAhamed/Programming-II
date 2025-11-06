using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionsCalculatorGui
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            Fraction fraction1 = new Fraction(txtFraction1.Text);
            Fraction fraction2 = new Fraction(txtFraction2.Text);
            Fraction result;

            if (rbtnAdd.Checked)
                result = fraction1 + fraction2;
            else if (rbtnSubtract.Checked)
                result = fraction1 - fraction2;
            else if (rbtnMultiply.Checked)
                result = fraction1 * fraction2;
            else
                result = fraction1 / fraction2;

            txtResult.Text = result.ToString();
        }

    }
}
