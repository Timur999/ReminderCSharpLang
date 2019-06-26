using ReminderCSharpLang.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Animals
{
    abstract class Animal :IAnimal, IComparable
    {
        public string Name { get; }
        public float Weight { get; set; }
        public int Height { get; }
        public int Age { get; private set; }

        public Animal(string name, float weight, int height, int age)
        {
            Name = name;
            Weight = weight;
            Height = height;
            Age = age;
        }

        virtual public void Eat()
        {
            Console.WriteLine("It is eating");
        }

        public void Greed()
        {
            Console.WriteLine("Helo I am animal");
        }

        virtual public void Sleep()
        {
            Console.WriteLine("Animal sleeps");
        }

        //Note: This method comes from IComparable Interface and Sort() method from List<T> use it.
        virtual public int CompareTo(object o)
        {
            if (o is Animal)
            {
                return this.Age > (o as Animal).Age ? 1:0;
            }
            else
                return 0;
        }
    }
}
