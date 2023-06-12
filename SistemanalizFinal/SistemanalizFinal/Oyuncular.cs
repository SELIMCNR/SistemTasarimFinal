using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemanalizFinal
{
    public partial class Oyuncular : Form
    {
        public Oyuncular()
        {
            InitializeComponent();
        }

        SqlConnection bg = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Passaparola.mdf;Integrated Security=True");
        private void Oyuncular_Load(object sender, EventArgs e)
        {
            this.refresh();
        }
        public void refresh()
        {

          
            SqlCommand komut = new SqlCommand("Select * from Oyuncu", bg); 


            SqlDataAdapter da = new SqlDataAdapter(komut);  


            DataTable dt = new DataTable();  


            da.Fill(dt);     


            dataGridView1.DataSource = dt; 


        }


        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            if(Text_Ad.Text!="" && Text_Ad.Text != String.Empty &&
                Text_Soyad.Text != "" && Text_Soyad.Text != String.Empty &&
                Text_Puan.Text != "" && Text_Puan.Text != String.Empty)
            {

            
            bg.Open();  

            SqlCommand komut = new SqlCommand("insert into  Oyuncu (OyuncuAdı,OyuncuSoyadı,OyuncuPuanı) values (@p1,@p2,@p3)", bg);

            komut.Parameters.AddWithValue("@p1", Text_Ad.Text);
            komut.Parameters.AddWithValue("@p2", Text_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", Text_Puan.Text);



            komut.ExecuteNonQuery(); 

            bg.Close();


            MessageBox.Show("Oyuncu başarılı bir şekilde eklendi.");

                refresh();
            }
            else
            {
                MessageBox.Show("Hatalı işlem");
            }
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {

            bg.Open();

            SqlCommand komut = new SqlCommand("delete from Oyuncu where OyuncuAdı=@p1 ", bg);

            komut.Parameters.AddWithValue("@p1", Text_Ad.Text);

            komut.ExecuteNonQuery();

            bg.Close();

            MessageBox.Show("Oyuncu silme işlemi başarılı bir şekilde gerçekleşti");

        }

        private void Btn_Güncelle_Click(object sender, EventArgs e)
        {

            if (Text_Ad.Text != "" && Text_Ad.Text != String.Empty &&
              Text_Soyad.Text != "" && Text_Soyad.Text != String.Empty &&
              Text_Puan.Text != "" && Text_Puan.Text != String.Empty &&
              Text_İd.Text != "" && Text_İd.Text != String.Empty ){
                bg.Open();

                SqlCommand komut = new SqlCommand("update Oyuncu set OyuncuAdı=@p1,OyuncuSoyadı=@p2,OyuncuPuanı=@p3 where Oyuncuid =@p0", bg);

                komut.Parameters.AddWithValue("@p1", Text_Ad.Text);

                komut.Parameters.AddWithValue("@p2", Text_Soyad.Text);
                komut.Parameters.AddWithValue("@p3", Text_Puan.Text);
                komut.Parameters.AddWithValue("@p0", Text_İd.Text);

                komut.ExecuteNonQuery();

                bg.Close();

                MessageBox.Show("Kategori güncelleme işlemi başarılı bir şekilde gerçekleşti");
                refresh();

            }
            else
            {
                MessageBox.Show("Hatalı işlem");
            }

        }
    }
}
