using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KÜTÜPHANE_OTOMASYONU.Model
{
    public class Kisi
    {
        public int ıd { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }
        public DateTime olusturmatarihi { get; set; }


        public Kisi()
        {
            
        }

        public Kisi(int ıd, string isim, string soyisim, string kullaniciadi, string sifre, string yetki, DateTime olusturmatarihi)
        {
            this.ıd = ıd;
            this.isim = isim;
            this.soyisim = soyisim;
            this.kullaniciadi= kullaniciadi;
            this.sifre = sifre;
            this.yetki = yetki;
            this.olusturmatarihi=olusturmatarihi;

        }

        public int getId()
        {
            return this.ıd; 
        }

        public void setId(int ıd)
        {
            this.ıd=ıd;
        }

        public string getIsim()
        {
            return this.isim;
        }

        public void setIsim (string isim)
        {
            this.isim = isim;
        }

        public string getSoyisim ()
        {
            return this.soyisim;
        }
        public void setSoyisim(string soyisim)
        {
            this.soyisim= soyisim;
        }

        public string getKullaniciadi ()
        {
            return this.kullaniciadi;
        }
        public void setKullaniciadi(string kullaniciadi)
        {
            this.kullaniciadi = kullaniciadi;
        }

        public string getSifre()
        {
            return this.sifre;
        }
        public void setSifre(string sifre)
        {
            this.sifre= sifre;
        }
        public string getYetki()
        {
            return this.yetki;
        }
        public void setYetki (string yetki)
        {
            this.yetki = yetki;
        }
        public DateTime getOlusturmatarihi() 
        {
            return this.olusturmatarihi; 
        }
        public void setOlusturmatarihi(DateTime olusturmatarihi)
        {
            this.olusturmatarihi = olusturmatarihi;
        }


        public override string ToString()
        {
            return "İsim: " + " " + "Soyisim: " + getIsim() + " " + getSoyisim();
        }



    }
}
