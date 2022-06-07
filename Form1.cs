using System.Text.RegularExpressions;

namespace real
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AppendScreen(string myInput)
        {
            Regex regex = new Regex(@"^\d$");
            if (txtResult.Text == "0" && txtResult.Text.Length <= 1)
                txtResult.Text = string.Empty;
            txtResult.Text = txtResult.Text + myInput;
            if (regex.IsMatch(myInput) || txtDiscreteValue.Text == string.Empty)
                txtDiscreteValue.Text = txtDiscreteValue.Text + myInput;
        }
        private void AppendSigns(string mysign)
        {
            if (txtSigns.Text != string.Empty)
                txtSigns.Text = string.Empty;
            txtSigns.Text = mysign;
        }
        private void Appendresults()
        {
            Regex regex = new Regex(@"^\d$");
            decimal a = 0;
            decimal b = 0;
            decimal c = 0;
            string symbol = txtSigns.Text;

            if (TxtPreviousValue.Text == string.Empty)
                TxtPreviousValue.Text = txtDiscreteValue.Text;
            else
            {
                if (txtDiscreteValue.Text != string.Empty && TxtPreviousValue.Text != string.Empty)
                {

                    a = Convert.ToDecimal(TxtPreviousValue.Text);
                    b = Convert.ToDecimal(txtDiscreteValue.Text);
                    if (symbol == "+")
                        c = a + b;
                    if (symbol == "-")
                        c = a - b;
                    if (symbol == "*")
                        c = a * b;
                    if (symbol == "/")
                        c = a / b;
                    TxtPreviousValue.Text = c.ToString();

                }
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            AppendScreen("*");
            Appendresults();
            AppendSigns("*");

            txtDiscreteValue.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppendScreen("1");
            //txtSigns.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppendScreen("2");
            //txtSigns.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppendScreen("3");
            //txtSigns.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppendScreen("4");
            //txtSigns.Text = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AppendScreen("5");
            //txtSigns.Text = string.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AppendScreen("6");
            //txtSigns.Text = string.Empty;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AppendScreen("7");
            //txtSigns.Text = string.Empty;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AppendScreen("8");
            //txtSigns.Text = string.Empty;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AppendScreen("9");
            //txtSigns.Text = string.Empty;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AppendScreen("0");
            //txtSigns.Text = string.Empty;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            AppendScreen("-");
            Appendresults();
            AppendSigns("-");

            txtDiscreteValue.Text = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AppendScreen("+");
            Appendresults();
            AppendSigns("+");

            txtDiscreteValue.Text = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            AppendScreen("/");
            Appendresults();
            AppendSigns("/");

            txtDiscreteValue.Text = string.Empty;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
            Appendresults();
            txtResult.Text = TxtPreviousValue.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            txtDiscreteValue.Text = string.Empty;
            txtSigns.Text = string.Empty;
            TxtPreviousValue.Text = string.Empty;
        }

        private void sin_Click(object sender, EventArgs e)
        {
            //double result = double.Parse(txtSigns.Text);
            //result = result*Math.Sin(1);
            //txtResult.Text = result.ToString();
        }

        private void plusormin_Click(object sender, EventArgs e)
        {
            AppendScreen("");
            Appendresults();
            AppendSigns("-");
        }
    }
}