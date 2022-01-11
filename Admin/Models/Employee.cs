using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    public class Employee: ModelAbstract
    {
        public Employee()
        {

        }

        [JsonProperty("IdЕmployee")]
        public override int Id { get; set; }
        public string Familiya { get; set; }
        public string Imiya { get; set; }
        public string Otchestvo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public long Inn { get; set; }
        public long Snils { get; set; }
        public string Gender { get; set; }
        public int? PostId { get; set; }
        public int? BranchId { get; set; }
        public int? UserId { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "Employees";
    }
}
