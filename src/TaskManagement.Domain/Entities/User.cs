using TaskManagement.Domain.Common;
using TaskManagement.Domain.Extensions;

namespace TaskManagement.Domain.Entities
{
    public class User : EntityBase
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }

        public User(string name, string lastName, string email)
        {
            Name = name;
            LastName = lastName;
            Email = email;
        }

        public override List<string> Validate()
        {
            List<string> validationResult = new List<string>();

            StringExtensions.ValidateField(Name, "Name invalid", validationResult);
            StringExtensions.ValidateField(LastName, "Last Name invalid", validationResult);
            StringExtensions.ValidateField(Email, "Email invalid", validationResult);

            return validationResult;
        }
    }
}
