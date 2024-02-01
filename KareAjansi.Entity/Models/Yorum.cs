using KareAjansi.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.Entity.Models
{
    public  class Yorum:BaseClass
    {
        //Property
        public string Yazari { get; set; }
        public string Yorumu { get; set; }
        public int MankenId { get; set; }

        //Relational Properties(Mapping)
        //Bir yorum bir Manken için
        public virtual Manken Manken { get; set; }
    }
}