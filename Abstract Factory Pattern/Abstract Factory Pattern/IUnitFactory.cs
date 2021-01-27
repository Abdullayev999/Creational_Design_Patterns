namespace Abstract_Factory_Pattern
{
    public interface IUnitFactory
    {
        Warrior CreateWarrior();
        Ranger CreateRanger();

    }
}