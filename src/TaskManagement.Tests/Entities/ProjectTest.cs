using TaskManagement.Domain.Entities;
using TaskManagement.Tests.Shared.Fixtures.Entities;
using Xunit;

namespace TaskManagement.Tests.Entities
{
    public class ProjectTest
    {
        [Fact]
        public void IsProjectValid_ThenResultTrue()
        {
            // Arange
            Project project = ProjectFixtures.New().Builder();

            // Act
            var projectResult = project.IsValid();

            // Assert
            Assert.True(projectResult);
        }

        [Fact]
        public void IsNameProjectInValid_ThenResultError()
        {
            // Arange
            string name = "";
            string message = "Name invalid";
            Project project = ProjectFixtures.New().WithName(name).Builder();

            // Act
            var projectResult = project.Validate().FirstOrDefault();

            // Assert
            Assert.Equal(message, projectResult);
        }
    }
}
