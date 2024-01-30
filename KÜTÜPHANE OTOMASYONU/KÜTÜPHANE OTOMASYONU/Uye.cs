using KÜTÜPHANE_OTOMASYONU.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KÜTÜPHANE_OTOMASYONU
{
    public partial class Uye : Form
    {

        List<Kitap> kitaplarım;

        public Uye(List<Kitap>kitaplarım)
        {
            InitializeComponent();

            this.kitaplarım = kitaplarım;

        }
        
        private void Uye_Load(object sender, EventArgs e)
        {
            foreach(Kitap kitap in kitaplarım)
            {
                dataGridView_üye.Rows.Add(kitap.getKitapid(), kitap.getKitapIsmi(), kitap.getKitapyazar(), kitap.getKitapdili(), kitap.getYayinevi(), kitap.getKitaptürü(), kitap.getAdet(), kitap.getSayfasayisi(), kitap.getBasimyili());
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1(); //kullanıcı çıkış yapa basınca form1 sayfası açılıp tekrar üye sayfası kapanacak
            loginsayfasi.Show();
            this.Hide();
            MessageBox.Show("Üye sayfasından çıkış yapıldı, giriş sayfasına yönlendiriliyorsunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_üyeara_Click(object sender, EventArgs e)
        {
            int arananid = Convert.ToInt32(txt_idüyeara.Text);

            dataGridView_üye.Rows.Clear();

            Kitap hedefkitap = null;

            foreach (Kitap kitap in kitaplarım) //kitaplarımda dolaşarak ara
            {
                if (kitap.getKitapid() == arananid)
                {
                    hedefkitap = kitap; //hedefkitabı yakaladık
                    break;
                }
            }

            dataGridView_üye.Rows.Add(hedefkitap.getKitapid(), hedefkitap.getKitapIsmi(), hedefkitap.getKitapyazar(), hedefkitap.getKitapdili(), hedefkitap.getYayinevi(), hedefkitap.getKitaptürü(), hedefkitap.getAdet(), hedefkitap.getSayfasayisi(), hedefkitap.getBasimyili());

        }
        
        private void btn_üyeyenile_Click(object sender, EventArgs e)
        {
            dataGridView_üye.Rows.Clear(); //içeriğitemizleyip tüm kitapları yeniden yazdırdık

            foreach (Kitap kitap in kitaplarım)
            {
                dataGridView_üye.Rows.Add(kitap.getKitapid(), kitap.getKitapIsmi(), kitap.getKitapyazar(), kitap.getKitapdili(), kitap.getYayinevi(), kitap.getKitaptürü(), kitap.getAdet(), kitap.getSayfasayisi(), kitap.getBasimyili());
            }
        }

        
    }
}
