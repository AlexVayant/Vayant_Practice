namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n = trackBar1.Value;
            double a = 0;
            if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox1.Text = "Выберите только один вариант!";
            }
            else
            {
                if (checkBox1.Checked)
                {
                    a = n * (4 * Math.Pow(n, 2) - 1) / 3;
                    textBox1.Text = a.ToString();
                }
                else
                {
                    if (checkBox2.Checked)
                    {
                        for(double i = 1; i<=(2*n-1); i+=2)
                        {
                            a += Math.Pow(i, 2);
                        }
                        textBox1.Text = a.ToString();
                    }
                    else
                    {
                        textBox1.Text = "Выберите хотя бы один вариант расчёта!";
                    }
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
        }
    }
}
