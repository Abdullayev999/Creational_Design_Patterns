namespace Abstract_Factory_Pattern
{
    class HumanFactory : IUnitFactory
    {
        public Warrior CreateWarrior()
        {
            return new Footman();
        }

        public Ranger CreateRanger()
        {
            return new Archer();
        }
    }
}