using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOto.model
{
    class Randevu
    {
        public int ID { get; set; }
        public string hastaTC { get; set; }
        public string hastaAdi { get; set; }
        public string hastaTel { get; set; }
        public string hastane { get; set; }
        public string bolum { get; set; }
        public string doktor { get; set; }
        public DateTime tarih { get; set; }

        // nesne uretme, sınıfın tek nesnesı olsun
        static Randevu randevu = new Randevu();
        private Randevu()
        {
            // singleton mantıgı constructor u prıvate yapmaktır ki nesnesı turetılemesın(dısardan)
        }

        // singleton design pattern kullanımı, her ıhtıyac duyudugunda var olan nesne kullanılsın, sureklı yenı nesne turetılmesın
        public static Randevu getInstance()
        {
            return randevu;
        }
    }
}
