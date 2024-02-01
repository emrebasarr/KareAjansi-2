using KareAjansi.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.BLL.DTOs
{
    public class YorumDTO
    {
        public int Id { get; set; }
        public string Yazari { get; set; }
        public string Yorumu { get; set; }
        public int MankenId { get; set; }
    }
}