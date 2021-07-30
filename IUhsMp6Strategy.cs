using System;

namespace StrategyPattern
{
    public class UHSMP6 : Strategy
    {
        public override void ChooseMachineTemplate(int count)
        {
            if (count >= 4) 
            {
                Console.WriteLine("Set up the NEW template of repetition for 'UHS MP6 Equipment'.");
            }
            else 
            {
                Console.WriteLine("Keep using the CURRENT template for 'UHS MP6 Equipment'.");
            }
        }
    }
}