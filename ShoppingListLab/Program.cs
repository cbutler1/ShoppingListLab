bool inputOne = true;
List<string> shoppingList = new List<string>();
Dictionary<string, decimal> shoppingMenu = new Dictionary<string, decimal>()
{
    {"Milk", 1.99m }, {"Granola", 4.99m }, {"Ground Beef", 2.99m }, {"Flaming Hot Cheetos", 3.99m },
    {"Redbull", 3.49m }, {"Hummus", 3.99m }, {"Orange Juice", 2.99m }, {"Chicken Breast", 3.50m }
};


Console.WriteLine("Welcome to the Mini Mart!  What can we get for you today?");
Console.WriteLine("{0,-20} {1,5}", "Item", "Price");
Console.WriteLine("=============================");
//display dictionary next
foreach (KeyValuePair<string, decimal> kvp in shoppingMenu)
{
    Console.WriteLine("{0,-20} {1,5}", kvp.Key, kvp.Value);
}


//program
do
{


    foreach (KeyValuePair<string, decimal> kvp in shoppingMenu)
    {
        Console.WriteLine("What item would you like to add to your order today?");
        string input = Console.ReadLine();//.ToUpper(); not working for me?
        
        //not how I wanted to display prices but didn't give myself enough time for this Lab.

        if (input.Contains("Milk"))
        {
            shoppingList.Add(input);
            Console.WriteLine("Adding " + shoppingMenu.ElementAt(0) + " to your cart");
            break;
        }
        if (input.Contains("Granola"))
        {
            shoppingList.Add(input);
            Console.WriteLine("Adding " + shoppingMenu.ElementAt(1) + " to your cart");
            break;
        }
        if (input.Contains("Ground Beef"))
        {
            shoppingList.Add(input);
            Console.WriteLine("Adding " + shoppingMenu.ElementAt(2) + " to your cart");
            break;
        }
        if (input.Contains("Flaming Hot Cheetos"))
        {
            shoppingList.Add(input);
            Console.WriteLine("Adding " + shoppingMenu.ElementAt(3) + " to your cart");
            break;
        }
        if (input.Contains("Redbull"))
        {
            shoppingList.Add(input);
            Console.WriteLine("Adding " + shoppingMenu.ElementAt(4) + " to your cart");
            break;
        }
        if (input.Contains("Hummus"))
        {
            shoppingList.Add(input);
            Console.WriteLine("Adding " + shoppingMenu.ElementAt(5) + " to your cart");
            break;
        }
        if (input.Contains("Orange Juice"))
        {
            shoppingList.Add(input);
            Console.WriteLine("Adding " + shoppingMenu.ElementAt(6) + " to your cart");
            break;
        }
        if (input.Contains("Chicken Breast"))
        {
            shoppingList.Add(input);
            Console.WriteLine("Adding " + shoppingMenu.ElementAt(7) + " to your cart");
            break;
        }
        else
        {
            Console.WriteLine("Please enter an item that is on our Menu");
            break;
        }

    }
    Console.WriteLine("Would you like to add another item to your order? Type 'No' to checkout.");
    string inputOnee = Console.ReadLine().ToLower();
    if (inputOnee == "no")
    {
        inputOne = false;
    }

}while (inputOne == true);


//testing list need to search through shoppingMenu now
for (int i = 0; i < shoppingList.Count; i++)
{
    Console.WriteLine(shoppingList[i]);
}


