using System.Data;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button5_Click(object sender, EventArgs e)
        //{

        //}

        private void nButton_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            if (TxtBox.Text == "0" || TxtBox.Text == "Error")
            {
                TxtBox.Text = s;
            }
            else
            {
                TxtBox.Text += s;
            }

        }

        private void equals_Click(object sender, EventArgs e)
        {
            // math evaluate string
            // catch error
            // System.Data.SyntaxErrorException: Syntax error: Missing operand before '*' operator.
            try
            {
                DataTable dt = new DataTable();
                var v = dt.Compute(TxtBox.Text, "");
                TxtBox.Text = v.ToString();
            }
            catch
            {
                TxtBox.Text = "Error";

            }

        }

        private void CE_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text.Length == 1)
            {
                //do nothing
            }
            else if (TxtBox.Text == "Error")
            {
                TxtBox.Text = "0";
            }
            else
            {
                TxtBox.Text = TxtBox.Text.Remove(TxtBox.Text.Length - 1);
            }


        }

        private void AC_Click(object sender, EventArgs e)
        {
            // set textbox equal to "0"
            TxtBox.Text = "0";

        }


        //private void button2_Click(object sender, EventArgs e)
        //{

        //}

        //private void button6_Click(object sender, EventArgs e)
        //{

        //}

        //private void button3_Click(object sender, EventArgs e)
        //{

        //}

        //private void button3_Click_1(object sender, EventArgs e)
        //{

        //}
    }
}