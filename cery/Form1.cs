using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pas = 0;
        int skor = 0;
        int saniye=60;
        int dakika = 0;
        Random rnd = new Random();
        string[] kelimeler = { "YAĞMUR", "BOYA", "KAZAK" };

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            int dogru = 0;
            dogru += 1;

            skor += 1;
            label5.Text=skor.ToString();

            listBox1.Items.Clear();
            textBox1.Text = "KAZAK";
            listBox1.Items.Add("         ");
            listBox1.Items.Add("          GİYMEK");
            listBox1.Items.Add("          KIYAFET");
            listBox1.Items.Add("          GİYSİ");
            listBox1.Items.Add("          ELBİSE");
            listBox1.Items.Add("          TİŞÖRT");
            if (textBox1.Text==kelimeler[0])
            {
                listBox1.Items.Add
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            skor = skor - 1;
            label5.Text=skor.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            pas = pas + 1;
            label3.Text=pas.ToString();
            if (pas>3)
            {

                MessageBox.Show("pas hakkınız bitti.");
            }
           
            listBox1.Items.Clear();
            textBox1.Text = "BOYA";
            listBox1.Items.Add("         ");
            listBox1.Items.Add("          RENK");
            listBox1.Items.Add("          KIRMIZI");
            listBox1.Items.Add("          SİYAH");
            listBox1.Items.Add("          KALEM");
            listBox1.Items.Add("          FIRÇA");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            dakika = Convert.ToInt32(textBox2.Text);

            listBox1.Items.Clear();
            textBox1.Text = "YAĞMUR";
            listBox1.Items.Add("         ");
            listBox1.Items.Add("          BULUT");
            listBox1.Items.Add("          HAVA");
            listBox1.Items.Add("          ISLAK");
            listBox1.Items.Add("          SU");
            listBox1.Items.Add("          GÜNEŞ");


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            saniye = saniye - 1;
            lblsaniye.Text = saniye.ToString();
            lbldakika.Text =(dakika - 1).ToString();
            if (saniye==0)
            {
                dakika = dakika - 1;
                lbldakika.Text = dakika.ToString();
                saniye = 60;
                if (lbldakika.Text=="0")
                {
                    timer1.Stop();
                    lbldakika.Text = "0";
                    lblsaniye.Text= "0";
                    lbldakika.BackColor= Color.Red;
                    lblsaniye.BackColor= Color.Red;
                    Application.Exit();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
