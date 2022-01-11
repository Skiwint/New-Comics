using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    public class Sklad: ModelAbstract
    {
        public Sklad()
        {

        }
        [JsonProperty("IdSklad")]
        public override int Id { get; set; }
        public string Adress { get; set; }
        public string Capacity { get; set; }
        public string Phone { get; set; }
        public int? SupplierId { get; set; }
        [JsonIgnore]
        public override string Path { get; set; } = "Sklads";
    }
}
