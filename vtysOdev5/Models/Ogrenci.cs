using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtysOdev5.Models
{
    public class Ogrenci
    {
        public int OgrenciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public int BolumID { get; set; }
        public virtual Bolum Bolum { get; set; }

        public virtual ICollection<OgrenciDers> OgrenciDersler { get; set; }
    }
}
