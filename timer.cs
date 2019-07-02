using System;
using System.Timers;

namespace TimerTest {
    class Program {
        private static Timer timer;
        static void Main(string[] args) {
            Console.WriteLine("Started at {0:HH:mm:ss.fff}", DateTime.Now);
            SetTimer();

            Console.ReadKey();
            timer.Stop();
            timer.Dispose();
        }

        public static void SetTimer() {
            timer = new Timer(2000); // Amount of time in milliseconds 
            timer.Elapsed += OnTimedEvent; // Handler
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private static void OnTimedEvent(Object sender, ElapsedEventArgs e) {
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
