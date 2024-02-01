using KareAjansi.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.BLL.DTOs
{
    public class OdemeDTO
    {
        public int Id { get; set; } 
        public string MankenAdi { get; set; }
        public int MankenId { get; set; }
        public int KategoriId { get; set; }
        public int OrganizasyonId { get; set; }
        public int GunSayisi { get; set; }
        public int KonaklamaUcreti { get; set; }
        public int YemekUcreti { get; set; }
        public int SirkettenAlinacakUcret { get; set; }
        public int MankenSayisi { get; set; }
        public bool Konum { get; set; }
        public int Odenecek { get; set; }
        public int Harcama { get; set; }
        public int Toplam { get; set; }
        public int Kar { get; set; }  
    }
}