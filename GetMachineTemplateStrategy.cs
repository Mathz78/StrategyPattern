using System;

namespace StrategyPattern
{
    public abstract class Strategy
    {
        public abstract void ChooseMachineTemplate(int count);
    }
}