using Domain.Premises.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Premises.DTO
{
    public class BuildingDTO
    {
        public Guid BuildingId { get; set; }
        public string nameBuilding { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool IsEquipment { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Room> BuildingRoom { get; set; }
        public BuildingDTO()
        {
            BuildingRoom = new List<Room>();
        }
    }
}
