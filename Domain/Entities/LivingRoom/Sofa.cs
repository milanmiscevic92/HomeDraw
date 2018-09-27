using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Domain.Entities.LivingRoom
{
    public class Sofa
    {
        [JsonProperty("sofaId")]
        public int SofaId { get; set; }

        [JsonProperty("sofaSize")]
        public float SofaSize { get; set; }

        [JsonProperty("left")]
        public float SofaPositionX { get; set; }
        [JsonProperty("top")]
        public float SofaPositionY { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
