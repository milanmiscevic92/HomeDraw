using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Concrete;
using Domain.Entities;
using Domain.Entities.Bathroom;
using Domain.Entities.ConstructionElements;
using Domain.Entities.Kitchen;
using Domain.Entities.LivingRoom;

namespace DAL.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        GenericRepository<Project> ProjectRepository { get; }
        GenericRepository<Bath> BathRepository { get; }
        GenericRepository<Lavatory> LavatoryRepository { get; }
        GenericRepository<Shower> ShowerRepository { get; }
        GenericRepository<Door> DoorRepository { get; }
        GenericRepository<Wall> WallRepository { get; }
        GenericRepository<Window> WindowRepository { get; }
        GenericRepository<Refrigerator> RefrigeratorRepository { get; }
        GenericRepository<Sink> SinkRepository { get; }
        GenericRepository<Stove> StoveRepository { get; }
        GenericRepository<Sofa> SofaRepository { get; }
        GenericRepository<Table> TableRepository { get; }
        GenericRepository<AppUser> UsersRepository { get; }
        void Save();

    }
}
