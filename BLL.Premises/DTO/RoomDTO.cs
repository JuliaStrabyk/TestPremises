using Domain.Premises.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Premises.DTO
{
    public class RoomDTO
    {
        public Guid RoomId { get; set; }
       public string nameRoom { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool IsEquipment { get; set; }
        public bool IsActive { get; set; }
        public Guid BuildingId { get; set; }
        public Building Building { get; set; }
        public ICollection<Equipment> RoomEquipment { get; set; }
        public RoomDTO()
        {
            RoomEquipment = new List<Equipment>();
        }
    }
}
