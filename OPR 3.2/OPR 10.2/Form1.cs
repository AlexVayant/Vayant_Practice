namespace OPR_10._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked&& checkBox2.Checked) || (checkBox1.Checked&& checkBox3.Checked) || (checkBox1.Checked&& checkBox4.Checked)||(checkBox2.Checked&&checkBox3.Checked)||(checkBox2.Checked && checkBox4.Checked)||(checkBox3.Checked && checkBox4.Checked))
            {
                textBox1.Text = "�������� ������ ���� ��������!";
            }
            else
            {
                if (checkBox1.Checked || checkBox4.Checked)
                {
                    textBox1.Text = "cos � ������ �������� �������������!";
                }
                else
                {
                    if (checkBox2.Checked || checkBox3.Checked)
                    {
                        textBox1.Text = "cos � ������ �������� ���������������!";
                    }
                }
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                textBox1.Text = "�������� ���� �� ���� ��������!";
            }
        }
    }
}
