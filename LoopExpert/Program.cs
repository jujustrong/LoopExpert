namespace LoopExpert;

class Program
{
    static void Main(string[] args)
    {
        IsPassing(80);
        
        var myGrade = GetGradeClassification(95);
        Console.WriteLine(myGrade);
        
        ViewItemsInListWithForEachLoop();
        
        ViewItemsInListWithForLoop();

        IsEggsInList();
        
        ViewMenuItems();

        var userChoice = UserChoiceFromMenu();
        Console.WriteLine(userChoice);

        var count = CountIngredients();
        Console.WriteLine(count);

        var isIt = IsItemInList("vanilla");
        Console.WriteLine(isIt);
        
        PrintListInReverse();
    }

    // 1. TODO: Complete the method to determine if a grade is passing.
    // A grade of 70 or greater is considered passing.
    // Example: If the grade is 75, the method should return true. If the grade is 65, the method should return false.
    // After completing the method, call it in the Main method with different grade values to test its functionality.
    static bool IsPassing(int grade)
    { 
        var answer = grade >= 70 ? true : false;
        Console.WriteLine(answer);
        return answer;
    }
    
    // 2. TODO: Complete the method to return a grade classification as "A", "B", or "C" based on the grade.
    // Return "A" if the grade is 90 or above.
    // Return "B" if the grade is between 70 and 89 (inclusive).
    // Return "C" if the grade is below 70.
    // After completing the method, call it in the Main method with different grade values to test its functionality.
    static string GetGradeClassification(int grade)
    {
        if (grade >= 90) {return "A";} 
        else if (grade >=70) {return "B";}
        else
        {
            return "C";
        }
    }


    // 3. TODO: Complete the method to print out all items in the list using a foreach loop.
    // Iterate over the ingredientList and print each item to the console.
    // Example: The output should be:
    // flour
    // sugar
    // eggs
    // butter
    // milk
    // vanilla
    static void ViewItemsInListWithForEachLoop()
    {
        List<string> ingredientList = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };
        foreach (var ingredient in ingredientList)
        {
            Console.WriteLine(ingredient);
        }
    }

    // 4. TODO: Complete the method to print out all items in the list using a for loop.
    // Use a standard for loop to iterate over the ingredientList and print each item to the console.
    // Example: The output should be:
    // flour
    // sugar
    // eggs
    // butter
    // milk
    // vanilla
    static void ViewItemsInListWithForLoop()
    {
        List<string> ingredientList = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };
        for (int i = 0; i < ingredientList.Count; i++)
        {
            Console.WriteLine(ingredientList[i]);
        }
    }

    // 5. TODO: Complete the method to check if "eggs" is in the list.
    // Return true if "eggs" is in the ingredientList, otherwise return false.
    // Example: If the list contains "eggs", the method should return true. If it does not, the method should return false.
    static bool IsEggsInList()
    {
        List<string> ingredientList = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };
        var answer = ingredientList.Contains("eggs") ? true : false;
        Console.WriteLine(answer);
        return answer;
    }

    // 6. TODO: Create a method that displays a menu with three items.
    // These can be three restaurant menu items. Print each item to the console.
    // Example: The menu might include:
    // 1. Cheeseburger
    // 2. Caesar Salad
    // 3. Spaghetti Bolognese
    static void ViewMenuItems()
    {
        List<string> menu = new List<string>() { "Carbonara", "Cacio e Pepe", "Penne Alla Vodka" };
        Console.WriteLine("Hello, welcome to Facciamo il Chilo!");
        Thread.Sleep(1000);
        Console.WriteLine("Today our menu consists of: ");
        int num = 1;
        foreach (var item in menu)
        {
            Console.WriteLine($"{num}. {item}");
            num++;
        }
    }

    // 7. TODO: Complete the method to prompt the user to choose an item from the menu.
    // This method should print a message asking the user what item they want.
    // Then, return the user's input as a string.
    // Example: If the user selects "1", the method should return "1".
    static string UserChoiceFromMenu()
    {
        Console.WriteLine("What would you like to order?");
        var choice = Console.ReadLine();
        if (choice == "1" || choice.ToLower() == "carbonara")
        {
            return "Ok, we will have that Carbonara out to you soon!";
        }
        else if (choice == "2" || choice.ToLower() == "cacico e pepe")
        {
            return "Great choice! We will have the Cacio e Pepe out shortly!";
        }
        else if (choice == "3" || choice.ToLower() == "penne alla vodka")
        {
            return "You will love the Penne Alla Vodka! We will bring it out shortly!";
        }
        else
        {
            return "Sorry we don't have that on the menu...";
        }
    }

    // 8. TODO: Complete the method to count the number of ingredients in the list.
    // This method should return the total number of items in the ingredientList.
    // Example: If the list contains 6 items, the method should return 6.
    static int CountIngredients()
    {
        List<string> ingredientList = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };
        return ingredientList.Count;
    }

    // 9. TODO: Complete the method to check if a specific item is in the list.
    // The method should take a string parameter for the item name and return true if the item is in the list, false otherwise.
    // Example: If the item is "sugar" and it exists in the list, return true.
    static bool IsItemInList(string itemName)
    {
        List<string> ingredientList = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };
        return ingredientList.Contains(itemName) ? true : false;
    }

    // 10. TODO: Complete the method to print out all items in the list in reverse order.
    // Use a loop to iterate over the list in reverse and print each item.
    // Example: If the list is { "flour", "sugar", "eggs", "butter", "milk", "vanilla" }, the output should be:
    // vanilla
    // milk
    // butter
    // eggs
    // sugar
    // flour
    static void PrintListInReverse()
    {
        List<string> ingredientList = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };
        for (int i = ingredientList.Count-1; i >= 0; i--)
        {
            Console.WriteLine(ingredientList[i]);
        }
    }

    // 11. BONUS -- TODO: Complete the method to check if the list contains "eggs", "flour", and "butter".
    // Use conditional statements to check if all three ingredients are present in the ingredientList.
    // Return true only if "eggs", "flour", and "butter" are all in the list; otherwise, return false.
    // Example: If the list is { "flour", "sugar", "eggs", "butter", "milk", "vanilla" }, the method should return true.
    // Example: If the list is { "flour", "sugar", "milk", "vanilla" }, the method should return false.
    static bool HasEggsAndFlourAndButter()
    {
        List<string> ingredientList = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };
        if (ingredientList.Contains("eggs") && ingredientList.Contains("flour") && ingredientList.Contains("butter"))
        {
            Console.WriteLine("True");
        }

        return true;
    }
}