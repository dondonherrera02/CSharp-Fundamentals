using System;

namespace CSharp.Fundamentals.AccessModifiers
{
    public class PrivateModifier
    {
        static void Main(string[] args)
        {
            GetNumber num = new GetNumber();
            // Console.WriteLine(num.number); // The number variable can only be accessed within its class.
        }
    }

    public class GetNumber
    {
        private int number = 10;
    }
}
