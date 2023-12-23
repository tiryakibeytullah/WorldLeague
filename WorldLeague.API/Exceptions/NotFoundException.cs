﻿namespace WorldLeague.API.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException() : base("İlgili nesne bulunamadı !")
        {
        }

        public NotFoundException(string? message) : base(message)
        {
        }

        public NotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
