namespace Factory_Method_Pattern
{
    class SFactory : IFigureFactory
    {
        public Figure Create()
        {
            return new S();
        }
    }
}