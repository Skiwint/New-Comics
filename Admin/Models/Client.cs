using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    public class Client: ModelAbstract
    {
        public Client()
        {

        }
        [JsonProperty("IdClient")]
        public override int Id { get; set; }
        public string Fio { get; set; }
        public string Phone { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "Clients";
    }
}
