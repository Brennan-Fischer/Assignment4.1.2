namespace Assignment4._1._2
{
    public partial class Form1 : Form, ICalculator
    {
        double firstNumber = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        void Add()
        {
            firstNumber = Convert.ToDouble(Display.Text);
            Display.Text = "0";
            operation = "+";
        }
        void Subtract()
        {
            firstNumber = Convert.ToDouble(Display.Text);
            Display.Text = "0";
            operation = "-";
        }
        void Multiply()
        {
            firstNumber = Convert.ToDouble(Display.Text);
            Display.Text = "0";
            operation = "*";
        }
        void Divide()
        {
            firstNumber = Convert.ToDouble(Display.Text);
            Display.Text = "0";
            operation = "/";
        }

        private void but0_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "0";
            }
            else
            {
                Display.Text = Display.Text + "0";
            }
        }

        private void but1_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "1";
            }
            else
            {
                Display.Text = Display.Text + "1";
            }
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "2";
            }
            else
            {
                Display.Text = Display.Text + "2";
            }
        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "3";
            }
            else
            {
                Display.Text = Display.Text + "3";
            }
        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "4";
            }
            else
            {
                Display.Text = Display.Text + "4";
            }
        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "5";
            }
            else
            {
                Display.Text = Display.Text + "5";
            }
        }

        private void but6_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "6";
            }
            else
            {
                Display.Text = Display.Text + "6";
            }
        }

        private void but7_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "7";
            }
            else
            {
                Display.Text = Display.Text + "7";
            }
        }

        private void but8_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "8";
            }
            else
            {
                Display.Text = Display.Text + "8";
            }
        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "9";
            }
            else
            {
                Display.Text = Display.Text + "9";
            }
        }

        private void butDecimal_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = ".";
            }
            else
            {
                Display.Text = Display.Text + ".";
            }
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
        }

        private void butDivide_Click(object sender, EventArgs e)
        {
            Divide();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void butSub_Click(object sender, EventArgs e)
        {
            Subtract();
        }

        private void butMultiply_Click(object sender, EventArgs e)
        {
            Multiply();
        }

        private void butEqual_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+": 
                    Display.Text = Convert.ToString(Convert.ToDouble(Display.Text)+firstNumber);
                        break;
                case "-":
                    Display.Text = Convert.ToString(firstNumber-Convert.ToDouble(Display.Text));
                    break;
                case "*":
                    Display.Text = Convert.ToString(firstNumber * Convert.ToDouble(Display.Text));
                    break;
                case "/":
                    Display.Text = Convert.ToString(firstNumber / Convert.ToDouble(Display.Text));
                    break;
            }
            operation = null; 
        }
    }
}
