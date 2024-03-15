using System.Security.Cryptography;

namespace Calculator
{
    public partial class Calculator1 : Form
    {
        public Calculator1()
        {
            InitializeComponent();
        }
        string sign;
        double val1;
        double val2;
        int trackkeypoint = 0;

        private void cmd0_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd0.Text;
        }

        private void cmd1_Click_1(object sender, EventArgs e)
        {

        }
        private void cmd1_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd1.Text;
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd2.Text;
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd3.Text;
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd4.Text;
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd5.Text;
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd6.Text;
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd7.Text;
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd8.Text;
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd9.Text;
        }

        private void cmdequal_Click(object sender, EventArgs e)
        {
            val2 = double.Parse(txtBox.Text);
            double result;
            if (sign == "+")
            {
                result = val1 + val2;
                txtBox.Text = result.ToString();
            }
            else if (sign == "-")
            {
                result = val1 - val2;
                txtBox.Text = result.ToString();
            }
            else if (sign == "*")
            {
                result = val1 * val2;
                txtBox.Text = result.ToString();
            }
            else
            {
                result = val1 / val2;
                txtBox.Text = result.ToString();
            }

        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            //clear Texts
            txtBox.Text = "";
            val1 = 0;
            val2 = 0;
            sign = "";
        }

        private void cmdCos_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text = Math.Cos(v).ToString();
        }

        private void cmdSin_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text = Math.Sin(v).ToString();
        }

        private void cmdSquare_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text = Math.Pow(v, 2).ToString();
        }

        private void cmdsqrt_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text = Math.Sqrt(v).ToString();
        }

        private void cmdTan_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text = Math.Tan(v).ToString();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            sign = "+";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void cmdSubtract_Click(object sender, EventArgs e)
        {
            sign = "-";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void cmdplus_Click(object sender, EventArgs e)
        {
            sign = "+";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void cmdMultiply_Click(object sender, EventArgs e)
        {
            sign = "*";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void cmdDivide_Click(object sender, EventArgs e)
        {
            sign = "/";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }


    }
}