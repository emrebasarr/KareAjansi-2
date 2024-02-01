using KareAjansi.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.Entity.Interfaces
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DataStatus Status { get; set; }

        //Created
        public DateTime? CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIpAddress { get; set; }

        //Updated
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedComputerName { get; set; }
        public string? UpdatedIpAddress { get; set; }
    }
}