using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Bathroom
{
    public class Shower
    {
        [JsonProperty("showerId")]
        public int ShowerId { get; set; }

        [JsonProperty("showerSize")]
        public float ShowerSize { get; set; }

        [JsonProperty("left")]
        public float ShowerPositionX { get; set; }
        [JsonProperty("top")]
        public float ShowerPositionY { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
