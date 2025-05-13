using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtysOdev5.Models
{
    public class Bolum
    {
        public int BolumID { get; set; }
        public string BolumAd { get; set; }

        // Yabancı anahtar
        public int FakulteID { get; set; }
        public virtual Fakulte Fakulte { get; set; }

        // İlişki: 1 bölümün birçok öğrencisi olabilir
        public virtual ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}
