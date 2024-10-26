using TaskManagement.Domain.Exceptions;

namespace TaskManagement.Domain.Common
{
    public abstract class EntityBase
    {
        public Guid Id { get; protected set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsValid() => Validate().Count == 0;
        public abstract List<string> Validate();
        public void SetCreate()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetUpdated()
        {
            UpdatedAt = DateTime.UtcNow;
        }

        public void ValidateEntities()
        {
            if (!IsValid())
                throw new TaskManagementException(String.Join(", ", Validate().ToArray()));
        }
    }
}
