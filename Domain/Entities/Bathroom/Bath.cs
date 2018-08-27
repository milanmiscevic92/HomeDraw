using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Domain.Entities.Bathroom
{
    public class Bath
    {
        [JsonProperty("bathId")]
        public int BathId { get; set; }

        [JsonProperty("bathSize")]
        public float BathSize { get; set; }

        [JsonProperty("left")]
        public float BathPositionX { get; set; }
        [JsonProperty("top")]
        public float BathPositionY { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
