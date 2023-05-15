using Comprei.Model.Entities.DefaultEntity;
using System.ComponentModel.DataAnnotations;

namespace Comprei.Model.Entities
{
    public class User : Entity
    {
        public User() { }

        public User(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
        }

        [StringLength(120, MinimumLength = 3)]
        public string Name { get; set; }

        [StringLength(120, MinimumLength = 3)]
        public string Login { get; set; }

        [StringLength(36, MinimumLength = 3)]
        public string Password { get; set; }

        public string? Picture { get; set; }

        public House? House { get; set; }
    }
}
