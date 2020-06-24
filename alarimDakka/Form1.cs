using System;
using System.Windows.Forms;
using System.Media;

namespace alarimDakka
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        //-------------------------------//
        int sayac,i=0,dk,pbar;
        SoundPlayer ses = new SoundPlayer();

        private void Button6_Click(object sender, EventArgs e)//sifirla Butonu
        {//resetButonu
            sifirla();
            ses.Stop();
        }
        void sifirla ()
        {
            ses.Stop();
            timer1.Stop();

            label1.Text = "--";
            progressBar1.Value = 0;
            pbar = 0;
            dk = 0;
        }

        private void Button2_Click(object sender, EventArgs e)//buton 20
        {
            sifirla();
            timerBaslat();
            sayac = 1200; // 1200/60 = 20dakika
            progressBar1.Maximum = sayac;
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            sifirla();
            timerBaslat();
            sayac = 1500; // yani 300/60 = 5 dakika yapar 
            progressBar1.Maximum = sayac;
        }

        private void btnSureBaslat_Click(object sender, EventArgs e)
        {
            sifirla();
            timerBaslat();
            sayac = Convert.ToInt32(tbSurekutusu.Text) * 60; // yani 300/60 = 5 dakika yapar 
            progressBar1.Maximum = sayac;
        }

        void timerBaslat() {
            timer1.Enabled = true; timer1.Start(); 
        }
        //public void sesOynat()
        //{
        //    try
        //    {
        //        string yol = Application.StartupPath + "\\ses.wav";
        //        ses.SoundLocation = yol;
        //        ses.Play();
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("ses.wav bulunamadı. (Süre bitiminde ses oynatılmayacak)");
        //    }
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval--; //timer değerini düşür
            sayac--; //sayacı düşür
                pbar++;
            progressBar1.Value = pbar;
            label1.Text = sayac.ToString();

            if (timer1.Interval <= 1 || sayac == 0)
            {
                string yol = Application.StartupPath + "\\ses.wav";
                ses.SoundLocation = yol;
                ses.Play();
                timer1.Enabled = false;
                timer1.Stop();
                pbar = 0;
            }

            dk++;
            while (dk == 60)
            {
                i++;
                labelDk.Text = i.ToString() + "DK";
                dk = 0;
            }
        }

        private void Button1_Click(object sender, EventArgs e)//5saniye butonu
        {
            sifirla();
            timerBaslat();
            sayac = 300; // yani 300/60 = 5 dakika yapar 
            progressBar1.Maximum = sayac;
        }

    }
}
