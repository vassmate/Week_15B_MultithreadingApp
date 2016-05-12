using System;
using System.Threading;

namespace Week_15B_MultithreadingApp
{
    public static class RunMultithreading
    {
        static void Main(string[] args)
        {
            ThreadStart startThread = new ThreadStart(Counting);

            Thread firstThread = new Thread(startThread);
            Thread secondThread = new Thread(startThread);

            firstThread.Start();
            secondThread.Start();

            firstThread.Join();
            secondThread.Join();

            Console.WriteLine(">Press any key to exit...");
            Console.Read();
        }

        private static void Counting()
        {
            for (int counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine(">Count: {0} - Thread_Id: {1}", counter, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
        }
    }
}
