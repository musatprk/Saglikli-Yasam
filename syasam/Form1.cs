using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace syasam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=yasam; uid=admin; Password=123456");
        DataTable tablo = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            kilolbl.Text = kilo.Text;
            string boy1 = boy.Text;
            double toplam = (Convert.ToSingle(kilo.Text))/((Convert.ToSingle(boy.Text)) * (Convert.ToSingle(boy.Text)) / 10000);
            toplam = Math.Round(toplam, 2);
            vkilbl.Text = toplam.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            double egz = 12;
            double toplam = egz * (Convert.ToSingle(egzertxt.Text));
            toplam = Math.Round(toplam, 2);
            egzerlbl.Text =(Convert.ToSingle(egzerlbl.Text) + toplam).ToString();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            double egz = 8.2;
            double toplam = egz * (Convert.ToSingle(egzertxt.Text));
            toplam = Math.Round(toplam, 2);
            egzerlbl.Text = (Convert.ToSingle(egzerlbl.Text) + toplam).ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            double egz = 4.2;
            double toplam = egz * (Convert.ToSingle(egzertxt.Text));
            toplam = Math.Round(toplam, 2);
            egzerlbl.Text = (Convert.ToSingle(egzerlbl.Text) + toplam).ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            double egz = 8.9;
            double toplam = egz * (Convert.ToSingle(egzertxt.Text));
            toplam = Math.Round(toplam, 2);
            egzerlbl.Text = (Convert.ToSingle(egzerlbl.Text) + toplam).ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            double egz = 8.3;
            double toplam = egz * (Convert.ToSingle(egzertxt.Text));
            toplam = Math.Round(toplam, 2);
            egzerlbl.Text = (Convert.ToSingle(egzerlbl.Text) + toplam).ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            double egz = 4.6;
            double toplam = egz * (Convert.ToSingle(egzertxt.Text));
            toplam = Math.Round(toplam, 2);
            egzerlbl.Text = (Convert.ToSingle(egzerlbl.Text) + toplam).ToString();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            double egz = 11;
            double toplam = egz * (Convert.ToSingle(egzertxt.Text));
            toplam = Math.Round(toplam, 2);
            egzerlbl.Text = (Convert.ToSingle(egzerlbl.Text) + toplam).ToString();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut= new MySqlCommand("select beskal from besinler where besad='" + kahadtxt.Text + "'", baglanti);
            komut.ExecuteNonQuery();
             double a = Convert.ToSingle(komut.ExecuteScalar());
            double b=(Convert.ToSingle(kahgrtxt.Text) *a);
            b = Math.Round(b,2);
            double toplam= (Convert.ToSingle(kahlbl.Text) + b);
            toplam = Math.Round(toplam, 2);
            kahlbl.Text = toplam.ToString();
            baglanti.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select beskal from besinler where besad='" + ara1adtxt.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            double a = Convert.ToSingle(komut.ExecuteScalar());
            double b = (Convert.ToSingle(ara1grtxt.Text) * a);
            b = Math.Round(b, 2);
            double toplam = (Convert.ToSingle(ara1lbl.Text) + b);
            toplam = Math.Round(toplam, 2);
            ara1lbl.Text = toplam.ToString();
            baglanti.Close();

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select beskal from besinler where besad='" + ogleadtxt.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            double a = Convert.ToSingle(komut.ExecuteScalar());
            double b = (Convert.ToSingle(oglegrtxt.Text) * a);
            b = Math.Round(b, 2);
            double toplam = (Convert.ToSingle(oglelbl.Text) + b);
            toplam = Math.Round(toplam, 2);
            oglelbl.Text = toplam.ToString();
            baglanti.Close();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select beskal from besinler where besad='" + ara2adtxt.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            double a = Convert.ToSingle(komut.ExecuteScalar());
            double b = (Convert.ToSingle(ara2gr.Text) * a);
            b = Math.Round(b, 2);
            double toplam = (Convert.ToSingle(ara2lbl.Text) + b);
            toplam = Math.Round(toplam, 2);
            ara2lbl.Text = toplam.ToString();
            baglanti.Close();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select beskal from besinler where besad='" + aksamadtxt.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            double a = Convert.ToSingle(komut.ExecuteScalar());
            double b = (Convert.ToSingle(aksamgr.Text) * a);
            b = Math.Round(b, 2);
            double toplam = (Convert.ToSingle(aksamlbl.Text) + b);
            toplam = Math.Round(toplam, 2);
            aksamlbl.Text = toplam.ToString();
            baglanti.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            double toplam = (Convert.ToSingle(kahlbl.Text) + Convert.ToSingle(ara1grtxt.Text)+ Convert.ToSingle(oglegrtxt.Text)+ Convert.ToSingle(ara2lbl.Text)+ Convert.ToSingle(aksamlbl.Text)- Convert.ToSingle(egzerlbl.Text));
            toplam = Math.Round(toplam, 2);
            toplamkallbl.Text = toplam.ToString();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut2 = new MySqlCommand("insert into gun(kal,kilo) values('" + toplamkallbl.Text + "','" + kilolbl.Text + "')", baglanti);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Günlüğe Kaydedildi");
            tablo.Clear();
            baglanti.Close();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Form team = new Form2();
            team.Show();
            this.Hide();

        }
    }
}
