using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafakSayar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitSettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerMola.Start();
            timerGün.Start();
            timerHafta.Start();
            timerEgitim.Start();
        }

        public void InitSettings()
        {
            lblEgitimBitis.Visible = false;
            lblEgitimBitis2.Visible = false;
            lblGunBitis.Visible = false;    
            lblGunBitis2.Visible = false;
            lblHaftaBitis.Visible = false;
            lblHaftaBitis2.Visible = false;
            lblMolaBitis.Visible = false;
            lblMolaBitis2.Visible = false;
        }

        public void LabelsControl()
        {
            lblEgitimBitis.Visible = true;
            lblEgitimBitis2.Visible = true;
            lblGunBitis.Visible = true;
            lblGunBitis2.Visible = true;
            lblHaftaBitis.Visible = true;
            lblHaftaBitis2.Visible = true;
            lblMolaBitis.Visible = true;
            lblMolaBitis2.Visible = true;
        }
        string[] molalar = new[] { "16:30", "18:30", "20:00"};
        private void timer1_Tick(object sender, EventArgs e)
        {
            string girisZamani = DateTime.Now.ToLongTimeString();
            string cikisZamani = "";
            string calismaSuresi = "";
            TimeSpan girisCikisFarki = new TimeSpan(0, 0, 0, 0,0);
            int index = 0;

            for (int i = 0; i < molalar.Length; i++)
            {
                cikisZamani = molalar[i];
                girisCikisFarki = DateTime.Parse(cikisZamani).Subtract(DateTime.Parse(girisZamani));
                if (girisCikisFarki.TotalSeconds > 0)
                {
                    calismaSuresi = girisCikisFarki.ToString();
                    index = i;
                    break;
                }
                else
                {
                    cikisZamani = "23:59";
                    girisCikisFarki = DateTime.Parse(cikisZamani).Subtract(DateTime.Parse(girisZamani));
                    lblMolaBitis2.Text = (girisCikisFarki.Hours + 16).ToString() + " Saat " + (girisCikisFarki.Minutes + 30) + " Dakika " + girisCikisFarki.Seconds.ToString() + " Saniye";
                    goto giris;
                }
            }
            lblMolaBitis2.Text = girisCikisFarki.Hours.ToString() + " Saat " + girisCikisFarki.Minutes.ToString() + " Dakika " + girisCikisFarki.Seconds.ToString() + " Saniye";
        giris:
            LabelsControl();
            
            if (girisCikisFarki.TotalSeconds == 1)
            {
                if (index == molalar.Length - 1)
                {
                    timerMola.Stop();
                    lblMolaBitis2.Text = "00:00:00";
                    MessageBox.Show("Dersiniz Bitmiştir. İyi Akşamlar..");
                }
                else
                {
                    MessageBox.Show("Molaya Çıkabilirsiniz!!! Mola Saati : " + molalar[index]);
                    timerMola.Stop();
                    timerMola.Start();
                }

            }
        }

        private void timerGün_Tick(object sender, EventArgs e)
        {
            string girisZamani = DateTime.Now.ToLongTimeString();
            string cikisZamani = "23:59:59";
            TimeSpan girisCikisFarki = girisCikisFarki = DateTime.Parse(cikisZamani).Subtract(DateTime.Parse(girisZamani));
            lblGunBitis2.Text = girisCikisFarki.Hours.ToString() + " Saat " + girisCikisFarki.Minutes.ToString() + " Dakika " + girisCikisFarki.Seconds.ToString() + " Saniye";
        }

        private void timerHafta_Tick(object sender, EventArgs e)
        {
            string day = DateTime.Now.DayOfWeek.ToString();
            int gun = 0;

            switch (day)
            {
                case "Monday":
                    gun = 1;
                    break;
                case "Tuesday":
                    gun = 2;
                    break;
                case "Wednesday":
                    gun = 3;
                    break;
                case "Thursday":
                    gun = 4;
                    break;
                case "Friday":
                    gun = 5;
                    break;
                case "Saturday":
                    gun = 6;
                    break;
                case "Sunday":
                    gun = 7;
                    break;
            }

            string girisZamani = DateTime.Now.ToLongTimeString();
            string cikisZamani = "23:59:59";
            int gunFarki = 7 - gun;
            TimeSpan girisCikisFarki = girisCikisFarki = DateTime.Parse(cikisZamani).Subtract(DateTime.Parse(girisZamani));
            lblHaftaBitis2.Text = gunFarki + " Gün " + girisCikisFarki.Hours.ToString() + " Saat " + girisCikisFarki.Minutes.ToString() + " Dakika " + girisCikisFarki.Seconds.ToString() + " Saniye";

        }

        private void timerEgitim_Tick(object sender, EventArgs e)
        {
            string[] sub = new string[4];
            TimeSpan bitis = DateTime.Parse("30.03.2022 20:00:00").Subtract(DateTime.Now);

            lblEgitimBitis2.Text = bitis.Days.ToString() + " Gün " + bitis.Hours.ToString() + " Saat " + bitis.Minutes.ToString() + " Dakika " + bitis.Seconds.ToString() + " Saniye";
        }
    }
}
