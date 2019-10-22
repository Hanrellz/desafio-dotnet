using System;
using System.Timers;

namespace Mouts.Metadata
{
    public class Alarm : Timer
    {
        private int timerSecords = 1;
        public int DigitationInterval { get; private set; }
        public Alarm(double interval, int digitationInterval) : base(interval)
        {
            this.DigitationInterval = digitationInterval;
            base.Elapsed += OnElapsedTimer;
        }

        private void OnElapsedTimer(object sender, ElapsedEventArgs e)
        {
            if (timerSecords > DigitationInterval)
            {
                Console.WriteLine("THE ALARM SOUNDED. RUN AWAY!!!");
                Environment.Exit(0);
            }

            if(timerSecords == 1)
                Console.WriteLine("Safebox's timer began!");
                
            timerSecords++;
        }

        public void Reset()
        {
            timerSecords = 1;
            base.Start();
        }
    }
}