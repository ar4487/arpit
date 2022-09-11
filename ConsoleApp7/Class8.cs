using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ConsoleApp7
{
    class Class8
    {
        public static void Main132()
        {
            Console.WriteLine("=====Hashtable========");
            Hashtable ht = new Hashtable();
            ht.Add("asp", "asp.net");
            ht.Add("cs","cs.net");
            ht.Add("vb","vb.net");
            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key+"==>" + item.Value);
            }
            Console.WriteLine("==========Sorted list===========");
            SortedList sl = new SortedList();
            sl.Add("asp", "asp.net");
            sl.Add("cs", "cs.net");
            sl.Add("vb", "vb.net");
            foreach(DictionaryEntry item in sl)
            {
                Console.WriteLine(item.Key + "==>" + item.Value);
            }
            Console.WriteLine("=======Stack======");
            Stack sk = new Stack();
            sk.Push("oracle");
            sk.Push("asp.net");
            sk.Push("cs.net");
            sk.Push("vb.net");
           
            foreach (var item in sk)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======Queues======");
            Queue q = new Queue();
            q.Enqueue("oracle");
            q.Enqueue("asp.net");
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            foreach(var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
