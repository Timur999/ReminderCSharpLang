using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Delegates
{
    class FuncDelegates
    {
        public void DoSome(Func<int, string> func, int index)
        {
            string result = func(index);
            Console.WriteLine($"{result} is your pick");
        }
    }

    static class FootBallPlayers
    {
        static private List<string> _listOfPlayer;

        static FootBallPlayers()
        {
            _listOfPlayer = new List<string>()
            {
                "Ronaldo",
                "Zidane",
                "DelPiero",
                "Carlos",
                "Figo"
            };
        }

        static public string GetName(int index)
        {
            return _listOfPlayer[index];
        }
    }
}
