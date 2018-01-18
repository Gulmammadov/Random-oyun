using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20171004Win_RandomOyun
{
    public partial class Form1 : Form
    {
        int eded, bal=100, cehd = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            eded = r.Next(0,101);
            this.Text = "Oyun basladi";
            button2.Enabled = true;
            button1.Enabled = false;
            label1.Text = "1-100 arasi eded daxil edin:";
            textBox1.Visible = true;
            label3.Text = "Bal: " + bal.ToString() + "\nGedis: " + cehd.ToString();
            //label2.Text = eded.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            label1.Text = "Oyunu başlamaq üçün Başla düyməsinə klik edin";
            label2.Text = "";
            label3.Text = "";
            this.Text = "GTA";
            textBox1.Visible = false;     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox1.Text) < 0 || int.Parse(textBox1.Text) > 100)
                {
                    MessageBox.Show("1-100 arasi eded daxil etmediniz");
                }
                else
                {
                    if (eded > int.Parse(textBox1.Text))
                    {
                        label2.Text = "Daxil etdiyiniz eded kicikdi";
                        bal -= 10;
                        cehd++;
                        label3.Text = "Bal: " + bal.ToString() + "\nGedis: " + cehd.ToString();
                    }
                    else if (eded < int.Parse(textBox1.Text))
                    {
                        bal -= 10;
                        cehd++;
                        label2.Text = "Daxil etdiyiniz eded boyukdu";
                        label3.Text = "Bal: " + bal.ToString() + "\nGedis: " + cehd.ToString();
                    }
                    else
                    {
                        label2.Text = "Tebrikler. Qalib geldiniz!";
                        label3.Text = "Bal: " + bal.ToString() + "\nGedis: " + cehd.ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Duzgun eded daxil etmediniz");
            }
            
        }
    }
}
