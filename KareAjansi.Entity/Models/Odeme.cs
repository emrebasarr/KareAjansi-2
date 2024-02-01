using KareAjansi.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.Entity.Models
{
    public class Odeme : BaseClass
    {
        public string MankenAdi { get; set; }  
        public int GunSayisi { get; set; }
        public int KonaklamaUcreti { get; set; }
        public int YemekUcreti { get; set; }
        public int SirkettenAlinacakUcret {  get; set; }
        public int MankenSayisi {  get; set; }
        public bool Konum { get; set; }
        public int Odenecek { get; set; }
        public int Harcama { get; set; }
        public int Toplam { get; set; }
        public int Kar { get; set; }

        public int MankenId { get; set; }
        public int KategoriId { get; set; }
        public int OrganizasyonId { get; set; }

        // Navigation Properties (Mapping)
        public virtual Manken Manken { get; set; }
        public virtual Kategori Kategori { get; set; }

        // Bir odemenin bir Organizasyon içindir.
        public virtual Organizasyon Organizasyon { get; set; }


        //public void HesaplaOdeme()
        //{
        //    if (KategoriId == 1)
        //    {
        //        Odenecek = Organizasyon.GunSayisi * 40;
        //        Harcama = Organizasyon.GunSayisi * 10;
        //        Toplam = Odenecek + Harcama;
        //        Kar = Toplam;
        //    }
        //    else if (KategoriId == 2)
        //    {
        //        Odenecek = Organizasyon.GunSayisi * 100;
        //        Harcama = Organizasyon.GunSayisi * 10;
        //        Toplam = Odenecek + Harcama;
        //        Kar = Toplam;
        //    }
        //}
    }
}