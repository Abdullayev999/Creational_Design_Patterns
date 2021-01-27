namespace Abstract_Factory_Pattern
{
    public abstract class Unit
    {
        public int HP { get; set; }
        public int Damage { get; set; }
        abstract public void Attack(Unit target);
    }
}