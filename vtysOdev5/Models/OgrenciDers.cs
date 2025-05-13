using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtysOdev5.Models
{
    public class OgrenciDers
    {
        public int OgrenciDersID { get; set; }

        public int OgrenciID { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }

        public int DersID { get; set; }
        public virtual Ders Ders { get; set; }

        public string Yil { get; set; }
        public string Yariyil { get; set; }

        public int? Vize { get; set; }
        public int? Final { get; set; }
    }
}
