using System;

namespace StrategyPattern
{
    public class RoloCompressor : Strategy
    {
        public override void ChooseMachineTemplate(int count)
        {
            if (count >= 4) 
            {
                Console.WriteLine("Set up the NEW template of repetition for 'rolo compressor'.");
            }
            else 
            {
                Console.WriteLine("Keep using the CURRENT template for 'rolo compressor'.");
            }
        }
    }
}