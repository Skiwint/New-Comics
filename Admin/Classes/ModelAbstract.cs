using Newtonsoft.Json;

namespace Admin
{
    public abstract class ModelAbstract
    {
        public abstract int Id { get; set; }

        public abstract string Path { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
