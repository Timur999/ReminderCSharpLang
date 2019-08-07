using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Delegates
{
    public class Callbacks
    {
        public delegate void BakeCakeDelegate(string ingredient);

        private BakeCakeDelegate _bakeCakeDelegate;

        public void AddCallback(BakeCakeDelegate method)
        {
            _bakeCakeDelegate += method;
        }

        public void BakeCake(string ingredient)
        {
            _bakeCakeDelegate(ingredient);
            Console.WriteLine("Bake ");
        }
    }

    class Cook
    {
        Callbacks callbacks = new Callbacks();

        public Cook()
        {
            callbacks.AddCallback(AddIngredient);
            callbacks.AddCallback(MixIngredient);
            callbacks.BakeCake("Jajko");
        }

        public void AddIngredient(string ingredient)
        {
            Console.WriteLine("Added " + ingredient);
        }

        public void MixIngredient(string ingredient)
        {
            Console.WriteLine("Mixed " + ingredient);
        }
    }

    class GenericDelegate
    {
        public delegate void BakeCakeDelegate<T>(T ingredient);

        private BakeCakeDelegate<int> _bakeCakeDelegate;
        //private BakeCakeDelegate<float> _bakeCakeDelegate;
        public void AddCallback()
        {

        }
        public void BakeCake(BakeCakeDelegate<int> bakeCake)
        {
            bakeCake.Invoke(1);
        }
    }
}
