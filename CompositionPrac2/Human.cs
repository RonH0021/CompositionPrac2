using System;

namespace CompositionPrac2
{
    public class Human
    {
        private readonly Animal _animal;
        private readonly Walkable _walkable;

        public Human(Animal animal,Walkable walkable)
        {
            _animal = animal;
            _walkable = walkable;
        }
        public void HumanActivity( string name)
        {
            _animal.Eat(name);
            _animal.Sleep(name);
            _walkable.Walk(name);
            Console.WriteLine("Humans can build");
        }
    }
}
