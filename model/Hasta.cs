using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOto.model
{
    class Hasta
    {
        public string TCKN { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string cinsiyet { get; set; }
        public string dogumYeri { get; set; }
        public DateTime dogumTarihi { get; set; }
        public string telefon { get; set; }
        public string eposta { get; set; }
        public string parola { get; set; }

        // nesne uretme, sınıfın tek nesnesı olsun
        static Hasta hasta = new Hasta();
       private Hasta()
        {
            // singleton mantıgı constructor u prıvate yapmaktır ki nesnesı turetılemesın(dısardan)
        }

        // singleton design pattern kullanımı, her ıhtıyac duyudugunda var olan nesne kullanılsın, sureklı yenı nesne turetılmesın
        public static Hasta getInstance()
        {
            return hasta;
        }
    }

}
