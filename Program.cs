using System;
namespace StrategyPattern
{
    /// <summary>
    /// Strategy Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Context context;

            // Three contexts using different machines.. 
            context = new Context(new Centrifuga());
            context.ChooseMachineTemplate(6);
            context = new Context(new RoloCompressor());
            context.ChooseMachineTemplate(4);
            context = new Context(new UHSMP6());
            context.ChooseMachineTemplate(3);

            Console.ReadKey();
        }
    }
}