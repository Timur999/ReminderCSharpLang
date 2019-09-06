using ReminderCSharpLang.Model.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Switch
{
    class CarMechanic
    {
        public void Repair(Vehicle v)
        {
            switch (v)
            {
                case Car car when v.GetType() == typeof(Car):
                    Console.WriteLine(typeof(Car) + " Reapired");
                    break;

                case Moto moto when v.GetType() == typeof(Moto):
                    Console.WriteLine(typeof(Moto) + " Reapired");
                    break;
            }
        }

        public void ShowVechicleType(Vehicle v)
        {
            Console.WriteLine(v.GetType());
            Console.WriteLine(v.GetType() == typeof(Car));
            Console.WriteLine(typeof(Car));

        }
    }
}
