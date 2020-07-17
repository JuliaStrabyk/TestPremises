using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Premises.Entity
{
    public class Building
    {
        [Key]
        public Guid BuildingId { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "Длина строки должна быть больше {2} символов", MinimumLength = 1)]
        public string nameBuilding { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime? CreatedOn { get; set; }
        [Required]
        public bool IsEquipment { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public ICollection<Room> BuildingRoom { get; set; }
        public Building()
        {
            BuildingRoom = new List<Room>();
        }
    }
}
