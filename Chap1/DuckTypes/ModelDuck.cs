using System;
using FlyBehaviorImplement;
using QuackBehaviorImplement;

namespace DuckTypes
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Quack();
        }
        public override void Display() => Console.WriteLine("I'm model duck");
    }
}