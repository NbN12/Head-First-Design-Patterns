using System;
using FlyBehaviorImplement;
using QuackBehaviorImplement;

namespace DuckTypes
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }
        public override void Display() => Console.WriteLine("I'm a real Mallard duck");
    }
}