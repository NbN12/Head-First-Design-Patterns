using DuckTypes;
using FlyBehaviorImplement;
using Interfaces;
using QuackBehaviorImplement;

namespace Chap1
{
    public class MiniDuckSimulator
    {
        public static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();

            IQuackBehavior duckCall = new DuckCall();
            duckCall.quack();
        }
    }
}