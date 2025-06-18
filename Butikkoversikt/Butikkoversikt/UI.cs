namespace Butikkoversikt;

public class UI
{
    private ShopList shopList = new ShopList();

    public void Welcome()
    {
        Console.WriteLine("Welcome to Shop list");
    }

    public void ListOptionView()
    {
        Console.WriteLine("Choose what you want to do\n" +
                          "1. Add new shop to the list\n" +
                          "2. View the shop list");
    }

    public void ListOptions()
    {
        int answer = int.Parse(Console.ReadLine());
        switch (answer)
        {
            case 1: shopList.Add(AddNewShop());
                break;
            case 2: ShowList(ShowListView());
                break;
        }
    }

    public Shop AddNewShop()
    {
        Console.WriteLine("Write new shop information(name/price level(1. cheap 2. middle 3. expensive)/speciality)\n" +
                          "ex) Rema1000/1/Food");
        string answer = Console.ReadLine();
        string[] answers = answer.Split('/',3);
        Shop shop = new Shop(answers[0],int.Parse(answers[1]),answers[2]);
            
            return shop;
    }

    public int ShowListView()
    {
        Console.WriteLine("Choose what you want to see\n" +
                          "1. All shops on the list\n" +
                          "2. The cheapest of the categories\n" +
                          "3. Middle price range shops\n" +
                          "4. Expensive shops");
        
        int answer = int.Parse(Console.ReadLine());
        
        return answer;
    }

    public void ShowList(int answer)
    {
        switch (answer)
        {
            case 1: foreach (var shop in shopList.shops)
                {
                        Console.WriteLine(shop);
                }
                break;
            case 2: shopList.shops.Where(shop => shop.PL == "cheap").ToList().ForEach(shop => Console.WriteLine(shop));
                break;
        }
        
    }
}