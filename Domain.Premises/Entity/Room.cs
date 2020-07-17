using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Premises.Entity
{
    public class Room
    {
        [Key]
        public Guid RoomId { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "Длина строки должна быть больше {2} символов", MinimumLength = 1)]
        public string nameRoom { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime? CreatedOn { get; set; }
        [Required]
        public bool IsEquipment { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public Guid BuildingId { get; set; }
        public Building Building { get; set; }
        public ICollection<Equipment> RoomEquipment { get; set; }
        public Room()
        {
            RoomEquipment = new List<Equipment>();
        }
    }
}
