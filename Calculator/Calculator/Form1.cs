using System.Net;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        double SecondNumber;
        double Result = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            show.Text = Convert.ToString(Result);
        }


        private void b_Click(object sender, EventArgs e)
        {
            double broj = Convert.ToDouble((sender as Button).Text);
            if (show.Text == "0" || show.Text == Operation || show.Text == "Cannot divide by zero")
            {
                show.Text = Convert.ToString(broj);
            }
            else
            {
                show.Text += Convert.ToString(broj);
            }

        }

        private void bdot_Click(object sender, EventArgs e)
        {
            if (!show.Text.Contains('.')) {
                show.Text += ".";
            }
        }

        private void bope_Click(object sender, EventArgs e)
        {
            string operatorL = (sender as Button).Text;
            if (Operation != null)
            {
                Operation = operatorL;
                show.Text = operatorL;
            }
            if (show.Text != operatorL)
            {
                FirstNumber = Convert.ToDouble(show.Text);
                show.Text = operatorL;
                Operation = operatorL;
            }
        }

        private void beq_Click(object sender, EventArgs e)
        {
            if(show.Text == "Cannot divide by zero")
            {
                reset();
            }
            try
            {
                SecondNumber = Convert.ToDouble(show.Text);
            }
            catch (Exception)
            {
           
            }
            

            prvi.Text = FirstNumber.ToString();
            drugi.Text = show.Text;
            operacija.Text = Operation;

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                show.Text = Convert.ToString(Result);
                FirstNumber = Result;

            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                show.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                show.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    show.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    show.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset() {
            show.Text = "0";
            Operation = null;
            FirstNumber = 0;
            SecondNumber = 0;
            Result = 0;

            prvi.Text = "";
            drugi.Text = "";
            operacija.Text = "";
        }
    }
}
