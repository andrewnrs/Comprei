using Comprei.Model.Entities.DefaultEntity;
using System.ComponentModel.DataAnnotations;

namespace Comprei.Model.Entities
{
    public class Customer : Entity
    {
        public Customer() { }

        public Customer(string name, string login, string password, string houseNickname)
        {
            Name = name;
            Login = login;
            Password = password;
            House = new House() { Nickname = houseNickname };
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
