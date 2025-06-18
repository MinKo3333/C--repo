namespace PP6;

public class Tick : Bug
{
    public Tick() {
        Name = "Tick";
        NumbersOfLegs = 8;
        CanFly = false;
        CanBite = true;
        Harmness = "Vector for disease, Allergic reaction";
    }
}