using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    abstract class Animal
    {
        public abstract string Name { get; set;}

        public Animal(string name)
        {
            Name = name;
        }
        public abstract string Say();

        public string ShowInfo()
        {
            return $"{Name} \n{Say()}"; 
        }

    }
    class Cat : Animal
    {        
        private string name;
        public override string Name 
        { 
            get => name;
            set => name=value; 
        }
        public Cat (string name)
            :base(name)
        {
            
        }

        public override string Say()
        {
            return "Мяу";
        }
    }
    class Dog : Animal
    {
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Dog(string name)
            : base(name)
        {

        }

        public override string Say()
        {
            return "Гав";
        }
    }
}
