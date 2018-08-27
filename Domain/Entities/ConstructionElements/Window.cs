using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.ConstructionElements
{
    public class Window
    {
        public int WindowId { get; set; }

        public float WindowWidthX { get; set; }
        public float WindowWidthY { get; set; }

        public float WindowPositionX { get; set; }
        public float WindowPositionY { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
