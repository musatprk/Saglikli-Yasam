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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=yasam; uid=admin; Password=123456");
        DataTable tablo = new DataTable();

        private void Form2_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlDataAdapter adap = new MySqlDataAdapter("select * from gun", baglanti);
            adap.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlDataAdapter adap = new MySqlDataAdapter("select * from gun", baglanti);
            adap.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form team = new Form1();
            team.Show();
            this.Hide();
        }
    }
}
