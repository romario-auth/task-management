using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Enums;

namespace TaskManagement.Tests.Shared.Fixtures.Entities
{
    public class WorkItemFixtures
    {

        private string _title = "Task one";
        private string _description = "I am happy with this task";
        private DateTime _dueDate = DateTime.Now.AddDays(10);
        private StatusWorkItem _statusWorkItem = StatusWorkItem.Progress;
        private Priority _priority = Priority.Low;

        public static WorkItemFixtures New() => new WorkItemFixtures();

        public WorkItem Builder()
        {
            return new WorkItem(_title, _description, _dueDate, _statusWorkItem, _priority) { };
        }

        public WorkItemFixtures WithDescription(string description)
        {
            _description = description;
            return this;
        }
    }
}
