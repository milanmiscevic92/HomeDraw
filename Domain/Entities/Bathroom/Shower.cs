using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Bathroom
{
    public class Shower
    {
        public int ShowerId { get; set; }

        public float ShowerWidthX { get; set; }
        public float ShowerWidthY { get; set; }

        public float ShowerPositionX { get; set; }
        public float ShowerPositionY { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
