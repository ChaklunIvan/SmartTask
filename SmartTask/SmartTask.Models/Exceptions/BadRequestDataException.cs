namespace SmartTask.Models.Exceptions
{
    public class BadRequestDataException : Exception
    {
        public BadRequestDataException(string message) : base(message) { }
    }
}
