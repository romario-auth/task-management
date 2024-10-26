namespace TaskManagement.Domain.Extensions
{
    public static class StringExtensions
    {
        public static void ValidateField(string field, string errorMessage, List<string> result)
        {
            if (string.IsNullOrEmpty(field))
            {
                result.Add(errorMessage);
            }
        }
    }
}
