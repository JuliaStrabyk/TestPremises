using Domain.Premises.Entity;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Domain.Premises.EF
{
    public class PremisesContext:DbContext
    {
        public PremisesContext(string connectionString) : base(connectionString)
        {
        }
        //для миграции
#if DEBUG
        public class MigrationsContextFactory : IDbContextFactory<PremisesContext>
        {
            public PremisesContext Create()
            {
                return new PremisesContext("PremisesContext");
            }
        }
#endif

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Equipment> Equipments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Building>()
                .HasMany(m => m.BuildingRoom)
                .WithRequired(m => m.Building)
                .HasForeignKey(k => k.BuildingId)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<Room>()
                .HasMany(m => m.RoomEquipment)
                .WithOptional(m => m.Room)
                .HasForeignKey(k => k.RoomId)
                .WillCascadeOnDelete(true);
        }
    }
}
