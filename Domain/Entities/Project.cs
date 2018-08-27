using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Bathroom;
using Domain.Entities.ConstructionElements;
using Domain.Entities.Kitchen;
using Domain.Entities.LivingRoom;

namespace Domain.Entities
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectOwnerId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }


        // Users participating in a project
        public virtual ICollection<AppUser> Participants { get; set; }

        // Plan elements
        public virtual ICollection<Bath> Baths { get; set; }
        public virtual ICollection<Lavatory> Lavatories { get; set; }
        public virtual ICollection<Shower> Showers { get; set; }
        public virtual ICollection<Door> Doors { get; set; }
        public virtual ICollection<Wall> Walls { get; set; }
        public virtual ICollection<Window> Windows { get; set; }
        public virtual ICollection<Refrigerator> Refrigerators { get; set; }
        public virtual ICollection<Sink> Sinks { get; set; }
        public virtual ICollection<Stove> Stoves { get; set; }
        public virtual ICollection<Sofa> Sofas { get; set; }
        public virtual ICollection<Table> Tables { get; set; }


        // Methods

        
    }
}
