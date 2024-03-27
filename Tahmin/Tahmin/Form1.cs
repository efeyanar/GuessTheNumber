using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi = 0, tahminsayisi = 0, puan = 1000;

        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin = 0;
            tahminsayisi++;
            if (tahminsayisi<=9)
            {
                tahmin = Convert.ToInt32(textBox1.Text);
                label6.Text=Convert.ToString(tahminsayisi);
                if (sayi<tahmin)
                {
                    label5.Text = "Tahmininizi Azaltınız.";
                    puan = puan - 100;
                    label7.Text=Convert.ToString(puan);
                }
                else if (sayi > tahmin)
                {
                    label5.Text = "Tahminizi Artırınız.";
                    puan = puan - 100;
                    label7.Text = Convert.ToString(puan);
                }
                else
                {
                    label5.Text = "Tebrikler " + label6.Text + " defada bilip, " + label7.Text + " puan aldınız.";
                    button2.Enabled = true;
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    tahminsayisi = 0;
                    puan = 1000;
                }
                textBox1.Text = "";

            }
            else
            {
                textBox1.Enabled = false;
                MessageBox.Show("Tahmin Hakkınız Kalmadı! Oyun Kapatılacak.");
                this.Close();
                tahminsayisi = 0;
                puan = 1000;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox1.Enabled = true;
            button2.Enabled = false;

            Random rnd = new Random();
            sayi = rnd.Next(100);

            label8.Text = sayi.ToString();
            label5.Text = "";
            label6.Text = "0";
            label7.Text = "1000";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.Enabled = false;
            

        }
    }
}
