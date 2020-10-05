using System;
using Interfaces;

namespace QuackBehaviorImplement
{
    public class MuteQuack : IQuackBehavior
    {
        public void quack() => Console.WriteLine("<< Silence >>");
    }
}