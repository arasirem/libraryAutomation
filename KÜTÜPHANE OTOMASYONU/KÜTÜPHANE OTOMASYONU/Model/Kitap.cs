using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KÜTÜPHANE_OTOMASYONU.Model
{
    public class Kitap
    {
        public int kitapid { get; set; }
        public string kitapismi { get; set; }
        public string kitapyazar { get; set; }
        public string kitapdili { get; set; }
        public string yayinevi { get; set; }
        public string kitaptürü { get; set; }
        public int adet { get; set; }
        public int sayfasayisi { get; set; }
        public int basimyili { get; set; }



        public Kitap()
        {
            
        }

        public Kitap(int kitapid,string kitapismi, string kitapyazar, string kitapdili, string yayinevi, string kitaptürü, int adet, int sayfasayisi, int basimyili)
        {
            this.kitapid = kitapid;
            this.kitapismi = kitapismi;
            this.kitapyazar = kitapyazar;
            this.kitapdili = kitapdili;
            this.yayinevi = yayinevi;
            this.kitaptürü = kitaptürü;
            this.adet = adet;
            this.sayfasayisi = sayfasayisi;
            this.basimyili = basimyili;
        }

        //getleri yazıyoruz setleri aslında yazmamıza gerek yok çünkü ctorda zaten set edebiliyoruz

        public int getKitapid()
        {
            return this.kitapid;
        }
       

        public string getKitapIsmi()
        {
            return this.kitapismi;
        }
        
        public string getKitapyazar()
        {
            return this.kitapyazar;
        }
       
        public string getKitapdili()
        {
            return this.kitapdili;
        }
       
        public string getYayinevi()
        {
            return this.yayinevi;
        }
      
        public string getKitaptürü()
        {
            return this.kitaptürü;
        }    
       public int getAdet()
        {
            return this.adet;
        }
        
        public int getSayfasayisi()
        {
            return this.sayfasayisi;
        }
       
        public int getBasimyili()
        {
            return this.basimyili;
        }
       




    }
}
