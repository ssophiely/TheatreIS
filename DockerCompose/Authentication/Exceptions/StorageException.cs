namespace Authentication.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException(string message) :
        base(message)
    { }
}

public class ExistsException : Exception
{
    public ExistsException(string message) :
        base(message)
    { }
}
