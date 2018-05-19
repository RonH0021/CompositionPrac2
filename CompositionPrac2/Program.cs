using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionPrac2
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animal();
            var walk = new Walkable();

            var human = new Human(animal, walk);
            human.HumanActivity("John");
        }
    }
}
