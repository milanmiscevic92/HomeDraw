using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Kitchen
{
    public class Sink
    {
        [JsonProperty("sinkId")]
        public int SinkId { get; set; }

        [JsonProperty("sinkSize")]
        public float SinkSize { get; set; }

        [JsonProperty("left")]
        public float SinkPositionX { get; set; }
        [JsonProperty("top")]
        public float SinkPositionY { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
