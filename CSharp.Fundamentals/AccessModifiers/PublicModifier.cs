using System;

namespace CSharp.Fundamentals.AccessModifiers
{
    public class PublicModifier
    {
        static void Main(string[] args)
        {
            var num = new GetNumber();
            Console.WriteLine(num.Number); // Can access because its modifier is public
        }

        class GetNumber
        {
            public int Number = 10;
        }
    }
}
