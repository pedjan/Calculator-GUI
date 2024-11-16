using System.Net;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void b0_Click(object sender, EventArgs e)
        {
            {
                if (result.Text.EndsWith('.') || (result.Text != "0" && result.Text != Operation))
                {
                    result.Text += "0";
                }
                else if (result.Text == "0" || Operation != null)
                {
                    result.Text = "0";
                }
                else
                {
                    result.Text += "0";
                }
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (result.Text.EndsWith('.') || (result.Text != "0" && result.Text != Operation))
            {
                result.Text += "1";
            }
            else if (result.Text == "0" || Operation != null)
            {
                result.Text = "1";
            }
            else
            {
                result.Text += "1";
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (result.Text.EndsWith('.') || (result.Text != "0" && result.Text != Operation))
            {
                result.Text += "2";
            }
            else if (result.Text == "0" || Operation != null)
            {
                result.Text = "2";
            }
            else
            {
                result.Text += "2";
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (result.Text.EndsWith('.') || (result.Text != "0" && result.Text != Operation))
            {
                result.Text += "3";
            }
            else if (result.Text == "0" || Operation != null)
            {
                result.Text = "3";
            }
            else
            {
                result.Text += "3";
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (result.Text.EndsWith('.') || (result.Text != "0" && result.Text != Operation))
            {
                result.Text += "4";
            }
            else if (result.Text == "0" || Operation != null)
            {
                result.Text = "4";
            }
            else
            {
                result.Text += "4";
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (result.Text.EndsWith('.') || (result.Text != "0" && result.Text != Operation))
            {
                result.Text += "5";
            }
            else if (result.Text == "0" || Operation != null)
            {
                result.Text = "5";
            }
            else
            {
                result.Text += "5";
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (result.Text.EndsWith('.') || (result.Text != "0" && result.Text != Operation))
            {
                result.Text += "6";
            }
            else if (result.Text == "0" || Operation != null)
            {
                result.Text = "6";
            }
            else
            {
                result.Text += "6";
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (result.Text.EndsWith('.') || (result.Text != "0" && result.Text != Operation))
            {
                result.Text += "7";
            }
            else if (result.Text == "0" || Operation != null)
            {
                result.Text = "7";
            }
            else
            {
                result.Text += "7";
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (result.Text.EndsWith('.') || (result.Text != "0" && result.Text != Operation)) 
            {
                result.Text += "8";
            }
            else if (result.Text == "0" || Operation != null)
            {
                result.Text = "8";
            }
            else
            {
                result.Text += "8";
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (result.Text.EndsWith('.') || (result.Text != "0" && result.Text != Operation))
            {
                result.Text += "9";
            }
            else if (result.Text == "0" || Operation != null)
            {
                result.Text = "9";
            }
            else
            {
                result.Text += "9";
            }
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            if (!result.Text.EndsWith('.')) {
                result.Text += ".";
            }
        }

        private void bplus_Click(object sender, EventArgs e)
        {
            if (result.Text != "+")
            {
                FirstNumber = Convert.ToDouble(result.Text);
                result.Text = "+";
                Operation = "+";
            }
        }

        private void bminus_Click(object sender, EventArgs e)
        {
            if (result.Text != "")
            {
                FirstNumber = Convert.ToDouble(result.Text);
                result.Text = "-";
                Operation = "-";
            }
        }

        private void bputa_Click(object sender, EventArgs e)
        {
            if (result.Text != "*")
            {
                FirstNumber = Convert.ToDouble(result.Text);
                result.Text = "*";
                Operation = "*";
            }
        }

        private void bpodeljenjo_Click(object sender, EventArgs e)
        {
            if (result.Text != "/")
            {
                FirstNumber = Convert.ToDouble(result.Text);
                result.Text = "/";
                Operation = "/";
            }
        }

        private void beq_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;
            SecondNumber = Convert.ToDouble(result.Text);

            prvi.Text = FirstNumber.ToString();
            drugi.Text = result.Text;
            operacija.Text = Operation;

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                result.Text = Convert.ToString(Result);
                FirstNumber = Result;

            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                result.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                result.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    result.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    result.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }
    }
}
