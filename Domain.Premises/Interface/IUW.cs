using System;
using Domain.Premises.Entity;


namespace Domain.Premises.Interface
{
    public interface IUW : IDisposable
    {
        //IRepository<Building> Buildings { get; }
        //IRepository<Room> Rooms { get; }
        IRepository<Equipment> Equipments { get; }
    }
}
