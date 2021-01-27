using System;

namespace Factory_Method_Pattern
{
    class  T : Figure
    {
        public T()
        {
            Name = "T";
            Color = Program.RandColor();
        }

        public override string ToString()
        {
            Console.ForegroundColor = Color;
            return $"   *\n" +
                   $"   *\n" +
                   $"* * * *\n";
        }
    }
}