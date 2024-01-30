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
    public partial class Form1 : Form
    {

        List<Kisi> kisilerim = new List<Kisi>(); //kisilerim objesini oluşturdum

        List<Kitap> kitaplarım = new List<Kitap>();

        public Form1()
        {
            InitializeComponent();
        }

  
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullaniciadi.Text = string.Empty;
            txt_sifre.Text = string.Empty;
        }   
        private void btn_girisyap_Click(object sender, EventArgs e)
        {
           string kullaniciadi = txt_kullaniciadi.Text;
           string sifre = txt_sifre.Text;


                bool kontrol = false;

                foreach (Kisi kisi in kisilerim)
                {
                    if (kullaniciadi.ToLower() == kisi.getKullaniciadi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "admin")
                    {
                        //admin sayfasına yönlendireceğiz

                        Admin admin = new Admin(kisilerim,kitaplarım); //admin sfsında önce ctora çalıştığı için ctora gidince kisilerim'i verecek
                        admin.Show();
                        kontrol = true;
                        this.Hide();
                    }

                    else if (kullaniciadi.ToLower() == kisi.getKullaniciadi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "uye")
                    {
                        //üye sayfasına yönlendireceğiz

                        Uye uye = new Uye(kitaplarım);
                        uye.Show();
                        kontrol=true;
                        this.Hide();
                    }
                }

            if (kontrol==false)
            {
                MessageBox.Show("Hatalı giriş!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            } 
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kisi(1, "İrem", "Aras", "arasirem", "ia", "admin", DateTime.Now ));
            kisilerim.Add(new Kisi(2, "Zeynep", "Aras", "araszeynep", "za", "uye", DateTime.Now));
            kisilerim.Add(new Kisi(3, "Fatma", "Aras", "arasfatma", "fa", "uye", DateTime.Now));



            kitaplarım.Add(new Kitap(1, "Kürk Mantolu Madonna","Sabahattin Ali","Türkçe", "Yapıkredi yayınları","roman", 100, 136, 1943 ));
            kitaplarım.Add(new Kitap(2, "İnce Mehmed", "Yaşar Kemal", "Türkçe", " İş Bankası Kültür Yayınları", "roman", 210, 208,1976));
            kitaplarım.Add(new Kitap(3, "Dönüşüm", "Franz kafka", "Almanca", " İş Bankası Kültür Yayınları", "roman", 110, 96, 1915));
            kitaplarım.Add(new Kitap(4, "Sineklerin Tanrısı", "William Golding", "İngilizce", " Can Yayınları", "roman", 150, 240, 1954));
            kitaplarım.Add(new Kitap(5, "Kırmızı Saçlı Kadın", "Orhan Pamuk", "Türkçe", "  Yapı Kredi Yayınları", "roman", 250, 480, 2016));
            kitaplarım.Add(new Kitap(6, "Beyaz Zambaklar Ülkesinde", "Grigory Petrov", "Rusça", " Can Yayınları", "roman", 450, 208, 1939));
            

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {

            DialogResult = MessageBox.Show("Çıkış yapmak mı istiyorsunuz?", "" , MessageBoxButtons.YesNo, MessageBoxIcon.Question );
            
            if ( DialogResult == DialogResult.Yes )
            {
                Application.Exit();
            }
        }
    }
}
