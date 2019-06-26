using ReminderCSharpLang.Model.Animals;
using ReminderCSharpLang.Model.Comparer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Managers
{
    class AnimalManager
    {
        private List<Animal> _animals;
        public AnimalManager()
        {
            this._animals = new List<Animal>();
        }
        public void CreateCat()
        {
            this._animals.Add(new Cat());
        }
        public void CreateDog()
        {
            this._animals.Add(new Dog());
        }

        public IEnumerable<Animal> GetAnimals()
        {
            return _animals;
        }

        public void FeedTheAnimal(Animal animal)
        {
            //NOTE: Eat method is a virtaul method
            animal.Eat();
        }

        public void PerformCharacteristicTaskForSpecifyObject(Animal animal)
        {
            //NOTE: When I want to invoke non-virtaul or non-abstract Method. I have to use if or switch statements to define what exacly animal is.
            if(animal is Cat)
            {
                (animal as Cat).CatchAMice();
            }else if(animal is Dog)
            {
                (animal as Dog).ChaseACat();
            }
        }

        public void GreedCat(Cat cat)
        {
            cat.Greed();
        }

        public void SortAnimalByAge()
        {
            if (_animals.Any())
            {
                _animals.Sort(new ComparerAnimalByName());
                foreach(Animal animal in _animals)
                {
                    Console.WriteLine($"Name: {animal.Name} is {animal.Age}");
                }
            }
        }
    }
}
