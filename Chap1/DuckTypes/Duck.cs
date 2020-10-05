using System;
using Interfaces;

namespace DuckTypes
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }

        public IQuackBehavior QuackBehavior { get; set; }
        public Duck()
        {
        }

        public abstract void Display();

        public void PerformFly() => FlyBehavior.Fly();

        public void PerformQuack() => QuackBehavior.quack();

        public void Swim() => Console.WriteLine("All ducks float, even decoys!");
    }
}