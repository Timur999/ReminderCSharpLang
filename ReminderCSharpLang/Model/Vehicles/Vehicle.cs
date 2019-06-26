using ReminderCSharpLang.Model.Animals;
using ReminderCSharpLang.Model.Coordinate;
using ReminderCSharpLang.Model.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Vehicles
{

    interface IDrive
    {
        bool CheckIsMoveSave();
        void RandomDirection();
    }
    abstract class Vehicle : IVehicle, IDrive
    {
        public static List<int> IdVehicles = new List<int>();
        public int Id { get; private set; }
        public const int NumberOfWheels = 4;
        private Coordinates Co_ordinates { get; set; }
        public int NumberOfDoors { get; set; }
        private int _directionX;
        private int _directionY;
        public bool _isSaveToMove { get; private set; }
        //private ArrayList listOfPassager = new ArrayList();
        //public ArrayList ListOfPassager
        //{
        //    get
        //    {
        //        if (listOfPassager.Count < 5)
        //        {
        //            return listOfPassager;
        //        }
        //        return null;
        //    }
        //    set
        //    {
        //        if (listOfPassager.Count < 5)
        //        {
        //            listOfPassager.Add(value);
        //        }
        //    }
        //}

        //public object[] arrayOfPassagers = new object[5];

        protected List<Animal> _listOfPassengers;

        protected int _numberOfSeats;

        public delegate void DelegateStartMachine();
        private DelegateStartMachine delegateStartMachine;

        public Vehicle(int _numDoors)
        {
            this.NumberOfDoors = _numDoors;
            this.Id = IdVehicles.Count + 1;
            IdVehicles.Add(this.Id);
            delegateStartMachine += StartEngine;
            delegateStartMachine += () => { SpecifyLocations(); };
            delegateStartMachine += MarkYourPlaceOnTheMap;
            RunDelegateStartMachine();
            Console.WriteLine("Vehicle");

            this._listOfPassengers = new List<Animal>();
        }
        public Vehicle(int _numDoors, Coordinates _Co_ordinates)
        {
            this.NumberOfDoors = _numDoors;
            this.Id = IdVehicles.Count + 1;
            IdVehicles.Add(this.Id);
            delegateStartMachine += StartEngine;
            delegateStartMachine += () => { SpecifyLocations(_Co_ordinates); };
            delegateStartMachine += MarkYourPlaceOnTheMap;
            RunDelegateStartMachine();
            Console.WriteLine("Vehicle");

            this._listOfPassengers = new List<Animal>();
        }

        abstract public bool AddPassengerToList(Animal animal);

        public IEnumerable<Animal> GetListOfPassengers()
        {
            return _listOfPassengers;
        }

        public Animal GetPassengersByName(string name)
        {

            //NOTE:: Distinct removes repeating elements
            return _listOfPassengers.Distinct().Single(x=> x.Name == name);
        }

        public IEnumerable<string> GetListOfPassengersDetails()
        {
            IList<string> _listOfPassengersDetail = new List<string>();
            foreach (Animal a in _listOfPassengers)
            {
                int counter = 0;
                string _PassengersDetail = a.Name + "|" + a.Weight + "|" + a.Height + "|" + a.Age;
                _listOfPassengersDetail.Add(_PassengersDetail);
                foreach (string s in _listOfPassengersDetail)
                {
                    if (s == _PassengersDetail )
                    {
                        if (s == _PassengersDetail && counter == 1)
                        {
                            _listOfPassengersDetail.Remove(_PassengersDetail);
                            break;
                        }
                        counter++;
                    }
                }
            }

            //NOTE: alternative way
            //_listOfPassengers.Select(x => string.Format("{0} | {1} | {2} | {3}", x.Name, x.Weight, x.Height, x.Age)).Distinct();
            return _listOfPassengersDetail;
        }
        abstract public void MaxSpeed();

        virtual public void StartEngine()
        {
            Console.WriteLine("Wlozenie kluczyka do stacyjki");
            Console.WriteLine("Przekrecenie kluczyka");
            Console.WriteLine("Silnik uruchomiony");
        }

        public void StopEngine()
        {
            Console.WriteLine("StopVehicle");
        }

        virtual public void SpecifyLocations(Coordinates c = null)
        {
            Console.WriteLine("Specify Locations Process");
            this.Co_ordinates = c != null ? c : new Coordinates();
        }

        public void MarkYourPlaceOnTheMap()
        {
            lock (Map.mapListCoordinatesLock)
            {
                Map.ListCoordinatesOfVehicle.Add(Id, Co_ordinates);
            }
        }

        public void UpdateCoordiatesOnMap()
        {
            Coordinates coordinates = Map.ListCoordinatesOfVehicle.Where(c => c.Key == this.Id).Select(c => c.Value).FirstOrDefault();

            if (coordinates != null)
            {
                Map.ListCoordinatesOfVehicle[this.Id] = this.Co_ordinates;
            }
        }

        virtual public void Move()
        {
            RandomDirection();
            lock (Map.mapListCoordinatesLock)
            {
                _isSaveToMove = CheckIsMoveSave();
            }

            if (_isSaveToMove)
            {
                Console.SetCursorPosition(this.Co_ordinates.x, this.Co_ordinates.y);
                Console.Write(" ");
                Co_ordinates.SetCoordinates(this.Co_ordinates.x + _directionX, this.Co_ordinates.y + _directionY);
                Console.SetCursorPosition(this.Co_ordinates.x, this.Co_ordinates.y);
                //Console.CursorVisible = false;

                //TODO: updates coordinates everytime coordiates are changes. Maybe It shoud be creates some evenet or use delegate

                UpdateCoordiatesOnMap();
            }
        }

        public bool CheckIsMoveSave()
        {
            if (this.Co_ordinates.x + _directionX > 119 || this.Co_ordinates.x + _directionX < 0
                || this.Co_ordinates.y + _directionY > Console.LargestWindowHeight || this.Co_ordinates.y + _directionY < 0)
                return false;

            return Map.ListCoordinatesOfVehicle.
                Where(c => c.Value.x == this.Co_ordinates.x + _directionX && c.Value.y == this.Co_ordinates.y + _directionY).FirstOrDefault().Key == 0 ? true : false;
        }

        public void RandomDirection()
        {
            Random random = new Random();
            _directionX = random.Next(-1, 2);
            _directionY = random.Next(-1, 2);
        }

        public Coordinates GetCoordinates()
        {
            return Co_ordinates;
        }

        public void AddCallback(DelegateStartMachine function)
        {
            delegateStartMachine += function;
        }

        public void RunDelegateStartMachine()
        {
            delegateStartMachine.Invoke();
        }


    }

}
