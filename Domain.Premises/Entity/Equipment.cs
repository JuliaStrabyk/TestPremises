using System;
using System.ComponentModel.DataAnnotations;


namespace Domain.Premises.Entity
{
    public class Equipment
    {
        [Key]
        public Guid EquipmentId { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "Длина строки должна быть больше {2} символов", MinimumLength = 1)]
        public string NameEquipment { get; set; }
        [Required]
        public int CountEquipment { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public Guid RoomId { get; set; }
        public Room Room { get; set; }
    }
}
