

using System;

namespace DO;

internal class ItemNotFoundException : Exception
{
    public ItemNotFoundException(string message)
        : base(message)
    {
        Console.WriteLine( message);
    }
}

internal class CustomerApperException : Exception
{
    public CustomerApperException(string message)
        : base(message)
    {
        Console.WriteLine(message);

    }
}
