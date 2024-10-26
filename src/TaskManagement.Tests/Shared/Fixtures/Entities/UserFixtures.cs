using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Tests.Shared.Fixtures.Entities
{
    public class UserFixtures
    {
        private string _name = "Name";
        private string _lastName = "LastName";
        private string _email = "Email";

        public static UserFixtures New() => new UserFixtures();

        public User Builder()
        {

            return new User(_name, _lastName, _email);
        }

        public UserFixtures WithName(string name)
        {
            _name = name;
            return this;
        }

        public UserFixtures WithLastName(string lastname)
        {
            _lastName = lastname;
            return this;
        }
        public UserFixtures WithEmail(string email)
        {
            _email = email;
            return this;
        }
    }
}