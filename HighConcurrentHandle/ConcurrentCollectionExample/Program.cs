﻿using System;

namespace ConcurrentCollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********并发集合使用***************");
            // ConcurrentQueue
            //ConcurrentQueueExample.GetProductsCount();

            //ConcurrentDictionary
            var concurrentDictionary =  ConcurrentDictionaryExample.GetDictionary();
            foreach (var item in concurrentDictionary)
            {
                Console.WriteLine(item.Key+" :"+item.Value);
            }


            Console.ReadKey();
        }
    }


}
