using ReminderCSharpLang.Model.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Coordinate
{
    class Coordinates
    {
        public int y { get; private set; }
        public int x { get; private set; }
        public const string reference = "London";

        //NOTE: I created 2 classes whitch name is the same, so prefix of Vehicles.Car is a namespace not a Static Class
        //public readonly Vehicles.Car car = new Vehicles.Car("Ferrari", "Portofino", 3.855f, 2);

        public Coordinates()
        {
            this.x = 0;
            this.y = 0;
        }
        public Coordinates(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }

        public void SetCoordinates(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }

        public int IsItANumber(string value)
        {
            return Int32.Parse(value);
        }


    }
}
