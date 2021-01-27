using System;

namespace Factory_Method_Pattern
{
    class I : Figure
    {
        public I()
        {
            Name = "I";
            Color = Program.RandColor();
        }

        public override string ToString()
        {
            Console.ForegroundColor = Color;
            return $"  *\n" +
                   $"  *\n" +
                   $"  *\n" +
                   $"  *\n";
        }
    }
}