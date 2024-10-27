using TaskManagement.Domain.Common;
using TaskManagement.Domain.Extensions;

namespace TaskManagement.Domain.Entities
{
    public class Project : EntityBase
    {
        public string Name { get; private set; }

        public Project(string name)
        {
            Name = name;
        }

        public override List<string> Validate()
        {
            List<string> validationResult = new List<string>();

            StringExtensions.ValidateField(Name, "Name invalid", validationResult);

            return validationResult;
        }
    }
}
