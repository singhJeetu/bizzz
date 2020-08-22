using System;
public class ExUserDef : Exception
{
    public ExUserDef(String message)
        : base(message)
    {

    }
}
public class TestUserDefinedException
{
    static void validate(int age)
    {
        if (age < 18)
        {
            throw new ExUserDef("Sorry, Age must be greater than 18");
        }
    }
    public static void Main(string[] args)
    {
        try
        {
            validate(12);
        }
        catch (ExUserDef e)
        {
            Console.WriteLine(e);
        }
        Console.WriteLine("Rest of the code");
    }
}