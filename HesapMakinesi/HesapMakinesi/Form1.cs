using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          
        }
        bool Operator = false; //genel değişken
        double sonuc = 0; //genel değişken
        string opt = ""; //genel değişken
        private void Rakamlar(object sender, EventArgs e)
        {
            if (İslemEkrani.Text == "0" || Operator)
                İslemEkrani.Clear();

            Operator = false;
            Button btn = (Button)sender;
            İslemEkrani.Text += btn.Text;
        }

        private void İslemEkrani_TextChanged(object sender, EventArgs e) 
        {

        }

        private void SonucEkrani_Click(object sender, EventArgs e)
        {

        }

        private void OperatorButonlar(object sender, EventArgs e)
        {
            Operator = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;

            SonucEkrani.Text = SonucEkrani.Text + " " + İslemEkrani.Text + " " + yeniOpt;
            switch (opt)
            {
                case "+": İslemEkrani.Text = (sonuc + Double.Parse(İslemEkrani.Text)).ToString(); break;
                case "-": İslemEkrani.Text = (sonuc - Double.Parse(İslemEkrani.Text)).ToString(); break;
                case "x": İslemEkrani.Text = (sonuc * Double.Parse(İslemEkrani.Text)).ToString(); break;
                case "÷": İslemEkrani.Text = (sonuc / Double.Parse(İslemEkrani.Text)).ToString(); break;
            }
            sonuc = Double.Parse(İslemEkrani.Text);
            İslemEkrani.Text = sonuc.ToString();
            opt = yeniOpt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            İslemEkrani.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            İslemEkrani.Text = "0";
            SonucEkrani.Text = "";
            opt = "";
            sonuc = 0;
            Operator = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            SonucEkrani.Text = "";
            Operator  = true;
            switch (opt)
            {
                case "+": İslemEkrani.Text = (sonuc + Double.Parse(İslemEkrani.Text)).ToString(); break;
                case "-": İslemEkrani.Text = (sonuc - Double.Parse(İslemEkrani.Text)).ToString(); break;
                case "x": İslemEkrani.Text = (sonuc * Double.Parse(İslemEkrani.Text)).ToString(); break;
                case "÷": İslemEkrani.Text = (sonuc / Double.Parse(İslemEkrani.Text)).ToString(); break;
            }
            sonuc = Double.Parse(İslemEkrani.Text);
            İslemEkrani.Text = sonuc.ToString();
            opt = "";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (İslemEkrani.Text == "0")
            {
                İslemEkrani.Text = "0";
            }
            else if (Operator)
            {
                İslemEkrani.Text = "0";
            }

            if (!İslemEkrani.Text.Contains(","))
            {
                İslemEkrani.Text += ",";
            }
            Operator = false;
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(İslemEkrani.Text) > 0)
            {
                İslemEkrani.Text = İslemEkrani.Text.Remove(İslemEkrani.Text.Length - 1, 1); // 1'er azaltarak silmesini sağlıyor.
                if(İslemEkrani.Text.Length==0)
                {
                    İslemEkrani.Text = "0";
                }
            }
        }

        private void button14_Click(object sender, EventArgs e) // 1/x  Butonu
        {
            double bireBolum = Convert.ToDouble(İslemEkrani.Text);
            bireBolum = 1/bireBolum;
            İslemEkrani.Text = Convert.ToString(bireBolum);
        }

        private void button13_Click(object sender, EventArgs e) // x² Butonu
        {
            double kare = Convert.ToDouble(İslemEkrani.Text);
            kare = Math.Pow(kare, 2);
            İslemEkrani.Text = Convert.ToString(kare);  
        }

        private void button12_Click(object sender, EventArgs e) // ²√x Butonu
        {
            double karekok = Convert.ToDouble(İslemEkrani.Text);
            karekok = Math.Sqrt(karekok);
            İslemEkrani.Text = Convert.ToString(karekok);
        }

        private void button7_Click(object sender, EventArgs e) // % Butonu
        {
            double yuzde = Convert.ToDouble(İslemEkrani.Text);
            yuzde = yuzde/100;
            İslemEkrani.Text = Convert.ToString(yuzde);
        }
    }
}
