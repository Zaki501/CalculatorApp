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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = s;
            }
            else {
                TxtBox.Text += s;
            }

        }

        private void nButton_Click (object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = s;
            }
            else
            {
                TxtBox.Text += s;
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}