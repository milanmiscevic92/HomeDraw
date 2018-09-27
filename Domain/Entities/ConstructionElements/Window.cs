using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.ConstructionElements
{
    public class Window
    {
        [JsonProperty("windowId")]
        public int WindowId { get; set; }

        [JsonProperty("windowSize")]
        public float WindowSize { get; set; }

        [JsonProperty("left")]
        public float WindowPositionX { get; set; }
        [JsonProperty("top")]
        public float WindowPositionY { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
