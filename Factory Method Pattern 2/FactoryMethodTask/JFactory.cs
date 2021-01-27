namespace Factory_Method_Pattern
{
    class JFactory : IFigureFactory
    {
        public Figure Create()
        {
            return new J();
        }
    }
}