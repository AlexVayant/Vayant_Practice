using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace laba4
{
    public partial class laba4 : Form
    {
        public List<TRAIN> ride = new List<TRAIN>(10);
        public string[] name = { "Кемерово", "Томск", "Фрязино", "Майами", "Тимирязево", "Мариинск", "Биробиджан" };
        public List<string> time = new List<string> { $"0845", "1030", "1315", "1650","2000" };
        public laba4()
        {
            InitializeComponent();
        }
        private void laba4_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string path = "trains.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    writer.WriteLineAsync($"{time[rnd.Next(0, 5)]}");
                    writer.WriteLineAsync($"{name[rnd.Next(0, name.Length)]}");
                    writer.WriteLineAsync($"{rnd.Next(0, 50)}");
                }
            }
            using (StreamReader reader = new StreamReader(path))
            {
                for (int i = 0; i < 31; i++)
                    ride.Add(new TRAIN(reader.ReadLine(), reader.ReadLine(), Convert.ToInt32(reader.ReadLine())));
            }
            foreach (string tm in time)
                listBox1.Items.Add(tm.Insert(2, ":"));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text =="")
                {
                    listBox2.Items.Clear();
                    listBox2.Items.Add("Введите время отправления!");
                }
                else
                {
                    listBox2.Items.Clear ();
                    string text = $"{textBox1.Text}{textBox2.Text}";
                    int counter = 0;
                    foreach (TRAIN tm in ride.OrderBy(w => w.place))
                        if (Convert.ToInt32(text) <= Convert.ToInt32(tm.times))
                        {
                            listBox2.Items.Add($"Пункт назначения: {tm.place} Номер рейса: {tm.number} Время отправления: {tm.times.Insert(2, ":")}");
                            counter += 1;
                        }
                    if(counter == 0)
                    {
                        listBox2.Items.Clear();
                        listBox2.Items.Add("После данного времени рейсов не найдено!");
                    }
                }
                if (Convert.ToInt32(textBox1.Text)>=24 || Convert.ToInt32(textBox2.Text) >= 60 || Convert.ToInt32(textBox1.Text) < 0 || Convert.ToInt32(textBox2.Text) < 0 )
                {
                    listBox2.Items.Clear();
                    listBox2.Items.Add("Неверный формат времени");
                }
            }
            catch (FormatException)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Неверный формат времени");
            }
        }
    }
    public class TRAIN
    {
        public string place { get; set; }
        public int number { get; set; }
        public string times { get; set; }
        public TRAIN(string times1, string place1, int number1)
        {
            this.place = place1;
            this.number = number1;
            this.times = times1;
        }
    }
}
