using System;

namespace CSharp_Polymorphism
{
    public class StaticPolymorphism
    {
        public void unknown()
        {
            System.Console.WriteLine("This is the unknown");
        }

        public void unknown(string greetings)
        {
            System.Console.WriteLine(greetings);
        }

        public void unknown(int number)
        {
            System.Console.WriteLine(number + " is a lucky number.");
        }
    }

    public interface DynamicPolymorphism
    {
        void display();
    }

    public class State1 : DynamicPolymorphism
    {
        public void display()
        {
            System.Console.WriteLine("This is in State1 but inherits from DynamicPolymorphism");
        }
    }

    public class State2 : DynamicPolymorphism
    {
        public void display()
        {
            System.Console.WriteLine("This is in State2 but inherits from DynamicPolymorphism");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StaticPolymorphism sp = new StaticPolymorphism();
            sp.unknown();
            sp.unknown("This is a string greetings parameters.");
            sp.unknown(7);

            DynamicPolymorphism state1 = new State1();
            state1.display();

            DynamicPolymorphism state2 = new State2();
            state2.display();
        }
    }
}
