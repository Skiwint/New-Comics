using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    public class Sale: ModelAbstract
    {
        public Sale()
        {

        }
        [JsonProperty("IdSales")]
        public override int Id { get; set; }
        public int? ComicsId { get; set; }
        public int? ClientId { get; set; }
        public DateTime Date { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "Sales";
    }
}
