using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.LivingRoom
{
    public class Table
    {
        public int TableId { get; set; }

        public float TableWidthX { get; set; }
        public float TableWidthY { get; set; }

        public float TablePositionX { get; set; }
        public float TablePositionY { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
