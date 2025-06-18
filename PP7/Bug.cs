namespace PP7;

public abstract class Bug
{
    protected string Name { get; set; }
    protected int NumbersOfLegs { get; set; }
    protected bool CanFly { get; set; }
    protected bool CanBite { get; set; }

    protected string Harmness {get; set; }

    public virtual string GetName()
    {
        return Name;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Number of Legs: {NumbersOfLegs}, CanFly: {CanFly}, CanBite: {CanBite}, Harmness: {Harmness}";
    }
}