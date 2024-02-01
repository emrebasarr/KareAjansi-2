using KareAjansi.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.Entity.Models
{
    public class Manken:BaseClass
    {
        //Property
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string AyakkabiNo { get; set; }
        public string Beden { get; set; }
        public string Kilo { get; set; }
        public string SacRengi { get; set; }
        public string GozRengi { get; set; }
        public bool SehirDisiCalisabilmeDurumu { get; set; }
        public bool Ehliyet { get; set; }
        public string YabanciDil { get; set; }
        public string Ozellik { get; set; }
        public string Cinsiyet { get; set; }
        public int KategoriId { get; set; }

        //Relational Properties(Mapping)

        //Bir Manken birden fazla Yorum Alabilir.
        public virtual List<Yorum> yorumlar { get; set; }

        //Bir Manken bir kategoride olur.    
        public virtual Kategori Kategori { get; set; }

        //Bir Manken sadece birden fazla Organizasyona katılabilir.
        public virtual List<OrganizasyonManken> OrganizasyonMankenler { get; set; }

        //Bir mankenin birden fazla odemesi olabilir
        public virtual List<Odeme> Odemeler { get; set; }
    }
}