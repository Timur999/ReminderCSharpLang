using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Generic_And_Non_Generic_Collections
{
    class SomeCollections
    {
        static public void Collections()
        {
            //Note: Non-generics ArrayList, SortedList, Stack, Queue, Hashtable, BitArray.
            //Its not strong typing can generate error 
            ArrayList al = new ArrayList() { "Hello", 2 };

            //Note: Generics List<T>, Dictionary<TKey,TValue>, SortedList<TKey,TValue>, Stack<T>, Queue<T>, Hashset<T>.
            //Strong typing It can avoid error. Only desired data (ex. below is int) can be added to collection 
            List<int> li = new List<int>() { 1, 2 };

        }
    }
}
