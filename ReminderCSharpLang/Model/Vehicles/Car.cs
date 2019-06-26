using ReminderCSharpLang.Model.Animals;
using ReminderCSharpLang.Model.Coordinate;
using ReminderCSharpLang.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Vehicles
{
    class Car : Vehicle
    {
        public string CarBrand { get; set; }
        public string Model { get; set; }
        public float EngineCapacity { get; set; }
        private int IdCar { get; set; }

        public IPetrol Petrol;

        public Car(string _carBrand, string _model, float _engineCap, int _numDoors) : base(_numDoors)
        {
            this.CarBrand = _carBrand;
            this.Model = _model;
            this.EngineCapacity = _engineCap;
            Console.WriteLine("Car");
        }

        public Car(IPetrol petrol) : base(2, new Coordinates(10, 20))
        {
            this.CarBrand = "Ferrari";
            this.Model = "Portofino";
            this.EngineCapacity = 4.8f;
            this.Petrol = petrol;
            this._numberOfSeats = 5;
            Console.WriteLine("CAR");
            this.NumberOfDoors = 4;
        }

        public Car(Coordinates c, int id) : base(2, c)
        {
            this.CarBrand = "Ferrari";
            this.Model = "Portofino";
            this.EngineCapacity = 4.8f;
            this.IdCar = id;
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
            Console.WriteLine("300");
        }

        override public void StartEngine()
        {
            base.StartEngine();
            Console.WriteLine("car wrum wrum");
        }

        new public void StopEngine()
        {
            base.StopEngine();
            Console.WriteLine("StopCar");
        }

        override public void Move()
        {
            while (true)
            {
                Thread.Sleep(400);
                lock (Map.mapListCoordinatesLock)
                {
                    base.Move();
                    if (_isSaveToMove)
                        Console.Write("C");
                }
            }
        }
    }
}
