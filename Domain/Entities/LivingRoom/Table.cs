using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Domain.Entities.LivingRoom
{
    public class Table
    {
        [JsonProperty("tableId")]
        public int TableId { get; set; }

        [JsonProperty("tableSize")]
        public float TableSize { get; set; }

        [JsonProperty("left")]
        public float TablePositionX { get; set; }
        [JsonProperty("top")]
        public float TablePositionY { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
