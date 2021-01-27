namespace Factory_Method_Pattern
{
    class OFactory : IFigureFactory
    {
        public Figure Create()
        {
            return new O();
        }
    }
}