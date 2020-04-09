using Data;
using Helper;
using System;
using System.Threading;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CLIENT");
            ITest test = WcfClient<ITest>.Channel("http://127.0.0.1:8080/bilgeadam");

            while (true)
            {
                var serverData = test.GetServerTime();
                Console.WriteLine(serverData);

                Thread.Sleep(1000);

            }

            Console.ReadLine();
        }
    }
}
