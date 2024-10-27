using System.Xml.Linq;
using TaskManagement.Domain.Entities;
using Xunit;

namespace TaskManagement.Tests.Shared.Fixtures.Entities
{
    public class ProjectFixtures
    {
        private string _name = "Name";
        private WorkItem _workItem = WorkItemFixtures.New().Builder();
        public static ProjectFixtures New() => new ProjectFixtures();

        public Project Builder()
        {
            return new Project(_name, _workItem);
        }

        public ProjectFixtures WithName(string name)
        {
            _name = name;
            return this;
        }
    }
}
