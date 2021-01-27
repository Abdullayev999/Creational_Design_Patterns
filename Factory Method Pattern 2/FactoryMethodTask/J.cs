using System;

namespace Factory_Method_Pattern
{
    class J : Figure
    {
        public J()
        {
            Name = "J";
            Color = Program.RandColor();
        }

        public override string ToString()
        {
            Console.ForegroundColor = Color;
            return $"    *\n" +
                   $"    *\n" +
                   $"    *\n" +
                   $"* * *\n";
        }
    }
}