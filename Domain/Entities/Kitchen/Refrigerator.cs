using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Kitchen
{
    public class Refrigerator
    {
        public int RefrigeratorId { get; set; }

        public float RefrigeratorWidthX { get; set; }
        public float RefrigeratorWidthY { get; set; }

        public float RefrigeratorPositionX { get; set; }
        public float RefrigeratorPositionY { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
