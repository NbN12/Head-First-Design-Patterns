using System;
using Interfaces;

namespace QuackBehaviorImplement
{
    public class Squeak : IQuackBehavior
    {
        public void quack() => Console.WriteLine("Squeak");
    }
}