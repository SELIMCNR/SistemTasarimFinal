using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemanalizFinal
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
            timer1.Start();
        }
        
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            
        }

         int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if(time %2== 0)
            {
                label1.BackColor = Color.Blue;
                label1.ForeColor = Color.Yellow;
            }
            else
            {
                label1.BackColor = Color.Yellow;
                label1.ForeColor = Color.Blue;
            }
        }
        

        private void oynaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game fr = new Game();
            fr.ShowDialog();
                
        }

        private void kurallarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult dr= MessageBox.Show("Passaparola oyunu yeni ve türkçe sorulan sorularla sürekli kendini geliştiriyor. Sorulan soruların cevabı sıralı harflerle başlıyor. Örneğin ilk sorunun cevabı \"A\" harfi ile, ikinci sorunun cevabı \"B\" harfi ile başlıyor. Bilemediğimiz soruyu geçmek için \"PAS\" butonuna basıyoruz.Cevapları yazdıktan sonra enter tuşuna basmalıyız yoksa çalışmaz.");
        
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult dr = MessageBox.Show("Kapatmak  istermisin ? ","Kapatma işlemi ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Doğru karar. ");

            }
        }

        private void oyuncuSkorlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oyuncular fr = new Oyuncular();
            fr.ShowDialog();
        }
    }
}
