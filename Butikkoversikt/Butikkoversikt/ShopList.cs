using System.ComponentModel;

namespace Butikkoversikt;

public class ShopList
{
   public  List<Shop> shops { get; private set; }

   public ShopList()
   {
       shops = new List<Shop>
        {
            new Shop("H&M",2,"Cloth"),
            new Shop("Extra Leker", 2, "Toys"),
            new Shop("Kiwi",1,"Food"),
            new Shop("Dior",3,"Cloth"),
            new Shop("Jacobs",3,"Food"),
            new Shop("Toys R Us", 3, "Toys"),
        };
   }

   

    public void Add(Shop shop)
    {
        shops.Add(shop);
    }
}