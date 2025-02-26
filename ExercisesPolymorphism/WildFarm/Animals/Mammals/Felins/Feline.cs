﻿namespace WildFarm.Animals.Mammals.Felins
{
    public abstract class Feline : Mammal
    {
        public Feline(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get;}

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion},";
        }
    }
}
