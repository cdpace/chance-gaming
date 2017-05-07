using System;
using System.Collections.Generic;
using System.Text;

namespace ChanceGaming.Api.Model.Entities.Users
{
    public abstract class User : BaseEntity<Guid>
    {
        public User()
        {
            Id = Guid.NewGuid();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
