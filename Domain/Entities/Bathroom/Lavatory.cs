using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Bathroom
{
    public class Lavatory
    {
        [JsonProperty("lavatoryId")]
        public int LavatoryId { get; set; }

        [JsonProperty("lavatorySize")]
        public float LavatorySize { get; set; }

        [JsonProperty("left")]
        public float LavatoryPositionX { get; set; }
        [JsonProperty("top")]
        public float LavatoryPositionY { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
