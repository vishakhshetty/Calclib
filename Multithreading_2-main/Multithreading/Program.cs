using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Multithreading Program********\n");
            Console.WriteLine("Main thread started. ThreadID = {0}",Thread.CurrentThread.ManagedThreadId);
            Printer p = new Printer();
            WaitCallback workItem = new WaitCallback(PrintTheNumbers);
            for(int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(workItem, p);

            }
            Console.WriteLine("All task Queued");
            Console.ReadLine();
        }

        static void PrintTheNumbers(object state)
        {
            Printer task = (Printer)state;
            task.PrintNumbers();
        }

    }
}
