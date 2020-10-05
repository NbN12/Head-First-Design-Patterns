using System;
using Interfaces;

namespace QuackBehaviorImplement
{
    public class Quack : IQuackBehavior
    {
        public void quack() => Console.WriteLine("Quack");
    }
}