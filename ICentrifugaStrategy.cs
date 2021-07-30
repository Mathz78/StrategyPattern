using System;

namespace StrategyPattern
{
    public class Centrifuga : Strategy
    {
        public override void ChooseMachineTemplate(int count)
        {
            if (count >= 4) 
            {
                Console.WriteLine("Set up the NEW template of repetition for 'centrifuge'.");
            }
            else 
            {
                Console.WriteLine("Keep using the CURRENT template for 'centrifuge'.");
            }
        }
    }
}