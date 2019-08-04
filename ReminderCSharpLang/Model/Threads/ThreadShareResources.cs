using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Threads
{
    public delegate void ChinaDelegate();
    class ThreadShareResources
    {
        //private static ChinaDelegate chinaDelegate = ChineRestaurant.MakeRise;
        Thread thread;
        Thread thread2;
        Thread thread3;

        public void executeDelegate(object threadNumber)
        {
            ChinaDelegate chinaDelegate = ChineRestaurant.MakeRise;
            if((int)threadNumber == 2)
            {
                chinaDelegate -= ChineRestaurant.MakeRise;
            }
            chinaDelegate += ChineRestaurant.EateRise;
            chinaDelegate += ChineRestaurant.PayForRise;
            chinaDelegate.Invoke();
        }

        public void Run()
        {
            thread = new Thread(executeDelegate);
            thread2 = new Thread(executeDelegate);
            thread3 = new Thread(executeDelegate);

            thread.Start(1);
            thread2.Start(2);
            thread3.Start(3);
        }
    }

    public static class ChineRestaurant
    {
        public static void MakeRise()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Jeb Jeb Rise to Wather");
        }
        public static void EateRise()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Jami Jami Rise");
        }
        public static void PayForRise()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Sayomara");
        }

    }
}
