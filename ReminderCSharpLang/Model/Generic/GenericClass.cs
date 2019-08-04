
namespace ReminderCSharpLang.Model.Generic
{
    class GenericClass<T>
    {
        public int index;
        public T someThing;

        public GenericClass(int idx, T some )
        {
            this.index = idx;
            this.someThing = some;
        }
    }

    class Executed
    {
        GenericClass<int> genericClass = new GenericClass<int>(12, 11);
    }
}
