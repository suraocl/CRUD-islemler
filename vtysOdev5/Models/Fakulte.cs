using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtysOdev5.Models
{
    public class Fakulte
    {
        public int FakulteID { get; set; }
        public string FakulteAd { get; set; }

        // İlişki: 1 Fakültenin birçok bölümü olabilir
        public virtual ICollection<Bolum> Bolumler { get; set; }
    }
}
