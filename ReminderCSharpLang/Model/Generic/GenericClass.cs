using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Generic
{
    class GenericClass<T>
    {
        public int index;
        public T someThing;

        public GenericClass(T some, int idx)
        {

        }
    }

    class Executed
    {
        GenericClass<int> genericClass = new GenericClass<int>(12, 11);
    }


}
