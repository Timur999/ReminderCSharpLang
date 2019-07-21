using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Comparer
{
    class ComparerString : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            //Note: this code sort arrary form 'z' to 'a'
            //x[0] < y[0] ? 1 : 0;
            return x.Length > y.Length ? 1 : 0;

        }
    }
}
