using Evaluator.Logic;
using System.ComponentModel.DataAnnotations;

namespace Evaluator.UI.Windows
{
    public partial class Form1 : Form
    {
        public int CDut = 0;
        public int cOp = 0;
        public int cPar = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
            cOp = 0;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
            cOp = 0;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
            cOp = 0;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
            cOp = 0;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
            cOp = 0;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
            cOp = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
            cOp = 0;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
            cOp = 0;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
            cOp = 0;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
            cOp = 0;
        }
        ErrorProvider ErrorP = new ErrorProvider();
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (CDut == 0)
            {
                ErrorP.Clear();
                txtDisplay.Text += ",";
                CDut++;

            }
            else { ErrorP.SetError(btnDot, "No more commas allowed"); }


        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

            if (cOp == 0)
            {
                txtDisplay.Text += "/";
                CDut = 0;
                ErrorP.Clear();
                cOp++;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                txtDisplay.Text += "/";
                CDut = 0;
                ErrorP.Clear();
                cOp++;
            }

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (cOp == 0)
            {
                txtDisplay.Text += "*";
                CDut = 0;
                ErrorP.Clear();
                cOp++;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                txtDisplay.Text += "*";
                CDut = 0;
                ErrorP.Clear();
                cOp++;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (cOp == 0)
            {
                txtDisplay.Text += "+";
                CDut = 0;
                ErrorP.Clear();
                cOp++;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                txtDisplay.Text += "+";
                CDut = 0;
                ErrorP.Clear();
                cOp++;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (cOp == 0)
            {
                txtDisplay.Text += "-";
                CDut = 0;
                ErrorP.Clear();
                cOp++;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                txtDisplay.Text += "-";
                CDut = 0;
                ErrorP.Clear();
                cOp++;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
            CDut = 0;
            ErrorP.Clear();
        }

        private void btnOpenParenthesis_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "(";
            cPar++;
        }

        private void btnCloseParenthesis_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ")";
            cPar--;
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "^";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (cPar > 0)
            {
                MessageBox.Show("The operation is missing a ')'", "Error ");
            }
            else if (cPar < 0)
            {
                MessageBox.Show("The operation is missing a '('", "Error ");
            }
            else
            {
                txtDisplay.Text += $"={MyEvaluator.Evaluate(txtDisplay.Text)}";
            }

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}