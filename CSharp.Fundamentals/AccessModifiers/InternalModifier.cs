using System;

namespace CSharp.Fundamentals.AccessModifiers
{
    // First Project - CSharp Fundamentals
    public class InternalModifier
    {
        static void Main(string[] args)
        {
            GetClassInFirstProject num = new GetClassInFirstProject();
            Console.WriteLine(num.Number); // Can access the variable within its assembly
        }
    }
    public class GetClassInFirstProject
    {
        internal int Number = 10; // We can access this variable inside this class
    }
}
