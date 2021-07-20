using System;
namespace ApplicationCore.Exceptions
{
    public class ConflictException : Exception
    {
        public ConflictException(string message) : base(message)
        {

        }
    }
}