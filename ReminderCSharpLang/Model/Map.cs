using ReminderCSharpLang.Model.Coordinate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model
{
    static class Map
    {
        static public Dictionary<int, Coordinates> ListCoordinatesOfVehicle = new Dictionary<int, Coordinates>();
        static public readonly object mapListCoordinatesLock = new object();
    }
}
