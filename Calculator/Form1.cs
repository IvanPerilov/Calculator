using System.Runtime.InteropServices;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double a = 0;
        private double memory = 0;
        private bool isPlus = false;
        private bool isMinus = false;
        private bool isMultiply = false;
        private bool isDivide = false;
        bool isMemoryExist = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void setAction(ref bool isAction)
        {
            if (textBox1.Text != "")
            {
                if (a == 0)
                {
                    double.TryParse(textBox1.Text, out a);
                    isAction = true;
                    textBox1.Text = "";
                }
                else setResult();
            }
        }

        private void setResult()
        {
            if (textBox1.Text != "")
            {
                if (isPlus)
                {
                    a += double.Parse(textBox1.Text);
                    showResult(ref isPlus);
                }
                if (isMinus)
                {
                    a -= double.Parse(textBox1.Text);
                    showResult(ref isMinus);
                }
                if (isMultiply)
                {
                    a *= double.Parse(textBox1.Text);
                    showResult(ref isMultiply);
                }
                if (isDivide)
                {
                    a /= double.Parse(textBox1.Text);
                    showResult(ref isDivide);
                }
            }
        }

        private void showResult(ref bool isAction)
        {
            textBox1.Text = (Math.Round(a,3)).ToString();
            isAction = false;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            setAction(ref isPlus);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            setAction(ref isMinus);
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            setAction(ref isMultiply);
        }

        private void bottonDev_Click(object sender, EventArgs e)
        {
            setAction(ref isDivide);
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (a != 0)
            {
                setResult();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            a = 0;
            isPlus = false;
            isMinus = false;
            isMultiply = false;
            isDivide = false;
            textBox1.Text = "";
        }
        private void print(Button butt)
        {
            textBox1.Text += butt.Text;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            print(button0);
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            print(buttonPoint);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            print(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            print(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            print(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            print(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            print(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            print(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            print(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            print(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            print(button9);
        }

        private void buttonMemoryClear_Click(object sender, EventArgs e)
        {
            memory = 0;
            isMemoryExist = false;
        }

        private void buttonMemoryPlus_Click(object sender, EventArgs e)
        {
            memory += double.Parse(textBox1.Text);
        }

        private void buttonMemoryMinus_Click(object sender, EventArgs e)
        {
            memory -= double.Parse(textBox1.Text);
        }

        private void buttonMemory_Click(object sender, EventArgs e)
        {

            if (!isMemoryExist)
            {
                double.TryParse(textBox1.Text,out memory);
                isMemoryExist = true;
            }
            else textBox1.Text = memory.ToString();

        }
    }
}