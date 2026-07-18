abstract class Character
{
    protected string charType;
    protected Character(string characterType) => charType = characterType;


    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;


    public override string ToString() => $"Character is a {charType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}

class Wizard : Character
{
    private bool _prepareSpell = false;
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target) => _prepareSpell ? 12 : 3;

    public void PrepareSpell() => _prepareSpell = !_prepareSpell;
    public override bool Vulnerable() => !_prepareSpell;
}
