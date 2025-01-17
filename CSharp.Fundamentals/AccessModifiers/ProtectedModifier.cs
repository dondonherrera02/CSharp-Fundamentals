using System;

namespace CSharp.Fundamentals.AccessModifiers
{
    public class ProtectedModifier
    {
        static void Main(string[] args)
        {
            void Display()
            {
                ParentClass num = new ParentClass();
                //Console.WriteLine(num.number); // Cannot access because the ProtectedModifier class does not inherit from the ParentClass.
            }
        }
    }

    class ParentClass
    {
        protected int number = 10; // We can access this variable inside this class.
    }

    class ChildClass : ParentClass
    {
        void Display()
        {
            Console.WriteLine(number); // We can access it in this class as well because it inherits from the ParentClass.
        }
    }
}
