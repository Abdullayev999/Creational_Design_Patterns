namespace Abstract_Factory_Pattern
{
    class OrcFactory : IUnitFactory
    {
        public Warrior CreateWarrior()
        {
            return new Grunt();
        }

        public Ranger CreateRanger()
        {
            return new Axethrowher();
        }
    }
}