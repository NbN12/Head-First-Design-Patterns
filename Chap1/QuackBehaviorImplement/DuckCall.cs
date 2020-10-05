using System;
using Interfaces;

namespace QuackBehaviorImplement
{
    public class DuckCall : IQuackBehavior
    {
        public void quack() => Console.WriteLine("Quack quack quack!!");
    }
}