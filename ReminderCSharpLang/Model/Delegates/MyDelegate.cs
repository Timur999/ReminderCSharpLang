using System;

namespace ReminderCSharpLang.Model.Delegates
{
    public class MyDelegate
    {
        public delegate int PerformeCalculateDelegate(int x, int y);
        public MyDelegate(int c, int d)
        {
            PerformeCalculateDelegate performeCalculateDelegate = new PerformeCalculateDelegate(AddIntiger);
            if (c > 3)
            {
                AddMethodToDelagate();
            }
            if (d < 3)
            {
                SubMethodToDelagate();
            }
            int resuult;
            for (int i = 0; i > 5; i++)
            {
                resuult = performeCalculateDelegate(c, d);
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
