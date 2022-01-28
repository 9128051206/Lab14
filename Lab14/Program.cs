using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {           
            Cat cat = new Cat("Мурка");
            Console.WriteLine(cat.ShowInfo());
            Dog dog = new Dog("Шарик");
            Console.WriteLine(dog.ShowInfo());
            Console.ReadKey();
        }
    }
}
