using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Exercise_1
{
    public class StopWatch
    {
        public DateTime startTime;
        public DateTime stopTime;
        public bool IsRunning;
        public void Start()
        {
            if (!IsRunning)
            {
                IsRunning = true;
                startTime = DateTime.Now;
                Console.WriteLine("Start Time : {0} ", DateTime.Now.ToString("yyyyMMddHHmmss"));
            }
            else
            {
                throw new InvalidOperationException("Stopwatch is already running");
            }
        }

        public void Stop()
        {

            if (IsRunning)
            {
                IsRunning = false;
                stopTime = DateTime.Now;
                Console.WriteLine("End Time : {0}", DateTime.Now.ToString("yyyyMMddHHmmss"));
            }
        }
    }
}
