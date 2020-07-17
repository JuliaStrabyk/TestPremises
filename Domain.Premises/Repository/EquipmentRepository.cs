using Domain.Premises.EF;
using Domain.Premises.Entity;
using Domain.Premises.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Domain.Premises.Repository
{
   public class EqipmentRepository:IRepository<Equipment>
    {
        private PremisesContext db;
        private EqipmentRepository eqipmentRepository;
        public EqipmentRepository(PremisesContext context)
        {
            this.db = context;
        }
        public async Task<IEnumerable<Equipment>> GetAllAsync()
        {
            var res = await db.Equipments.AsNoTracking().ToListAsync();
            return res;
        }
        public async Task<Equipment> GetAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                return new Equipment();
            }

            return await db.Equipments.FirstOrDefaultAsync(c => c.EquipmentId == id);
        }
        public void Create(Equipment item)
        {
            if (item != null) db.Equipments.Add(item);
        }

        public void Update(Equipment item)
        {
            if (item != null) db.Entry(item).State = EntityState.Modified;
        }

        public async Task Delete(Guid id)
        {
            var val = await db.Equipments.FirstOrDefaultAsync(x => x.EquipmentId == id);
            if (val != null) db.Equipments.Remove(val);
        }
    }
}
