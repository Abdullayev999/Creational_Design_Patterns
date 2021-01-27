using System;

namespace Factory_Method_Pattern
{
    class O : Figure
    {
        public O()
        {

            Name = "O";
            Color = Program.RandColor();
        }

        public override string ToString()
        {
            Console.ForegroundColor = Color;
            return $"* * * *\n" +
                   $"*     *\n" +
                   $"*     *\n" +
                   $"* * * *\n";
        }
    }
}