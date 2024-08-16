# LoopExpert Exercise

## Overview

This exercise is designed to help you practice and enhance your understanding of loops, conditional statements, and basic methods in C#. You'll be working with a simple console application that involves performing various operations on a list and determining the status of grades.

## Instructions

1. **Clone or Download the Repository:**
   - Clone the repository to your local machine or download the files.

2. **Open the Project:**
   - Open the `LoopExpert` project in your preferred C# IDE (e.g., JetBrains Rider, Visual Studio, etc.).

3. **Complete the Methods:**
   - The `Program` class contains several methods that are marked with `TODO:` comments. Your task is to complete these methods according to the instructions provided.

### Methods to Complete

1. **IsPassing(int grade):**
   - Determine if a grade is passing (70 or greater).
   - Example: A grade of 75 should return `true`, while a grade of 65 should return `false`.

2. **GetGradeClassification(int grade):**
   - Return a grade classification based on the grade value.
   - `A` for grades 90 and above.
   - `B` for grades between 70 and 89.
   - `C` for grades below 70.

3. **ViewItemsInListWithForEachLoop():**
   - Print out all items in a list using a `foreach` loop.

4. **ViewItemsInListWithForLoop():**
   - Print out all items in a list using a `for` loop.

5. **IsEggsInList():**
   - Check if "eggs" is in the list. Return `true` if it is, otherwise return `false`.

6. **ViewMenuItems():**
   - Display a menu with three items of your choice.

7. **UserChoiceFromMenu():**
   - Prompt the user to choose an item from the menu and return their choice.

8. **CountIngredients():**
   - Count and return the number of ingredients in the list.

9. **IsItemInList(string itemName):**
   - Check if a specific item (passed as a parameter) is in the list.

10. **PrintListInReverse():**
    - Print out all items in the list in reverse order.

11. **HasEggsAndFlourAndButter():**
    - Check if the list contains "eggs", "flour", and "butter". Return `true` only if all three are present.

### Testing the Methods

- After completing each method, call it in the `Main` method with different values to test its functionality. Print the results to the console to verify that the methods are working as expected.

### Example

```csharp
static void Main(string[] args)
{
    // Example test cases
    Console.WriteLine(IsPassing(75)); // Should print true
    Console.WriteLine(GetGradeClassification(85)); // Should print B
    ViewItemsInListWithForEachLoop();
    Console.WriteLine(IsEggsInList()); // Should print true
    // Continue testing other methods...
}
```
