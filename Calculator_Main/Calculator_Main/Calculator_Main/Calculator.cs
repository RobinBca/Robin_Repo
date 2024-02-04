using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Main
{
    public partial class Calculator : Form
    {
        // Variables
        float num1, num2, results;
        String operation;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // button 1
        {
            txtShowResults.Text += btnOne.Text;
        }
        private void btnTwo_Click(object sender, EventArgs e) // button 2
        {
            txtShowResults.Text += btnTwo.Text;
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            txtShowResults.Text += btnThree.Text;
        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            txtShowResults.Text += btnFour.Text;
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            txtShowResults.Text += btnFive.Text;
        }
        private void bntSix_Click(object sender, EventArgs e)
        {
            txtShowResults.Text += btnSix.Text;

        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtShowResults.Text += btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtShowResults.Text += btnEight.Text;
        }
        private void button8_Click(object sender, EventArgs e) // button nine
        {
            txtShowResults.Text += btnNine.Text;
        }

        // Calculator Operations 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation = "+";

            float.TryParse(txtShowResults.Text, out num1);
            // typecasting from string to float

            txtShowResults.Text = " "; // empting the string.
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operation = "*";

            float.TryParse(txtShowResults.Text, out num1);

            txtShowResults.Text = " ";
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            operation = "➗";

            float.TryParse(txtShowResults.Text, out num1);

            txtShowResults.Text = " ";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operation = " - ";

            float.TryParse(txtShowResults.Text, out num1);

            txtShowResults.Text = " ";
        }

        private void btnModDevide_Click(object sender, EventArgs e)
        {
            operation = " % ";

            float.TryParse(txtShowResults.Text, out num1);

            txtShowResults.Text = " ";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            float.TryParse(txtShowResults.Text, out num2);
            // 2 number is converted from string to num2

            if (operation == "+")
            {
                results = num1 + num2;
            }
            else if (operation == "-")
            {
                results = num1 - num2;
            }
            else if (operation == "*")
            {
                results = num1 * num2;
            }
            else if (operation == "➗")
            {
                results = num1 / num2;
            }
            else if (operation == " % ")
            {
                results = num1 % num2;
            }

            num1 = 0;
            num2 = 0;

            txtShowResults.Text = results.ToString();
            // Storing float value to string
            // typecasting float var to string 

        }
        private void txtShowResults_TextChanged(object sender, EventArgs e)
        {
            txtShowResults.Show();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtShowResults.Clear();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNoUse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dont use unwanted buttons Rey ! ","Robins Calculator",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // draw back
        // can't same oparation multiple times

    }
}
