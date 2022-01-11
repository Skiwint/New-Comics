using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    public class Post: ModelAbstract
    {
        public Post()
        {

        }
        [JsonProperty("IdPost")]
        public override int Id { get; set; }
        public string Name { get; set; }
        public string Oklad { get; set; }
        public string Graph { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "Posts";
    }
}
