using DAL.Infrastructure;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Bathroom;
using Domain.Entities.ConstructionElements;
using Domain.Entities.Kitchen;
using Domain.Entities.LivingRoom;
using DAL.Abstract;

namespace DAL.Concrete
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private HomeDrawDbContext context = new HomeDrawDbContext();

        private GenericRepository<AppUser> usersRepository;

        private GenericRepository<Project> projectRepository;

        private GenericRepository<Bath> bathRepository;
        private GenericRepository<Lavatory> lavatoryRepository;
        private GenericRepository<Shower> showerRepository;

        private GenericRepository<Door> doorRepository;
        private GenericRepository<Wall> wallRepository;
        private GenericRepository<Window> windowRepository;

        private GenericRepository<Refrigerator> refrigeratorRepository;
        private GenericRepository<Sink> sinkRepository;
        private GenericRepository<Stove> stoveRepository;

        private GenericRepository<Sofa> sofaRepository;
        private GenericRepository<Table> tableRepository;





        public GenericRepository<Project> ProjectRepository
        {
            get
            {
                if (this.projectRepository == null)
                {
                    this.projectRepository = new GenericRepository<Project>(context);
                }

                return projectRepository;
            }
        }

        public GenericRepository<Bath> BathRepository
        {
            get
            {
                if (this.bathRepository == null)
                {
                    this.bathRepository = new GenericRepository<Bath>(context);
                }

                return bathRepository;
            }
        }

        public GenericRepository<Lavatory> LavatoryRepository
        {
            get
            {
                if (this.lavatoryRepository == null)
                {
                    this.lavatoryRepository = new GenericRepository<Lavatory>(context);
                }

                return lavatoryRepository;
            }
        }

        public GenericRepository<Shower> ShowerRepository
        {
            get
            {
                if (this.showerRepository == null)
                {
                    this.showerRepository = new GenericRepository<Shower>(context);
                }

                return showerRepository;
            }
        }

        public GenericRepository<Door> DoorRepository
        {
            get
            {
                if (this.doorRepository == null)
                {
                    this.doorRepository = new GenericRepository<Door>(context);
                }

                return doorRepository;
            }
        }

        public GenericRepository<Wall> WallRepository
        {
            get
            {
                if (this.wallRepository == null)
                {
                    this.wallRepository = new GenericRepository<Wall>(context);
                }

                return wallRepository;
            }
        }

        public GenericRepository<Window> WindowRepository
        {
            get
            {
                if (this.windowRepository == null)
                {
                    this.windowRepository = new GenericRepository<Window>(context);
                }

                return windowRepository;
            }
        }

        public GenericRepository<Refrigerator> RefrigeratorRepository
        {
            get
            {
                if (this.refrigeratorRepository == null)
                {
                    this.refrigeratorRepository = new GenericRepository<Refrigerator>(context);
                }

                return refrigeratorRepository;
            }
        }

        public GenericRepository<Sink> SinkRepository
        {
            get
            {
                if (this.sinkRepository == null)
                {
                    this.sinkRepository = new GenericRepository<Sink>(context);
                }

                return sinkRepository;
            }
        }

        public GenericRepository<Stove> StoveRepository
        {
            get
            {
                if (this.stoveRepository == null)
                {
                    this.stoveRepository = new GenericRepository<Stove>(context);
                }

                return stoveRepository;
            }
        }

        public GenericRepository<Sofa> SofaRepository
        {
            get
            {
                if (this.sofaRepository == null)
                {
                    this.sofaRepository = new GenericRepository<Sofa>(context);
                }

                return sofaRepository;
            }
        }

        public GenericRepository<Table> TableRepository
        {
            get
            {
                if (this.tableRepository == null)
                {
                    this.tableRepository = new GenericRepository<Table>(context);
                }

                return tableRepository;
            }
        }

        

        public GenericRepository<AppUser> UsersRepository
        {
            get
            {
                if(this.usersRepository == null)
                {
                    this.usersRepository = new GenericRepository<AppUser>(context);
                }

                return usersRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();

        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    context.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
