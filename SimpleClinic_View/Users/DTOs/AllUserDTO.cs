using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClinic_View.Users.DTOs
{
    public class AllUserDTO
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public AllUserDTO(int id, int personId,string name, string userName, string password)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Name = name;
            PersonId = personId;
        }

    }
}
