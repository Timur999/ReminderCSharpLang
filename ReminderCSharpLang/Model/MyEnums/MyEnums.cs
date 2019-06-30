using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.MyEnums
{
    class MyEnums
    {
        private enum Days {Mon =1, Tue, Wed, Thu, Fri, Sat, Sun };

        static public void EnumDays()
        {
            //Days day = Days.Fri;
            Days day = (Days)5;

            //Throw exceptcion when value does not exist
            //Console.WriteLine(Enum.Parse(day.GetType(), "Tuew"));

            Days dayTue;
            Console.WriteLine(Enum.TryParse("Tue", out dayTue));
            Console.WriteLine(dayTue);

            //Return Mon
            Console.WriteLine(Enum.GetName(day.GetType(), 1));

            string value = Enum.GetName(typeof(Days), day);
            Console.WriteLine(value);

            //Return string array
            string[] values = Enum.GetNames(typeof(Days));
            foreach (string d in values)
                Console.WriteLine(d);

            //Return Days enum array
            Array valueEnum = Enum.GetValues(typeof(Days));
            foreach (var d in valueEnum)
                Console.WriteLine(d);

            //It checks is 'Tue' exist and return bool
            bool b = Enum.IsDefined(typeof(Days), "Tue");

            Console.WriteLine(b);
            Console.WriteLine(Enum.IsDefined(typeof(Days), "Tue"));

        }
    }
}
