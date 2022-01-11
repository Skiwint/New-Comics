using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    public class BranchForSklad: ModelAbstract
    {
        public BranchForSklad()
        {

        }

        [JsonProperty("IdBfs")]
        public override int Id { get; set; }
        public int? SkladId { get; set; }
        public int? BranchId { get; set; }
        [JsonIgnore]
        public override string Path { get; set; } = "BranchForSklads";
    }
}
