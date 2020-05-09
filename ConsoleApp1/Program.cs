using WowUniverse;
using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static bool forward = false;
        static Random myrandomNumber = new Random();
        static void Main(string[] args)
        {
            System.Threading.Timer _timer;
            System.TimeSpan _mytimer = System.TimeSpan.FromSeconds(5);
            Console.WriteLine("Hello World!");


            _timer = new Timer(startAutomation, null, TimeSpan.Zero, _mytimer);

            Console.ReadLine();
            

        }

        private static void startAutomation(object state)
        {
            WowProcess.PressKey(ConsoleKey.W);
            WowProcess.PressKey(ConsoleKey.S);
            Thread.Sleep(myrandomNumber.Next(1,3));
            //forward = !forward;
            //if (forward)
            //{
            //    WowProcess.PressKey(ConsoleKey.A);
            //    Console.WriteLine(DateTime.Now + "pressed A");
            //}
            //else {
            //    WowProcess.PressKey(ConsoleKey.D);
            //    Console.WriteLine(DateTime.Now + "pressed D");
            //}
            
            //WowProcess.PressKey(ConsoleKey.W);
            //WowProcess.PressKeyAndHold(ConsoleKey.W, 10000);
        }

        
    }
}
