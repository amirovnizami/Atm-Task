namespace Hospital;

public class InvalidEmailException : Exception
{
    public InvalidEmailException() { }
    public InvalidEmailException(string message) : base(message) { }
    public InvalidEmailException(string message, Exception inner) : base(message, inner) { }
}

public class NotFoundException : Exception
{
    public NotFoundException() { }
    public NotFoundException(string message) : base(message) { }
    public NotFoundException(string message, Exception inner) : base(message, inner) { }
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
public class InvalidChoiceException : Exception
{
    public InvalidChoiceException() { }

    public InvalidChoiceException(string message) : base(message) { }
    public InvalidChoiceException(string message, Exception inner) : base(message, inner) { }

}
