using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Premises.Interface;
using System.Threading.Tasks;
using Domain.Premises.Entity;
using Domain.Premises.EF;
using System.Data.Entity;

namespace Domain.Premises.Repository
{
    public class BuildingRepository : IRepository<Building>
    {
        private PremisesContext db;

        public BuildingRepository(PremisesContext context)
        {
            this.db = context;
        }

        public async Task<IEnumerable<Building>> GetAllAsync()
        {
            var res = await db.Buildings.AsNoTracking().ToListAsync();
            return res;
        }
        public async Task<Building> GetAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                return new Building();
            }

            return await db.Buildings.FirstOrDefaultAsync(c => c.BuildingId == id);
        }
        public void Create(Building item)
        {
            if (item != null) db.Buildings.Add(item);
        }

        public void Update(Building item)
        {
            if (item != null) db.Entry(item).State = EntityState.Modified;
        }

        public async Task Delete(Guid id)
        {
            var val = await db.Buildings.FirstOrDefaultAsync(x => x.BuildingId == id);
            if (val != null) db.Buildings.Remove(val);
        }
    }
}
