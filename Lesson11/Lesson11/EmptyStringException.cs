
namespace Lesson11
{
    [Serializable]
    internal class EmptyStringException : Exception
    {
        public EmptyStringException()
        {
        }

        public EmptyStringException(string? message) : base(message)
        {
        }

        public EmptyStringException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}