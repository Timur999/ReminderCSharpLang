using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Structs
{
    //NOTE: Class instance is placed on the heap(sterta), struct object is placed on the stack (stos)
    struct Shoes
    {
        //NOTE: Property can not be initalize in this place. Property in classes can.
        //private string color = "Red";

        private string color;

        //NOTE: Structs has default contructor but if you declare your own constructor You have to initalize all properties in that place.
        public Shoes(string shoesColor)
        {
            color = shoesColor;
        }

        //NOTE: structs can not inherid from other class or strucs and class can not iherid from strucs.  But They support Interface
    }
}
