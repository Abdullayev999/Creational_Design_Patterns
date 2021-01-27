using System;


namespace Factory_Method_Pattern
{
    class L : Figure
    {
        public L()
        {
            Name = "L";
            Color = Program.RandColor();
        }

        public override string ToString()
        {
            Console.ForegroundColor = Color;
            return $"*\n" +
                   $"*\n" +
                   $"*\n" +
                   $"* * *\n";
        }
    }
}