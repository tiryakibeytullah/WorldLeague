namespace WorldLeague.API.Exceptions
{
    public class NotFoundCountryException : Exception
    {
        public NotFoundCountryException() : base("Göndermiş olduğunuz değere göre bir Ülke bulunmamaktadır.")
        {
        }

        public NotFoundCountryException(string? message) : base(message)
        {
        }

        public NotFoundCountryException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
