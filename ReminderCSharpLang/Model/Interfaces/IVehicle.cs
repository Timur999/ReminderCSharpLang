using ReminderCSharpLang.Model.Animals;
using ReminderCSharpLang.Model.Coordinate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Interfaces
{
    interface IVehicle
    {
        void StartEngine();
        void SpecifyLocations(Coordinates c);
        void Move();
        bool AddPassengerToList(Animal animal);
    }
}
