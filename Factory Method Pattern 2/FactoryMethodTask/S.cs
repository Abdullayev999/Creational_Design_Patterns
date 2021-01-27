using System;

namespace Factory_Method_Pattern
{
    class S : Figure
    {
        public S()
        {
            Name = "S";
            Color = Program.RandColor();
        }

        public override string ToString()
        {
            Console.ForegroundColor = Color;
            return $"    * * *\n" +
                   $"    *\n" +
                   $"* * *\n";
        }
    }
}