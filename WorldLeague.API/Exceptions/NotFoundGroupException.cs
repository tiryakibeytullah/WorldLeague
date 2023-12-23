namespace WorldLeague.API.Exceptions
{
    public class NotFoundGroupException : Exception
    {
        public NotFoundGroupException() : base("Göndermiş olduğunuz değere göre bir Grup bulunmamaktadır.")
        {
        }

        public NotFoundGroupException(string? message) : base(message)
        {
        }

        public NotFoundGroupException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
