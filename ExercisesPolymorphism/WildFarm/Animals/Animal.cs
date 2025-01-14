﻿namespace WildFarm.Animals
{
    public abstract class Animal 
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get;}

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        public abstract void ProduceSound(Food food);
    }
}
