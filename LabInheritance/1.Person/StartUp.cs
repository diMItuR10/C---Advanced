﻿using System;

namespace _1.Person
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Child child = new Child(name, age);
            Console.WriteLine(child);
        }
    }
}
