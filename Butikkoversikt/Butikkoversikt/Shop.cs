namespace Butikkoversikt;

public class Shop
{
    private string Name { get; set; }
    private int PriceLevel { get; set; }
    public string PL { get; private set; }
    private string Specialty { get; set; }

    public Shop(string name, int priceLevel, string specialty)
    {
        Name = name;
        PriceLevel = priceLevel;
        Specialty = specialty;
        GetPL();
    }
    public void GetPL()
    {
        switch (PriceLevel)
        {
            case 1: PL = "cheap";
                break;
            case 2: PL = "middle";
                break;
            case 3: PL = "expensive";
                break;
            default: PL = "none";
                break;
        }
    }

    public override string ToString()
    {
        return $"{Name} / {PL} price level/ sell: {Specialty}";
    }

}