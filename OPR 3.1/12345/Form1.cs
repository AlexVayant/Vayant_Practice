namespace _12345
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;
            try
            {
                double a_1 = Convert.ToDouble(a);
                double b_1 = Convert.ToDouble(b);
                double c_1 = Convert.ToDouble(c);
                double v = a_1 * b_1 * c_1 * 0.21;
                if (v < 0)
                {
                    textBox4.Text = "Одно из значений отрицательное!";
                }
                else
                {
                    textBox4.Text = v.ToString();
                }
                
            }
            catch (Exception ex)
            {
                textBox4.Text = "Неверный формат!";
            }
        }
    }
}
