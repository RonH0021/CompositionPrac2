using System;

namespace CompositionPrac2
{
    public class Animal
    {
        public int Age { get; set; }

        public void Eat(string name)
        {
            Console.WriteLine("The {0}, is eating", name);
        }
        public void Sleep(string name)
        {
            Console.WriteLine("The {0}, is sleeping", name);
        }
    }
}
