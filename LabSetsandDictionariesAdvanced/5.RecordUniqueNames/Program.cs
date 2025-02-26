﻿using System;
using System.Collections.Generic;

namespace _5.RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> uniqueName = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                uniqueName.Add(name);
            }

            foreach (var item in uniqueName)
            {
                Console.WriteLine(item);
            }
        }
    }
}
