using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Domain.Entities.Kitchen
{
    public class Stove
    {
        [JsonProperty("stoveId")]
        public int StoveId { get; set; }

        [JsonProperty("stoveSize")]
        public float StoveSize { get; set; }

        [JsonProperty("left")]
        public float StovePositionX { get; set; }
        [JsonProperty("top")]
        public float StovePositionY { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
