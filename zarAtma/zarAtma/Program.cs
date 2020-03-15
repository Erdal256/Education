using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ZarAtma
{
    class Program
    {

        public static int pCount = 0;
        public static void Main(string[] args)
        {
            Console.WriteLine("Oyuncu sayısı");
            pCount = Convert.ToInt32(Console.ReadLine());

            new Thread(Referee).Start();




            for (int i = 0; i < pCount; i++)
            {
                new Thread(Roll).Start(i);
                rollStats.Add(new RollStat()
                {
                    Id = i,
                    Value = 0,
                    Count = 0
                });

            }
        }

        public class RollStat
        {
            public int Id { get; set; }
            public int Count { get; set; }
            public int Value { get; set; }

        }

        private static bool CancelThreads = false;
        private static Random _random = new Random();
        private static List<RollStat> rollStats = new List<RollStat>();
      

        private static void Roll(object id)
        {
            while (true)
            {
                if(CancelThreads)
                {
                    break;
                }

                var selfStat = rollStats.Single(a => a.Id == (int)id);

                if (selfStat.Count < rollStats.OrderByDescending(a => a.Count).First().Count
                    || rollStats.Count(a => a.Count == selfStat.Count) == pCount)   // 3
                {
                    int result = _random.Next(1, 10);
                    selfStat.Count++;
                    selfStat.Value = selfStat.Value + result;
                }


                Thread.Sleep(1000);
            }
        }
        private static void Referee()
        {
            int turn = 0;
            while (true)
            {
                if (rollStats.Count(a => a.Count == turn) == pCount)  // 3
                {
                    string stats = string.Empty;

                    foreach (RollStat rollStat in rollStats)
                    {
                        stats += rollStat.Id + " : " + rollStat.Value + " |";
                    }
                    Console.WriteLine(stats);

                    if(rollStats.Any(a => a.Value >= 100))
                    {
                        CancelThreads = true;
                        Console.WriteLine("Finito");

                    }

                    turn++;
                }



            }
        }
    }
}