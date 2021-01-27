namespace Factory_Method_Pattern
{
    class TFactory : IFigureFactory
    {
        public Figure Create()
        {
            return new T();
        }
    }
}