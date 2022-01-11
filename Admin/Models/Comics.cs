using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    public class Comics: ModelAbstract
    {
        public Comics()
        {

        }
        [JsonProperty("IdComics")]
        public override int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime DateShops { get; set; }
        public string Binding { get; set; }
        public int Pages { get; set; }
        public int Price { get; set; }
        public int? SkladId { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "Comics";
    }
}
