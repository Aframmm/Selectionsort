using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sortering2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();

            Random ran = new Random();

            Stopwatch watch = new Stopwatch();

            for(int i = 0; intList.Count < 1000; i++){
                intList.Add(ran.Next(1, 1001));
            }
            watch.Start();

            int first;
            for (int i = 0; i < intList.Count - 1; i++){
                first = i;
                for(int j = first; j < intList.Count; j++){
                    if (intList[j] < intList[first]){
                        int abc = intList[j];
                        intList[j] = intList[first];
                        intList[first] = abc;
                    }
                }
            }
            watch.Stop();
    
            foreach(int i in intList){
                Console.WriteLine(i);
            }

            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}