namespace SimpleCalculator
{
    public partial class Calculator : Form
    {

        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDisplay.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            previousOperation = Operation.None;
            txtDisplay.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length > 0)
            {
                double d;
                if(!double.TryParse(txtDisplay.Text[txtDisplay.Text.Length-1].ToString(), out d))
                {
                    previousOperation = Operation.None;

                }
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length-1, 1);
            }
        }



        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (previousOperation != Operation.None)
            {
                performCalculation(previousOperation);
            }
            previousOperation = Operation.Div;
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (previousOperation != Operation.None)
            {
                performCalculation(previousOperation);
            }
            previousOperation = Operation.Mul;
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (previousOperation != Operation.None)
            {
                performCalculation(previousOperation);
            }
            previousOperation = Operation.Subtract;
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if(previousOperation != Operation.None)
            {
                performCalculation(previousOperation);
            }
            previousOperation= Operation.Plus;
            txtDisplay.Text += (sender as Button).Text;
        }

        private void performCalculation(Operation previousOperation)
        {
            List<double> firstNums = new List<double>();
            switch (previousOperation)
            {
                case Operation.Plus:
                    firstNums = txtDisplay.Text.Split('+').Select(double.Parse).ToList();
                    txtDisplay.Text = (firstNums[0] + firstNums[1]).ToString();
                    break;
                case Operation.Subtract:
                    firstNums = txtDisplay.Text.Split('-').Select(double.Parse).ToList();
                    txtDisplay.Text = (firstNums[0] - firstNums[1]).ToString();
                    break;
                case Operation.Mul:
                    firstNums = txtDisplay.Text.Split('*').Select(double.Parse).ToList();
                    txtDisplay.Text = (firstNums[0] * firstNums[1]).ToString();
                    break;
                case Operation.Div:
                    try
                    {
                        firstNums = txtDisplay.Text.Split('/').Select(double.Parse).ToList();
                        txtDisplay.Text = (firstNums[0] / firstNums[1]).ToString();
                    }
                    catch(DivideByZeroException)
                    {
                        txtDisplay.Text = "EEEEEEE";
                    }
                    break;
                case Operation.None: 
                    break;
                default:
                    break;
            }
        }

        enum Operation
        {
            Plus,
            Subtract,
            Mul,
            Div,
            None
        }

        static Operation previousOperation = Operation.None;

        private void btnEq_Click(object sender, EventArgs e)
        {
            if (previousOperation == Operation.None)
            {
                return;
            }
            else
            {
                performCalculation(previousOperation);
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btnNum_Click(object btn, EventArgs e)
        {
            txtDisplay.Text += (btn as Button).Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }
    }
}