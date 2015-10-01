using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AnimalInterface
{
    
    class Program
    {
        
       public static void Main(string[] args)
        {
            var name = new Bear();
            AnimalUtility.DoSomething(name);
            Debug.Assert(new Bear().Name == "Bear", "Bear isnt a bear :(");
            Console.ReadLine();
        }
        
    }
    interface INoisyAnimal : INoisy
    {
        string Name { get; }
    }
    interface INoisy
    {
        string MakeSound();
    }
    class AnimalUtility
    {
      public  static void DoSomething(INoisyAnimal a)
        {
            Console.WriteLine("{0} says\" {1}\"", a.Name, a.MakeSound());
        }
    }
    class Animal
    {
        public string Name { get; set; }

    }
    class Bear : Animal, INoisyAnimal
    { public Bear(){
        Name = "Bear";
            }
        public string MakeSound()
        { return "Roar"; }
    }
    class Chicken : Animal, INoisyAnimal
    {
        public Chicken()
        {
            Name = "Chicken";
        }
        public string MakeSound()
        { return "Cluck"; }
    }
    class Eagle :Animal, INoisyAnimal
        {
        public Eagle()
        {
            Name = "Eagle";
        }

        public string MakeSound()
            { return "Screee"; }
        }
    }

