using cGisDashboard.Enums;
using System.Text.Json.Serialization;

namespace cGisDashboard.Entities
{
    public class User: BaseEntity
    {

        public string FirstName { get; set; } = String.Empty;

        public string LastName { get; set; } = String.Empty;

        public string UserName { get; set; } = String.Empty;

        [JsonIgnore]
        public string Password { get; set; } = String.Empty;

        public TypeUser Type { get; set; }
    }
}
