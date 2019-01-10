using System;
using System.Threading;

namespace Tenna
{
    internal class ThreadingSync
    {
        private static EventWaitHandle onReadyEvenThread;
        private static EventWaitHandle onReadyOddThread;

        static void Main(string[] args)
        {
            onReadyOddThread = new AutoResetEvent(true);
            onReadyEvenThread = new AutoResetEvent(false);

            // Create individul threads
            Thread threadOne = new Thread(oddNumbers);
            Thread threadTwo = new Thread(evenNumbers);

            //Start threads
            threadOne.Start();
            threadTwo.Start();
            
            threadOne.Join();
            threadTwo.Join();
        }

        // Method call by 'threadOne' to write odd numbers to console
        public static void oddNumbers()
        {
            for (int i = 1; i < 100; i += 2)
            {
                onReadyEvenThread.WaitOne();
                Console.WriteLine("thread " + 1 + ": The number is '" + i + "'");
                onReadyOddThread.Set();
            }
        }

        // Method call by 'threadTwo' to write even numbers to console
        public static void evenNumbers()
        {
            for (int i = 0; i <= 100; i += 2)
            {
                onReadyOddThread.WaitOne();
                if (i > 0)
                    Console.WriteLine("thread " + 2 + ": The number is '" + i + "'");
                onReadyEvenThread.Set();
            }
        }
    }
}