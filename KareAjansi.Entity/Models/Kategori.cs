using KareAjansi.Entity.Base;
using KareAjansi.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.Entity.Models
{
    public class Kategori:BaseClass
    {
        //Property
        public string Ad { get; set; }

        //Relational Properties(Mapping)
        //Bir kategoride birden fazla manken olabilir.
        public virtual List<Manken> Mankenler { get; set; }
        public virtual List<Odeme> Odemeler { get; set; }
    }
}