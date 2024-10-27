using TaskManagement.Domain.Entities;
using TaskManagement.Tests.Shared.Fixtures.Entities;
using Xunit;

namespace TaskManagement.Tests.Entities
{
    public class WorkItemTest
    {
        [Fact]
        public void IsWorkItemValid_ThenResultTrue()
        {
            // Arange
            WorkItem workItem = WorkItemFixtures.New().Builder();

            // Act
            var workItemResult = workItem.IsValid();

            // Assert
            Assert.True(workItemResult);
        }

        [Fact]
        public void IsDescribeWorkItemValid_ThenReturnError()
        {
            // Arange
            string description = "";
            string message = "Description invalid";
            WorkItem workItem = WorkItemFixtures.New().WithDescription(description).Builder();

            // Act
            var workItemResult = workItem.Validate().FirstOrDefault();

            // Assert
            Assert.Equal(message, workItemResult);
        }
    }
}