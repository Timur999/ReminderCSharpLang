using ReminderCSharpLang.Model.Interfaces;
using ReminderCSharpLang.Model.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Animals
{
    class Human : Animal, IDriver
    {
        public Human(string name = "Tomek", float weight = 76.2f, int height = 182, int age = 27) : base(name, weight, height, age) { }

        public void TakeTheSeat(IVehicle vehicle)
        {
            vehicle.AddPassengerToList(this);
        }
    }
}
