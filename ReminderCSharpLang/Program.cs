using ReminderCSharpLang.Model.Vehicles;
using System;
using ReminderCSharpLang.Model.Vehicles.ExtensionMethods;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ReminderCSharpLang.Model.Coordinate;
using ReminderCSharpLang.Model.Animals;
using System.Collections;
using ReminderCSharpLang.Model.Interfaces;
using ReminderCSharpLang.Model.Managers;
using ReminderCSharpLang.Model.Comparer;
using System.IO;
using System.Xml;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Globalization;
using ReminderCSharpLang.Model.User;
using ReminderCSharpLang.Model.Culture;
using ReminderCSharpLang.Model.MyEnums;
using ReminderCSharpLang.Model.Exceptions_Statement;
using ReminderCSharpLang.Model.Delegates;
using ReminderCSharpLang.Model.Generic;
using ReminderCSharpLang.Model.Threads;

namespace ReminderCSharpLang
{
    public enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    class Program
    {
        static void DisplayDot()
        {
            for(int i = 0; i < 100; i++)
            {
                Console.Write('.');
            }
        }

        static string DisplayType(decimal money)
        {
            return string.Format("{0} zl",money.ToString("N"));
        }

        static bool isTheSame(Car a, Car b)
        {
            return a == b;
        }
        static void OutRefMethod(out int o, ref int r)
        {
            o = 0;
        }

        static void Main(string[] args)
        {
            //Coordinates.reference = "Wolsztyn";
            //Console.WriteLine($"My car {Coordinates.car.CarBrand}  {Coordinates.car.Model} is in {Coordinates.reference}");

            //int x = 1;
            //while (x != 0)
            //{
            //    Console.WriteLine($"Enter your favorite number: ");
            //    try
            //    {
            //        x = Coordinates.IsItANumber(Console.ReadLine());
            //       // x = Int32.Parse(Console.ReadLine());
            //    }
            //    catch (AccessViolationException e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }

            //    Console.WriteLine($"nYour namber is {x}");
            //}


            ////List<Thread> ThreadList = new List<Thread>();
            ////for (int t = 0; t < 20; t++)
            ////{
            ////    Vehicle car = new Car(new Coordinates(t, t), t + 1);
            ////    ThreadList.Add(new Thread(new ThreadStart(car.Move)));
            ////}
            ////Thread.Sleep(1000);
            ////Console.Clear();
            ////foreach (Thread t in ThreadList)
            ////{
            ////    t.Start();
            ////    //t.Join();
            ////}

            // Vehicle car = new Car();

            // Thread oThread = new Thread(new ThreadStart(car.RunDelegateStartMachine));
            //oThread.Start();
            //oThread.Join();



            //car.RunDelegateStartMachine();

            //car.StartEngine();
            //Car.DelegateStart delegateStart = new Car.DelegateStart(car.StartEngine);
            //delegateStart += () => { car.SpecifyLocations(); };
            //delegateStart += car.MarkYourPlaceOnTheMap;
            //delegateStart.Invoke();

            //int i = 0;
            //while (i < 10)
            //{
            //    Thread.Sleep(1000);

            //    //car.Move();
            //    i++;
            //}

            //Console.WriteLine(car.GetCoordinates());
            //car.StopEngine();

            //Thread dot = new Thread(new ThreadStart(DisplayDot));

            //dot.Start();
            //dot.Join();

            //Console.WriteLine("Thread stops");

            //
            //decimal m = 10.2352M;
            //Console.WriteLine(DisplayType(m));

            //
            //Vehicle c = new Car();
            //Vehicle moto = new Moto("Yamaha", "F1", 1, 0);
            //moto = c;
            //moto.MaxSpeed();

            //
            //Vehicle.DelegateStartMachine d = new Vehicle.DelegateStartMachine(() => { Console.WriteLine("d start"); }) ;
            //d += () => { Console.WriteLine("d stop"); };
            //d.Invoke();

            //
            //Car vehicle = new Car(new Moto());
            //vehicle.StartEngine();
            //Car c = (Car)vehicle;
            //c.Petrol.RefuelWithPetrol();

            //Human human = new Human();
            //Human human2 = new Human("Halina");
            //Human human3 = new Human("Renatka");
            //Dog dog = new Dog();
            //Dog dog2 = new Dog();
            //Cat cat = new Cat();

            //
            // c.ListOfPassager.Add(human);
            // c.ListOfPassager.Add(human2);
            // c.ListOfPassager.Add(human3);
            // c.ListOfPassager.Add(dog);
            // c.ListOfPassager.Add(dog2);
            //// c.ListOfPassager.Add(cat);

            //c.arrayOfPassagers[0] = human;
            // c.arrayOfPassagers[1] = human2;
            // c.arrayOfPassagers[2] = human3;
            // c.arrayOfPassagers[3] = dog;
            // c.arrayOfPassagers[4] = dog2;
            //// c.arrayOfPassagers[5] = cat;

            ///
            //c.ListOfPass.Add(human);
            //c.ListOfPass.Add(human2);
            //c.ListOfPass.Add(human3);
            //c.ListOfPass.Add(dog);
            //c.ListOfPass.Add(dog2);
            //c.ListOfPass.Add(cat);

            //
            //c.AddPassengerToList(human);
            //c.AddPassengerToList(human2);
            //c.AddPassengerToList(human3);
            //c.AddPassengerToList(dog);
            //c.AddPassengerToList(dog2);
            //c.AddPassengerToList(cat);
            //c.AddPassengerToList(cat);

            //
            //human.TakeTheSeat(c);
            //human2.TakeTheSeat(c);
            //human3.TakeTheSeat(c);
            ////dog.TakeTheSeat(c);
            ////dog2.TakeTheSeat(c);
            //human.TakeTheSeat(c);

            //foreach (Animal a in c.GetListOfPassengers())
            //{
            //    Console.WriteLine(a.Name);
            //}

            //foreach (string s in c.GetListOfPassengersDetails())
            //{
            //    Console.WriteLine(s);
            //}

            //
            //c.GetPassengersByName("Tomek");

            //
            //Car a = new Car(new Moto());
            //Console.WriteLine(isTheSame(c, a));


            AnimalManager animalManager = new AnimalManager();

            animalManager.CreateDog();
            animalManager.CreateCat();
            animalManager.CreateDog();
            //animalManager.SortAnimalByAge();
            //
            //List<Animal> animals = animalManager.GetAnimals() as List<Animal>;

            //animalManager.FeedTheAnimal(animals.FirstOrDefault());
            //animalManager.GreedCat(animals.FirstOrDefault() as Cat);

            //Arrarys
            //string[] arr = { "Grarzyna", "Renata", "Halina", "Ala " };

            //Array.Sort(arr, new ComparerString());

            //foreach (string a in arr)
            //{
            //    Console.WriteLine(a);
            //}

            ////Lists
            //List<string> listOfString = new List<string>() { "Grarzyna", "Renata", "Halina", "Ala " };
            //listOfString.Sort(CompareString);

            ////Dictionaries
            //Dictionary<string, int> dictionary = new Dictionary<string, int>() { { "Grarzyna", 22 }, { "Renata", 12 }, { "Halina", 44 }, { "Ala ", 18 } };

            //dictionary.OrderBy(u => u.Value);

            //foreach (KeyValuePair<string, int> user in dictionary)
            //{
            //    Console.WriteLine(user.Key + user.Value);
            //}

            //// Types
            //int val = 2;
            //bool isAdult = Convert.ToBoolean(val);
            //Console.WriteLine("Bool: " + isAdult.ToString());
            //Console.WriteLine("Int: " + Convert.ToInt32(isAdult).ToString());

            //string s = Convert.ToString(val);


            //Console.WriteLine($"unsigned decimal = {animalManager.d}");

            //Char c = ' ';

            //if(c == null)
            //{
            //    Console.WriteLine($"{c} is null");
            //}


            //DateTime
            ////var usCulture = new System.Globalization.CultureInfo("en-US");
            //DateTime dt = new DateTime(2042, 1, 24, 18, 42, 0);
            //DateTime date = dt.Date;
            //Console.WriteLine(dt.ToShortTimeString());
            ////Console.WriteLine(dt.ToString("dddd  hh: mm tt"));
            ////Console.WriteLine(System.Globalization.CultureInfo.InvariantCulture.DisplayName);


            //var usCulture = new System.Globalization.CultureInfo("pl-PL");
            ////Console.WriteLine("Please specify a date. Format: " + usCulture.DateTimeFormat.ShortDatePattern);
            //string dateString = Console.ReadLine();
            ////DateTime userDate = DateTime.Parse(dateString, new System.Globalization.CultureInfo("pl-PL").DateTimeFormat);
            ////Console.WriteLine("Date entered (long date format):" + userDate.ToString(usCulture.DateTimeFormat));

            //DateTime userDate2;
            //if (DateTime.TryParse(dateString, usCulture.DateTimeFormat, System.Globalization.DateTimeStyles.None, out userDate2)) {
            //    Console.WriteLine("Date :" + userDate2.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("it is not date :" + dateString);
            //}

            //Nullable
            //int? a = 10;
            //a.HasValue();


            //Var type
            //var v = 11;
            //Console.WriteLine(v);
            //v = "elevent";
            //Console.WriteLine(v);


            ////Dynamic type
            //dynamic Amount;
            //Amount = 11;
            //Console.WriteLine(Amount);
            //Amount = "elevent";
            //Console.WriteLine(Amount);
            //dynamic user = new
            //{
            //    Name="Tomek",
            //    Age= 27
            //};
            //Console.WriteLine(user.ToString());

            //dynamic user = new System.Dynamic.ExpandoObject();
            //user.Name = "Tomek";
            //user.Age = 27;
            //user.HomeTown = new System.Dynamic.ExpandoObject();
            //user.HomeTown.Name = "New York";
            //user.DescribeUser = (Func<string>)(() => { return user.Name + " " + user.Age + " " + user.HomeTown.Name; }) ;

            //foreach (KeyValuePair<string, object> kvp in user)
            //{
            //    Console.WriteLine(kvp.Key +" " + kvp.Value);
            //}

            //String Format
            //double daysSinceMillenium = (DateTime.Now - new DateTime(2000, 1, 1)).TotalDays;
            //Console.WriteLine($"Today is {DateTime.Now:F} and {daysSinceMillenium:N2} days have passed since the last millennium!");


            //            var o = @"[{
            //  'Brand': 'Intel',
            //  'Model': 'Intel',
            //  'EngineCapacity': '1'},
            //{
            // 'Brand': 'AMD',
            //  'Model': 'AMD',
            //  'EngineCapacity': '2'
            //}]";

            //            var list = JsonConvert.DeserializeObject<List<dynamic>>(o);
            //            Console.WriteLine(list.Where(x => x.Brand == "AMD").FirstOrDefault());

            //            Console.WriteLine(o);


            //            List<string> videogames = new List<string>
            //{
            //    "Starcraft",
            //    "Halo",
            //    "Legend of Zelda"
            //};

            //            string json = JsonConvert.SerializeObject(videogames);

            //            string isStarcraft = videogames.Where(g => g == "Starcraft").First();

            //            Console.WriteLine(isStarcraft);



            //CultureInfo And RegionInfo

            //Culture.DisplayAllCurrencySymbolInTheWorld();
            //Culture.RegionInfoMethods("pl-PL");
            //Culture.ListOfCountryWithRegioCountry();

            //Enums
            //MyEnums.EnumDays();

            //Exceptions
            //MyArray.OutOfArray();

            //generic
            //SomeGeneric.SwapExecute();
            //SomeGeneric.DisplayMultipleGenericExecute();

            //Delegates
            //MyDelegate myDelegate = new MyDelegate(4,3);

            //reference
            //Car car = new Car("Opel", "Astra", 3, 3);
            //EngineChange(car);
            //Console.WriteLine(car.EngineCapacity);

            //Thread And Delagate
            //ThreadShareResources threadShareResources = new ThreadShareResources();
            //threadShareResources.Run();

            //Callbacks
            //Cook cook = new Cook();

            ////Func Delegare
            //FuncDelegates func = new FuncDelegates();
            //func.DoSome(FootBallPlayers.GetName, 2);
            //func.DoSome((int a) => { return "Saviola " + a; }, 2);

            ////Action delegate
            //Car car = new Car("Opel", "Vectra", 3f, 4);
            //Action<string> action = car.CarInfo;
            //action += Console.WriteLine;
            //action("Opyl");

            //Arrays
            Dictionary<string, int> FightActionList = new Dictionary<string, int> { { "Hit", 1 }, { "Avoid", 2}, {"Spell",3 }, {"Defence", 4} };
            FightActionList.Add("status", 1);


            foreach(var  KeyValuePair)

            Console.ReadLine();
        }

        ////Lists
        //public static int CompareString(string user1, string user2)
        //{
        //    return user1.CompareTo(user2);
        //}

        //References
        static void EngineChange(Car car)
        {
            car.EngineCapacity = 10;
        }

        public void Dodaj(int l1, int l2) { Console.WriteLine(l1 + l2); }
        public void Odejmij(int l1, int l2) { Console.WriteLine(l1 - l2); }

    }
    public delegate void Dzialanie(int x, int y);

    public class Matma
    {
        public void Dodaj(int l1, int l2) { Console.WriteLine(l1 + l2); }
        public void Odejmij(int l1, int l2) { Console.WriteLine(l1 - l2); }
    }

}
