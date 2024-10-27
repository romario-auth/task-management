using TaskManagement.Domain.Common;
using TaskManagement.Domain.Extensions;

namespace TaskManagement.Domain.Entities
{
    public class Project : EntityBase
    {
        public string Name { get; private set; }
        public WorkItem WorkItem { get; private set; }

        public Project(string name, WorkItem workItem)
        {
            Name = name;
            WorkItem = workItem;
        }

        public override List<string> Validate()
        {
            List<string> validationResult = new List<string>();

            StringExtensions.ValidateField(Name, "Name invalid", validationResult);

            return validationResult;
        }
    }
}
