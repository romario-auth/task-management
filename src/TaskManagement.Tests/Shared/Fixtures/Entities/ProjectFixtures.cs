using System.Xml.Linq;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Tests.Shared.Fixtures.Entities
{
    public class ProjectFixtures
    {
        private string _name = "Name";
        private List<WorkItem> _workItems = new List<WorkItem>() { WorkItemFixtures.New().Builder() };
        public static ProjectFixtures New() => new ProjectFixtures();

        public Project Builder()
        {
            return new Project(_name, _workItems);
        }

        public ProjectFixtures WithName(string name)
        {
            _name = name;
            return this;
        }
    }
}
