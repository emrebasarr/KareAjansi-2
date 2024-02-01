using KareAjansi.Entity.Enums;
using KareAjansi.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.Entity.Base
{
    public abstract class BaseClass : IEntity
    {
      public BaseClass() 
      {
        CreatedDate = DateTime.Now;
        Status = DataStatus.Active;
      }

        public int Id { get; set; }
        public DataStatus Status { get ; set ; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedComputerName { get; set ; }
        public string CreatedIpAddress { get; set ; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedComputerName { get; set; }
        public string? UpdatedIpAddress { get; set; }
    }
}