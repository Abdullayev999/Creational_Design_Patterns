using System;

namespace Factory_Method_Pattern
{
    class Z : Figure
    {
        public Z()
        {
            Name = "Z";
            Color = Program.RandColor();
        }

        public override string ToString()
        {
            Console.ForegroundColor = Color;
            return $"* * *\n" +
                   $"    *\n" +
                   $"    * * *\n";
        }
    }
}