namespace Factory_Method_Pattern
{
    class ZFactory : IFigureFactory
    {
        public Figure Create()
        {
            return new Z();
        }
    }
}