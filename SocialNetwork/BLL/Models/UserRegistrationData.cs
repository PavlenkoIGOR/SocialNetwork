using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * здесь будут находиться все свойства, необходимые для регистрации пользователя
 */ 
namespace SocialNetwork.BLL.Models
{
    public class UserRegistrationData
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
    }
}
