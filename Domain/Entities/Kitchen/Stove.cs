using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Kitchen
{
    public class Stove
    {
        public int StoveId { get; set; }
        
        public float StoveWidthX { get; set; }
        public float StoveWidthY { get; set; }

        public float StovePositionX { get; set; }
        public float StovePositionY { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
