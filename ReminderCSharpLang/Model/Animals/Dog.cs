using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Animals
{
    class Dog : Animal
    {
        public Dog() : base("Reksio", 7.2f, 18, 7) { }

        public void ChaseACat()
        {
            Console.WriteLine("Dogs chasing a cats");
        }

        public override void Eat()
        {
            base.Eat();
        }
    }
}
