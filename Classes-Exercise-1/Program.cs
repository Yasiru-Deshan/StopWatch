using System;

namespace Classes_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            var duration = new TimeSpan();
            var totDuration = new TimeSpan();

            var stopWatch = new StopWatch();
            Console.WriteLine("Type S to Start..");
            var startString = Console.ReadLine();

            while (i == 0)
            {

              

                if (startString == "s")
                {
                    stopWatch.Start();
                }
                else
                {
                    Console.WriteLine("Type S to Start..");

                }

                Console.WriteLine("Type R to Stop");
                var stopString = Console.ReadLine();
                if (stopString == "r")
                {
                    stopWatch.Stop();

                }else if(stopString == "s")
                {
                    stopWatch.Start();
                }
                else
                {
                    Console.WriteLine("Type R to Stop");
                }

                duration = stopWatch.stopTime - stopWatch.startTime;
                Console.WriteLine("Duration {0}", duration);

                totDuration = totDuration + duration;

                Console.WriteLine("Type S to Start..");
                var again = Console.ReadLine();

                if(again == "s")
                {
                    i = 0;
                }
                else
                {
                    i = 1;
                   
                    Console.WriteLine("Total Duration : {0}", totDuration);
                }
            }

        }
    }
}
