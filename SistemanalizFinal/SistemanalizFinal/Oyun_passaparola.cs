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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }


       public int soruno = 0, dogru = 0, yanlis=0;
        public SqlConnection bg = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Passaparola.mdf;Integrated Security = True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            soruno++;
            this.Text = soruno.ToString();
        }

        private void Link_Etiket_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Link_Etiket.Text = "Sonraki soru";
            soruno++;
            this.Text=soruno.ToString();

            if(soruno == 1) 
            {
                Rich_Textbox_Soru.Text = "Ülkemizin güney kısmındaki kıyı bölgesi ? ";
                Btn_a.BackColor = Color.Yellow;
            }
            if(soruno == 2)
            {
                Rich_Textbox_Soru.Text = "Yeşil alanlarıyla ünlü Marmara ilimiz ?";
                Btn_b.BackColor = Color.Yellow;
            }
            if(soruno == 3)
            {
                Rich_Textbox_Soru.Text = "Üzerine güneşin doğduğu en hayırlı gün ? ";
                Btn_c.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                Rich_Textbox_Soru.Text = "Karpuzuyla ünlü ilimiz ? ";
                Btn_d.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                Rich_Textbox_Soru.Text = "Yeni kelimesinin zıt anlamlısı ? ";
                Btn_e.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                Rich_Textbox_Soru.Text = "Padişahın emirlerinin yazılı olduğu hali ? ";
                Btn_f.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                Rich_Textbox_Soru.Text = "Dünyanın ısı kaynağı ? ";
                Btn_g.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                Rich_Textbox_Soru.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne ? ";
                Btn_h.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                Rich_Textbox_Soru.Text = "Gülüyle ünlü ilimiz ? ";
                Btn_ı.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                Rich_Textbox_Soru.Text = "Mersinin diğer ismi ? ";
                Btn_i.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                Rich_Textbox_Soru.Text = "Askeri bir topluluk ? ";
                Btn_j.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                Rich_Textbox_Soru.Text = "Malatyanın meşhur meyvesi ? ";
                Btn_k.BackColor = Color.Yellow;
            }

            if (soruno == 13)
            {
                Rich_Textbox_Soru.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali ? ";
                Btn_l.BackColor = Color.Yellow;
            }

            if (soruno == 14)
            {
                Rich_Textbox_Soru.Text = " Yılın 3.ayı ? ";
                Btn_m.BackColor = Color.Yellow;
            }

            if (soruno == 15)
            {
                Rich_Textbox_Soru.Text = " Üflemeli bir müzik aleti ? ";
                Btn_n.BackColor = Color.Yellow;
            }

            if (soruno == 16)
            {
                Rich_Textbox_Soru.Text = "Halk şairi ? ";
                Btn_o.BackColor = Color.Yellow;
            }

            if (soruno == 17)
            {
                Rich_Textbox_Soru.Text = "Çoçukların pek sevmediği pirinç havuç gibi sebzeler ile yapılan yemek ? ";
                Btn_p.BackColor = Color.Yellow;
            }

            if (soruno == 18)
            {
                Rich_Textbox_Soru.Text = "11 Ayın sultanı ? ";
                Btn_r.BackColor = Color.Yellow;
            }

            if (soruno == 19)
            {
                Rich_Textbox_Soru.Text = "İngilizcede yılan ne demek ? ";
                Btn_s.BackColor = Color.Yellow;
            }

            if (soruno == 20)
            {
                Rich_Textbox_Soru.Text = "Türkiyenin megastarı kimdir  ? ";
                Btn_t.BackColor = Color.Yellow;
            }

            if (soruno == 21)
            {
                Rich_Textbox_Soru.Text = "Ümit kelimesinin eş anlamlısı  ? ";
                Btn_u.BackColor = Color.Yellow;
            }

            if (soruno == 22)
            {
                Rich_Textbox_Soru.Text = " Kahvaltısı ile ünlü ilimiz ? ";
                Btn_v.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                Rich_Textbox_Soru.Text = "Şimşek kelimesinin eş anlamlısı ? ";
                Btn_y.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                Rich_Textbox_Soru.Text = "Ege bölgesinin en çok agacı bulunan yağı da yapılan bir kahvaltı besini ? ";
                Btn_z.BackColor = Color.Yellow;
            }




        }
        private void Textbox_Cevap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                   switch (soruno)
                {
                    case 1:
                        if (Textbox_Cevap.Text == "Akdeniz")
                        {
                            Btn_a.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_a.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();

                        }
                        break;


                    case 2:
                        if (Textbox_Cevap.Text == "Bursa")
                        {
                            Btn_b.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_b.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;


                    case 3:
                        if (Textbox_Cevap.Text == "Cuma")
                        {
                            Btn_c.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_c.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;

                    case 4:
                        if (Textbox_Cevap.Text == "Diyarbakır")
                        {
                            Btn_d.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_d.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;

                    case 5:
                        if (Textbox_Cevap.Text == "Eski")
                        {
                            Btn_e.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_e.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;

                    case 6:
                        if (Textbox_Cevap.Text == "Ferman")
                        {
                            Btn_f.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_f.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;

                    case 7:
                        if (Textbox_Cevap.Text == "Güneş")
                        {
                            Btn_g.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_g.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;

                    case 8:
                        if (Textbox_Cevap.Text == "Halı")
                        {
                            Btn_h.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_h.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;

                    case 9:
                        if (Textbox_Cevap.Text == "Isparta")
                        {
                            Btn_ı.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_ı.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;

                    case 10:
                        if (Textbox_Cevap.Text == "İçel")
                        {
                            Btn_i.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_i.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (Textbox_Cevap.Text == "Jandarma")
                        {
                            Btn_j.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_j.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (Textbox_Cevap.Text == "Kaysı")
                        {
                            Btn_k.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_k.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (Textbox_Cevap.Text == "Lale")
                        {
                            Btn_l.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_l.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (Textbox_Cevap.Text == "Mart")
                        {
                            Btn_m.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_m.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (Textbox_Cevap.Text == "Ney")
                        {
                            Btn_n.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_n.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (Textbox_Cevap.Text == "Ozan")
                        {
                            Btn_o.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_o.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (Textbox_Cevap.Text == "Pırasa")
                        {
                            Btn_p.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_p.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (Textbox_Cevap.Text == "Ramazan")
                        {
                            Btn_r.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_r.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (Textbox_Cevap.Text == "Snake")
                        {
                            Btn_s.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_s.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (Textbox_Cevap.Text == "Tarkan")
                        {
                            Btn_t.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_t.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (Textbox_Cevap.Text == "Umut")
                        {
                            Btn_u.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_u.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (Textbox_Cevap.Text == "Van")
                        {
                            Btn_v.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_v.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;
                    case 24:
                        if (Textbox_Cevap.Text == "Yıldırım")
                        {
                            Btn_y.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_y.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;
                    case 25:
                        if (Textbox_Cevap.Text == "Zeytin")
                        {
                            Btn_z.BackColor = Color.Green;
                            dogru++;
                            Lbl_doğru0.Text = dogru.ToString();
                        }
                        else
                        {
                            Btn_z.BackColor = Color.Red;
                            yanlis++;
                            Lbl_Yanlış0.Text = yanlis.ToString();
                        }
                        break;
                }
            }
        }
    }
}
