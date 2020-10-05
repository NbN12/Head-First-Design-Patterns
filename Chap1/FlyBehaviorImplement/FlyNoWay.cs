using System;
using Interfaces;

namespace FlyBehaviorImplement
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly() => Console.WriteLine("I can't fly");
    }
}