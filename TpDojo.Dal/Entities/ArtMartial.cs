using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpDojo.Dal.Entities
{
    public class ArtMartial : ADataObject
    {
        public string Nom { get; set; }
        public List<Samourai> Samourais { get; set; }
    }

}
