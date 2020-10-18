using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;


namespace Queue3
{
    class Queue
    {
     
        LinkedList<int> Que = new LinkedList<int>();
        public void add(int numb)
        {
            Que.AddFirst(numb);
        }

       
        public void delete()
        {
            
            Que.RemoveFirst();
        }
       

        public void show()
        {
            
            foreach (int i in Que)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"Queue1000k.txt";
            int[] array = { 0 };
            
            array = File.ReadAllText(Path).Split().Select(int.Parse).ToArray();


            Queue one = new Queue();
            Random rnd = new Random();
           
            Stopwatch timer1 = new Stopwatch();
           Stopwatch timer2 = new Stopwatch();
            timer1.Start();
            for (int i = 0; i < array.Length; i++)
            {
                one.add(array[i]);
            }
            //one.show();
            timer1.Stop();
            
            Console.WriteLine("Time add (ms): {0}", timer1.Elapsed.TotalMilliseconds);
  
            timer2.Start();
            for (int i = 0; i < array.Length; i++)
            {
                one.delete();
             //   one.show();
               // Console.WriteLine("  ");
            }
           // one.show();
            timer2.Stop();
             Console.WriteLine("Time delete (ms): {0}", timer2.Elapsed.TotalMilliseconds);
        }
    }
}
