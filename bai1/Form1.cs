namespace THB3_1
{
    public partial class Form1 : Form
    {
        private double firstNum = 0;
        private string operation = "";
        private bool isOpPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            firstNum = 0;
            operation = "";
            isOpPerformed = false;
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || isOpPerformed)
            {
                txtDisplay.Clear();
            }
            isOpPerformed = false;
            Button btn = sender as Button;
            if (btn != null)
            {
                txtDisplay.Text += btn.Text;
            }

        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                if (double.TryParse(txtDisplay.Text, out firstNum))
                {
                    operation = btn.Text;
                    isOpPerformed = true;
                }
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double secondNum;
            if (!double.TryParse(txtDisplay.Text, out secondNum)) return;
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (firstNum + secondNum).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (firstNum - secondNum).ToString();
                    break;
                case "x":
                    txtDisplay.Text = (firstNum * secondNum).ToString();
                    break;
                case "/":
                    if (secondNum != 0)
                    {
                        txtDisplay.Text = (firstNum / secondNum).ToString();
                    }
                    else
                        txtDisplay.Text = "loi chia cho 0";
                    break;
                default:
                    break;
            }
            operation = "";
        }
    }
}

