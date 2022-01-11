using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    public class Branch : ModelAbstract
    {
        public Branch()
        {

        }
        [JsonProperty("IdBranch")]
        public override int Id { get; set; }
        public string Adress { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "Branches";
    }
}
