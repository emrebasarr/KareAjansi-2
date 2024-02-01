using KareAjansi.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.Entity.Models
{
    public class OrganizasyonManken:BaseClass
    {
        //Property
        public int OrganizasyonId { get; set; }
        public int MankenId { get; set; }
        public DateTime KatilmaTarihi { get; set; }

        //Relational Properties(Mapping)
        public virtual Organizasyon Organizasyon { get; set; }
        public virtual Manken Manken { get; set; }
    }
}