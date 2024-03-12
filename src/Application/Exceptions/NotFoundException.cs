

namespace Application.Exceptions
{
    public class NotFoundException:Exception
    {
        public NotFoundException():base()
        {

        }


        public NotFoundException(string message):base(message)
        {

        }


        public NotFoundException(string message, Exception InnerException):base(message, InnerException)
        {

        }


        public NotFoundException(string message, object key): base($"خطا در سیستم {key}")
        {

        }
    }
}
