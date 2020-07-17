using Domain.Premises.EF;
using Domain.Premises.Entity;
using Domain.Premises.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Premises.Repository
{
    public class RoomRepository:IRepository<Room>
    {
            private PremisesContext db;

            public RoomRepository(PremisesContext context)
            {
                this.db = context;
            }

            public async Task<IEnumerable<Room>> GetAllAsync()
            {
                var res = await db.Rooms.AsNoTracking().ToListAsync();
                return res;
            }
            public async Task<Room> GetAsync(Guid id)
            {
                if (id == Guid.Empty)
                {
                    return new Room();
                }

                return await db.Rooms.FirstOrDefaultAsync(c => c.BuildingId == id);
            }
            public void Create(Room item)
            {
                if (item != null) db.Rooms.Add(item);
            }

            public void Update(Room item)
            {
                if (item != null) db.Entry(item).State = EntityState.Modified;
            }

            public async Task Delete(Guid id)
            {
                var val = await db.Rooms.FirstOrDefaultAsync(x => x.BuildingId == id);
                if (val != null) db.Rooms.Remove(val);
            }
        }
}
