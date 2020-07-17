using Domain.Premises.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Premises.DTO
{
    public class EquipmentDTO
    {
        public Guid EquipmentId { get; set; }
        public string NameEquipment { get; set; }
        public int CountEquipment { get; set; }
        public bool IsActive { get; set; }
        public Guid RoomId { get; set; }
        public Room Room { get; set; }
    }
}
