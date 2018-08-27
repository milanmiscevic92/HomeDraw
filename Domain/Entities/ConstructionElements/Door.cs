using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.ConstructionElements
{
    public class Door
    {
        public int DoorId { get; set; }

        public float DoorWidthX { get; set; }
        public float DoorWidthY { get; set; }

        public float DoorPositionX { get; set; }
        public float DoorPositionY { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
