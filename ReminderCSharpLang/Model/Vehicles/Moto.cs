using ReminderCSharpLang.Model.Animals;
using ReminderCSharpLang.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Vehicles
{

    class Moto : Vehicle, IPetrol
    {
        public static Moto Current { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public float EngineCapacity { get; set; }

        public Moto(string _motoBrand, string _model, float _engineCap, int _numDoors) : base(_numDoors)
        {
            this.Brand = _motoBrand;
            this.Model = _model;
            this.EngineCapacity = _engineCap;
            Console.WriteLine("Moto");
        }

        public Moto() : base(0)
        {
            this.Brand = "Kawasaki";
            this.Model = "Ninja";
            this.EngineCapacity = 1.0f;
            this._numberOfSeats = 2;
        }

        override public bool AddPassengerToList(Animal animal)
        {
            if (this._listOfPassengers.Count < _numberOfSeats)
            {
                this._listOfPassengers.Add(animal);
                return true;
            }
            return false;
        }

        override public void MaxSpeed()
        {
            Console.WriteLine("320");
        }

        override public void StartEngine()
        {
            Console.WriteLine("Moto wrum wrum");
        }

        public void RefuelWithPetrol()
        {
            Console.WriteLine("Refuel With Petrol: {0} {1}", this.Brand, this.Model);
        }
    }
}
