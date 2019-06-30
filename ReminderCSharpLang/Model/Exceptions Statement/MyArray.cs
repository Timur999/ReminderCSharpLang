using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Exceptions_Statement
{
    class MyArray
    {
        public static void OutOfArray()
        {
            //Exception handling
            int[] numbers = new int[2];

            try
            {
                numbers[0] = 23;
                numbers[1] = 32;
                numbers[2] = 42;

                foreach (int i in numbers)
                    Console.WriteLine(i);
            }
            //Note: First we add more specify Exceptions
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"An index was out of range! { ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Note: This block always executes. It good for close files or dispose object
            finally
            {

            }
        }
    }
}
