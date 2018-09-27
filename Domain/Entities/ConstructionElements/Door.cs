using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.ConstructionElements
{
    public class Door
    {
        [JsonProperty("doorId")]
        public int DoorId { get; set; }

        [JsonProperty("doorSize")]
        public float DoorSize { get; set; }

        [JsonProperty("left")]
        public float DoorPositionX { get; set; }
        [JsonProperty("top")]
        public float DoorPositionY { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
