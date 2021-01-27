namespace Factory_Method_Pattern
{
    class IFactory : IFigureFactory
    {
        public Figure Create()
        {
            return new I();
        }
    }
}