﻿using System;

namespace _4.CarEngineandTires
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new Tire[]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.1),
                new Tire(2, 0.5),
                new Tire(2, 2.3)
            };

            var engine = new Engine(560, 6300);

            var car = new Car("Lamborgini", "Urus", 2010, 250, 9, engine, tires);
            Console.WriteLine(car.WhoAmi());
        }
    }
}
