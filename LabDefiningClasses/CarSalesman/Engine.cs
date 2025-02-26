﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {

        public string Model { get; set; }

        public int Power { get; set; }

        public int Displacement { get; set; }

        public string Efficiency { get; set; }

        public Engine()
        {

        }

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"  {Model}:");
            sb.AppendLine();
            sb.Append($"    Power: {Power}");
            sb.AppendLine();
            sb.Append(Displacement == 0 ? "    Displacement: n/a " : $"    Displacement: {Displacement}");
            sb.AppendLine();
            sb.Append(string.IsNullOrEmpty(Efficiency) ? "    Efficiency: n/a " : $"    Efficiency: {Efficiency}");

            return sb.ToString().TrimEnd();
        }
    }
}
