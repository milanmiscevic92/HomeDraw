using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Kitchen
{
    public class Sink
    {
        public int SinkId { get; set; }

        public float SinkWidthX { get; set; }
        public float SinkWidthY { get; set; }

        public float SinkPositionX { get; set; }
        public float SinkPositionY { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
