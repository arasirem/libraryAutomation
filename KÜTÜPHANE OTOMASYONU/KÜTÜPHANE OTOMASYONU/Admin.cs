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
    public partial class Admin : Form
    {
        List<Kisi> kisilerim;
        List<Kitap> kitaplarım;
        public Admin(List<Kisi>kisilerim , List<Kitap> kitaplarım)
        {
            InitializeComponent();

            this.kisilerim = kisilerim; //sayfa açıldığında önceden eklenmiş kişiler ve kitaplar gözüksün diye önce ctor çalışır diye ona ekledik
                                        //ve admin sayfası load olunca gözüksün diye orda foreach döngüsünde yazdırdık 
            this.kitaplarım = kitaplarım;
        }

    
        private void Admin_Load(object sender, EventArgs e)
        {

            foreach(Kisi kisi in kisilerim) //girilen bilgiler get ile alınıyor
                                            //kişilerim objesinde eklediğim bilgileri yazdırmak için kullandığım loop
            {
                dataGridView1.Rows.Add(kisi.getId (),kisi.getIsim(),kisi.getSoyisim(),kisi.getKullaniciadi(),kisi.getSifre(),kisi.getYetki(),kisi.getOlusturmatarihi());
            }

            foreach(Kitap kitap in kitaplarım) 
            {
                dataGridView2.Rows.Add(kitap.getKitapid(), kitap.getKitapIsmi(), kitap.getKitapyazar(), kitap.getKitapdili(), kitap.getYayinevi(), kitap.getKitaptürü(), kitap.getAdet(), kitap.getSayfasayisi(), kitap.getBasimyili());

            }



        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_ıd.Text);
            string ad =txt_ad.Text;
            string soyad =txt_soyad.Text;
            string kullaniciadi = txt_kullaniciadi.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_yetki.Text;
            DateTime olusturmatarihi = Convert.ToDateTime(masked_olusturmatarihi.Text);

            dataGridView1.Rows.Add (id,ad,soyad,kullaniciadi,sifre,yetki, olusturmatarihi);
            MessageBox.Show("Kayıt eklendi","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void textleridoldur()
        {

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string soyad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string kullaniciadi = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string sifre = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string yetki = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            DateTime olusturmatarihi = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value);


            txt_ıd.Text = id.ToString();
            txt_ad.Text = ad;
            txt_soyad.Text = soyad;
            txt_kullaniciadi.Text = kullaniciadi;
            txt_sifre.Text = sifre;
            txt_yetki.Text = yetki;
            masked_olusturmatarihi.Text = olusturmatarihi.ToString();
        } 

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleridoldur();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            MessageBox.Show("Kayıt silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void guncelle()
        {
            int id = Convert.ToInt32(txt_ıd.Text);
            string ad = txt_ad.Text;
            string soyad = txt_soyad.Text;
            string kullaniciadi = txt_kullaniciadi.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_yetki.Text;
            DateTime olusturmatarihi = Convert.ToDateTime(masked_olusturmatarihi.Text);

            dataGridView1.CurrentRow.Cells[0].Value = id;
            dataGridView1.CurrentRow.Cells[1].Value = ad;
            dataGridView1.CurrentRow.Cells[2].Value = soyad;
            dataGridView1.CurrentRow.Cells[3].Value = kullaniciadi;
            dataGridView1.CurrentRow.Cells[4].Value = sifre;
            dataGridView1.CurrentRow.Cells[5].Value = yetki;
            dataGridView1.CurrentRow.Cells[6].Value = olusturmatarihi;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            guncelle();
            MessageBox.Show("Kayıt güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            for (int i = 0;i<groupBox_kisiler.Controls.Count;i++)
            {
                if (groupBox_kisiler.Controls[i] is TextBox || groupBox_kisiler.Controls[i] is MaskedTextBox)
                {
                    groupBox_kisiler.Controls[i].Text = string.Empty;
                }
            }

        }

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            int kitapid = Convert.ToInt32(txt_kitapid.Text);
            string kitapismi = txt_kitapismi.Text;
            string kitapyazar = txt_yazar.Text;
            string kitapdili = txt_kitapdili.Text;
            string yayinevi = txt_yayinevi.Text;
            string kitaptürü = txt_tür.Text;
            int adet = Convert.ToInt32(txt_adet.Text);
            int sayfa = Convert.ToInt32(txt_sayfa.Text);
            int basimyili = Convert.ToInt32(txt_basimyili.Text);

            dataGridView2.Rows.Add(kitapid, kitapismi, kitapyazar, kitapdili, yayinevi, kitaptürü, adet, sayfa, basimyili);

            MessageBox.Show("Kitap bilgilerini başarıyla eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        public void textleridoldurkitap()
        {
            int kitapid = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            string kitapismi = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            string kitapyazar = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            string kitapdili = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            string yayinevi = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            string kitaptürü = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            int adet = Convert.ToInt32(dataGridView2.CurrentRow.Cells[6].Value);
            int sayfa = Convert.ToInt32(dataGridView2.CurrentRow.Cells[7].Value);
            int basimyili = Convert.ToInt32(dataGridView2.CurrentRow.Cells[8].Value);

            txt_kitapid.Text = kitapid.ToString();
            txt_kitapismi.Text = kitapismi;
            txt_yazar.Text = kitapyazar;
            txt_kitapdili.Text = kitapdili;
            txt_yayinevi.Text = yayinevi;
            txt_tür.Text = kitaptürü;
            txt_adet.Text = adet.ToString(); 
            txt_sayfa.Text = sayfa.ToString();
            txt_basimyili.Text = basimyili.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e) //datagridview2ye tıklanınca textlerin dolması için
        {
            textleridoldurkitap();
        }

        private void btn_kitapsil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }


        public void guncellekitap ()
        {
            dataGridView2.CurrentRow.Cells[0].Value = txt_kitapid.Text;
            dataGridView2.CurrentRow.Cells[1].Value = txt_kitapismi.Text;
            dataGridView2.CurrentRow.Cells[2].Value = txt_yazar.Text;
            dataGridView2.CurrentRow.Cells[3].Value = txt_kitapdili.Text;
            dataGridView2.CurrentRow.Cells[4].Value = txt_yayinevi.Text;
            dataGridView2.CurrentRow.Cells[5].Value = txt_tür.Text;
            dataGridView2.CurrentRow.Cells[6].Value = txt_adet.Text;
            dataGridView2.CurrentRow.Cells[7].Value = txt_sayfa.Text;
            dataGridView2.CurrentRow.Cells[8].Value = txt_basimyili.Text;

        }

        private void btn_kitapguncelle_Click(object sender, EventArgs e)
        {
            guncellekitap();
            MessageBox.Show("Kitap başarıyla güncellendi.","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_kitaptemizle_Click(object sender, EventArgs e)
        {
            for (int i = 0;i<groupBox_kitap.Controls.Count;i++)
            {
                if (groupBox_kitap.Controls[i] is TextBox)
                {
                    groupBox_kitap.Controls[i].Text= string.Empty;
                }
            }
        }




        private void btn_kisiara_Click(object sender, EventArgs e)
        {
            
            Kisi hedefkisi = null;

            int arananid = Convert.ToInt32(txt_IDarakisi.Text);

            foreach(Kisi kisi in kisilerim) //kisi nesnesi ile kisilerim listesinde gezecek
            {
                if (kisi.getId() == arananid)
                {
                    hedefkisi = kisi;
                    break; //hedefkişi bulundu daha fazla aramasına gerek yok
                }
            }

            dataGridView1.Rows.Clear(); //bütün rowlar temizlendi sadece hedef kişi bilgileri get metodlarıyla eklenecek
            dataGridView1.Rows.Add(hedefkisi.getId(), hedefkisi.getIsim(), hedefkisi.getSoyisim(), hedefkisi.getKullaniciadi(), hedefkisi.getSifre(),hedefkisi.getYetki(), hedefkisi.getOlusturmatarihi());
        }

        private void btn_kisiyenile_Click(object sender, EventArgs e)
        {
            
          //aranankişi temizlensin diye yine clear yapıp sonra eskideki tüm bilgileri yazdırıyoruz

             dataGridView1.Rows.Clear();

            foreach (Kisi kisi in kisilerim) //yukarıda adminloaddan kopyala yapıştır yaptım
            {
                dataGridView1.Rows.Add(kisi.getId(), kisi.getIsim(), kisi.getSoyisim(), kisi.getKullaniciadi(), kisi.getSifre(), kisi.getYetki(), kisi.getOlusturmatarihi());
            }

        }


        private void btn_kitapara_Click(object sender, EventArgs e)
        {
            Kitap hedefkitap = null;
            int arananid = Convert.ToInt32 (txt_IDarakitap .Text);

            foreach(Kitap kitap in kitaplarım)
            {
                if(kitap.getKitapid() == arananid)
                {
                    hedefkitap = kitap; 
                    break;
                }
            }


            dataGridView2.Rows.Clear();

            //burda sadece hedefkitap olarak yakaladığımız bilgileri yazdırıyoruz
            dataGridView2.Rows.Add(hedefkitap.getKitapid(), hedefkitap.getKitapIsmi(), hedefkitap.getKitapyazar(), hedefkitap.getKitapdili(), hedefkitap.getYayinevi(), hedefkitap.getKitaptürü(), hedefkitap.getAdet(), hedefkitap.getSayfasayisi(), hedefkitap.getBasimyili()) ;

        }

        private void btn_kitapyenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
           
            foreach(Kitap kitap in kitaplarım) //hepsini tekrar ekliyoruz 
            {
                dataGridView2.Rows.Add(kitap.getKitapid(), kitap.getKitapIsmi(), kitap.getKitapyazar(), kitap.getKitapdili(), kitap.getYayinevi(), kitap.getKitaptürü(), kitap.getAdet(), kitap.getSayfasayisi(), kitap.getBasimyili());
            }

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();

            MessageBox.Show("Admin sayfasından çıkış yapıldı,giriş sayfasına yönlendiriliyorsunuz", "Bilgilendirme", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
