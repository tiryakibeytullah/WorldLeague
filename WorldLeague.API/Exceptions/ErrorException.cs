namespace WorldLeague.API.Exceptions
{
    public class ErrorException
    {
        public string ErrorTitle { get; set; }
        public int StatusCode { get; set; }
        public List<string> ErrorMessages { get; set; }
        public ErrorException()
        {
            ErrorMessages = new List<string>();
        }
    }
}
