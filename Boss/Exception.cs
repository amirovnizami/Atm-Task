
namespace Boss;

public class InvalidUserNameException : Exception
{
    public InvalidUserNameException() { }
    public InvalidUserNameException(string message) : base(message) { }
    public InvalidUserNameException(string message, Exception inner) : base(message, inner) { }
}

public class InvalidPasswordException : Exception
{
    public InvalidPasswordException() { }
    public InvalidPasswordException(string message) : base(message) { }
    public InvalidPasswordException(string message, Exception inner) : base(message, inner) { }
}

public class EmptyFieldException : Exception
{
    public EmptyFieldException() { }
    public EmptyFieldException(string message) : base(message) { }
    public EmptyFieldException(string message, Exception inner) : base(message, inner) { }
}
public class InvalidIdException : Exception
{
    public InvalidIdException() { }

    public InvalidIdException(string message) : base(message) { }
    public InvalidIdException(string message, Exception inner) : base(message, inner) { }

}