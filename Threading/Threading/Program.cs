using System;
using System.Threading;
namespace Threading
{
    class Program
    {
        private static readonly Object locker = new object();
        public static SemaphoreSlim SemaphoreSlim = new SemaphoreSlim(6);
        static void Main(string[] args)
        {
            
            

            Console.WriteLine("Threading!");

            //new Thread(Process1).Start();

            //new Thread(Process2).Start();

            new Thread(BirTanesinSen).Start(1);
            new Thread(BirTanesinSen).Start(2);
            new Thread(BirTanesinSen).Start(3);
            new Thread(BirTanesinSen).Start(4);
            new Thread(BirTanesinSen).Start(5);


            Console.WriteLine("MAIN THREAD: Bekliyorum");


            //Console.WriteLine("Otoparka hoşgeldiniz.!");

            //for (int i = 1; i <= 10; i++)
            //{
            //    new Thread(EnterThePark).Start(i);
                
            //}

            Console.ReadLine();

        }

        public static void BirTanesinSen(Object id)
        {
            Console.WriteLine("THREAD : " + id);
            lock (locker)
            {
                Console.WriteLine(id + "BirTanesinSen started!");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(id + "TUR: " + i);
                    Thread.Sleep(1000);
                }
            }
            

            Console.WriteLine(id +"BirTanesinSen end!");
        }

        //public static void Process1()
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Thread 1: İŞLEM 1" + DateTime.Now.Ticks);
        //        Thread.Sleep(600);
        //        Console.WriteLine("Thread 1: İŞLEM 2" + DateTime.Now.Ticks);
        //        Thread.Sleep(700);
        //        Console.WriteLine("Thread 1: İŞLEM 3" + DateTime.Now.Ticks);
        //        Thread.Sleep(1000);
        //    }
        //}public static void Process2()
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Thread 2: İŞLEM 1" + DateTime.Now.Ticks);
        //        Thread.Sleep(600);
        //        Console.WriteLine("Thread 2: İŞLEM 2" + DateTime.Now.Ticks);
        //        Thread.Sleep(700);
        //        Console.WriteLine("Thread 2: İŞLEM 3" + DateTime.Now.Ticks);
        //        Thread.Sleep(1000);
        //    }
        //}

        //public static void EnterThePark(object id)
        //{
        //    Console.WriteLine(id + " kuyrukta.");
        //    SemaphoreSlim.Wait();
        //    Console.WriteLine(id + " park etii.");
        //    Thread.Sleep(1000 * (int) id);
        //    Console.WriteLine(id + " ayrılıyor.");
        //    SemaphoreSlim.Release();
        //}
    }
}
