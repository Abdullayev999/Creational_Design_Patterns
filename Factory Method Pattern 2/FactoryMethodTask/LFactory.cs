namespace Factory_Method_Pattern
{
    class LFactory : IFigureFactory
    {
        public Figure Create()
        {
            return new L();
        }
    }
}