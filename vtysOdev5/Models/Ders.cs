using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtysOdev5.Models
{
    public class Ders
    {
        public int DersID { get; set; }
        public string DersAd { get; set; }

        public virtual ICollection<OgrenciDers> OgrenciDersler { get; set; }
    }
}
