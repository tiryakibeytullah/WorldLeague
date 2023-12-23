namespace WorldLeague.API.Exceptions
{
    public class NotFoundTeamException : Exception
    {
        public NotFoundTeamException() : base("Göndermiş olduğunuz değere göre bir Takım bulunmamaktadır.")
        {
        }

        public NotFoundTeamException(string? message) : base(message)
        {
        }

        public NotFoundTeamException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
