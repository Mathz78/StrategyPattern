using System;

namespace StrategyPattern
{
    public class Context
    {
        Strategy strategy;
        // Constructor
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public void ChooseMachineTemplate(int count)
        {
            strategy.ChooseMachineTemplate(count);
        }
    }
}