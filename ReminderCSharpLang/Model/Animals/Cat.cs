using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Animals
{
    class Cat : Animal
    {
        public bool IsHungry { get; private set; }
        public Cat() : base("Shreder", 6.2f, 12, 2) { }

        override public void Eat()
        {
            base.Eat();
            IsHungry = true;
        }

        public void CatchAMice()
        {
            Console.WriteLine("Cats catches a mice");
        }

        //public override int CompareTo(object o)
        //{
        //    if (o is Cat)
        //    {
        //        return 1;
        //    }
        //    else
        //        return 0;
        //}
    }
}
