using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    public class Supplier : ModelAbstract
    {
        public Supplier()
        {

        }
        [JsonProperty("IdSupplier")]
        public override int Id { get; set; } = 0;
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        [JsonIgnore]
        public override string Path { get; set; } = "Suppliers";
    }
}
