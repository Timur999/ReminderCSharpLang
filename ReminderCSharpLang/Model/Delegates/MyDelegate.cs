using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Delegates
{
    public class MyDelegate
    {
        public delegate int PerformeCalculateDelegate(int x, int y);
        private PerformeCalculateDelegate performeCalculateDelegate;
        public MyDelegate(int c, int d)
        {
            performeCalculateDelegate = new PerformeCalculateDelegate(Calculator.AddIntiger);
            if (c > 3)
            {
                AddMethodToDelagate();
            }
            if (d < 3)
            {
                SubMethodToDelagate();
            }
            int result = 0;
            for (int i = 0; i < 5; i++)
            {
                result += performeCalculateDelegate(c, d);
            }
            Console.WriteLine($"performeCalculateDelegate value is {result}");
        }

        public void AddMethodToDelagate()
        {
            performeCalculateDelegate += Calculator.AddIntiger;
        }
        public void SubMethodToDelagate()
        {
            performeCalculateDelegate -= Calculator.AddIntiger;
        }
    }

    public class Calculator
    {
        public static int AddIntiger(int a, int b)
        {
            return a + b;
        }
        public int SubIntiger(int a, int b)
        {
            return a - b;
        }
    }
}
