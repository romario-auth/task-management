namespace TaskManagement.Domain.Exceptions
{
    public class TaskManagementException : Exception
    {
        public TaskManagementException(string message) : base(message) { }
    }
}
