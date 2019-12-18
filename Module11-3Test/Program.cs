using System;
using Module11;

namespace Module11_3Test
{
    public class Program
    {
        public static void PrintMessage1(object sender, NewCountdownEventArgs e)
        {
            Console.Write("Subscriber1: ");
            Console.WriteLine(e.Message);
        }
        public static void PrintMessage2(object sender, NewCountdownEventArgs e)
        {
            Console.Write("Subscriber2: ");
            Console.WriteLine(e.Message);
        }

        public static void Main(string[] args)
        {
            var time1 = 1000;
            var time2 = 1500;
            var countdown = new Countdown();
            countdown.NewCountdown += PrintMessage1;
            countdown.NewCountdown += PrintMessage2;
            countdown.Wait(time1);
            countdown.NewCountdown -= PrintMessage1;
            countdown.Wait(time2);
            Console.Read();
        }
    }
}
