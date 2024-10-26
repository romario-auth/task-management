using System.Xml.Linq;
using TaskManagement.Domain.Common;
using TaskManagement.Domain.Enum;
using TaskManagement.Domain.Extensions;

namespace TaskManagement.Domain.Entities
{
    public class WorkItem : EntityBase
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime DueDate { get; private set; }
        public StatusWorkItem StatusWorkItem { get; private set; }
        public Priority Priority { get; private set; }

        public WorkItem(string title, string description, DateTime dueDate, StatusWorkItem status, Priority priority)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            StatusWorkItem = status;
            Priority = priority;
        }

        public override List<string> Validate()
        {
            List<string> validationResult = new List<string>();

            StringExtensions.ValidateField(Description, "Description invalid", validationResult);

            return validationResult;
        }
    }
}
