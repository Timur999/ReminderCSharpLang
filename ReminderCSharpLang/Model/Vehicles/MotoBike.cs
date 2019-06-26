using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Vehicles
{
    class MotoBike : Moto
    {
        public int TankValume { get; set; }
        public MotoBike(string _brand, string _model, float _engineCap, int _numDoors) : base(_brand, _model, _engineCap, _numDoors)
        {
            this.Brand = _brand;
            this.Model = _model;
            this.EngineCapacity = _engineCap;
            Console.WriteLine("MotoBike");
        }

        new public void MaxSpeed()
        {
            Console.WriteLine("I am motorbike");
        }

        virtual public void DisplayMotoBike() { }

        override public void StartEngine()
        {
            Console.WriteLine("MotoBike wrum wrum");
        }
    }
}
