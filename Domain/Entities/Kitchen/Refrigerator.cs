using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Kitchen
{
    public class Refrigerator
    {
        [JsonProperty("fridgeId")]
        public int RefrigeratorId { get; set; }

        [JsonProperty("fridgeSize")]
        public float RefrigeratorSize { get; set; }

        [JsonProperty("left")]
        public float RefrigeratorPositionX { get; set; }
        [JsonProperty("top")]
        public float RefrigeratorPositionY { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
