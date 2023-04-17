using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using InitInNetstandard2;

namespace NetFrameworkConsumingJankyNetstandard2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Record testRecord = new Record
            {
                Data = "Hello from 2015, its time to update your runtime",
                RandomUntypedIds = new []{1,2}
            };
            
            Console.WriteLine(testRecord.Data);
        }
    }
}