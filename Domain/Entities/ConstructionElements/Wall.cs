using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.ConstructionElements
{
    public class Wall
    {
        public int WallId { get; set; }
        
        public float WallWidthX { get; set; }
        public float WallWidthY { get; set; }

        public float WallPositionX { get; set; }
        public float WallPostionY { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
