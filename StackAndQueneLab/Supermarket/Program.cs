﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "End")
                {
                    break;
                }

                if (name == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine($" {queue.Dequeue()}");
                    }
                    //queue.Dequeue();
                    queue.Clear();
                }
                else
                {
                    queue.Enqueue(name);
                }
                
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
