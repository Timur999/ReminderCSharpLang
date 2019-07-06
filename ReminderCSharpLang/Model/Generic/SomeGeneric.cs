using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Generic
{
    class SomeGeneric
    {
        static private void Swap<T>(ref T a, ref T b)
        {
            T temp = b;
            b = a;
            a = temp;
        }

        static public void SwapExecute()
        {
            int a = 10;
            int b = 1;
            Console.WriteLine($"a = {a}, b = {b}");
            Swap<int>(ref a, ref b);
            Console.WriteLine($"a = {a}, b = {b}");
            string s1 = "Hello";
            string s2 = "World";
            Console.WriteLine($"s1 = {s1}, s2 = {s2}");
            Swap<string>(ref s1, ref s2);
            Console.WriteLine($"s1 = {s1}, s2 = {s2}");
            Swap(ref s1, ref s2);
            Console.WriteLine($"s1 = {s1}, s2 = {s2}");
        }

        //Note: Underline two different varieble
        static private void DisplayMultipleGeneric<T, U>(T a,  U b)
        {
            Console.WriteLine($"a = {a} is {a.GetType()}, b = {b} is {b.GetType()}");
        }

        static public void DisplayMultipleGenericExecute()
        {
            DisplayMultipleGeneric("Hello", 47);
        }

    }
}
