using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.LivingRoom
{
    public class Sofa
    {
        public int SofaId { get; set; }
        
        public float SofaWidthX { get; set; }
        public float SofaWidthY { get; set; }

        public float SofaPositionX { get; set; }
        public float SofaPositionY { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
