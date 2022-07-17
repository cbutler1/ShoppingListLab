List<string> shoppingList = new List<string>();
Dictionary<string, decimal> shoppingMenu = new Dictionary<string, decimal>()
{
    {"Milk", 1.99m }, {"Granola", 4.99m }, {"Ground Beef", 2.99m }, {"Flaming Hot Cheetos", 3.99m },
    {"RedBull", 3.49m }, {"Hummus", 3.99m }, {"Orange Juice", 2.99m }, {"Chicken Breast", 3.50m }
};

Console.WriteLine(shoppingMenu.ElementAt(2)); //test


Console.WriteLine("Welcome to the Mini Mart!  What can we get for you today?");
Console.WriteLine("{0,-20} {1,5}", "Item", "Price");
Console.WriteLine("=============================");
//display dictionary next
foreach (KeyValuePair<string, decimal> kvp in shoppingMenu)
{
    Console.WriteLine("{0,-20} {1,5}", kvp.Key, kvp.Value);
}
//ask user to enter item name, make list of console entries to add to order
Console.WriteLine("What item would you like to add to your order today?");
string input = Console.ReadLine();
shoppingList.Add(input);

//testing list
for (int i = 0; i < shoppingList.Count; i++)
{
    Console.WriteLine(shoppingList[i]);
}


