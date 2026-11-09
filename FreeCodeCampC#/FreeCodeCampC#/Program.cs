// SCRATCHPAD (PRACTICE CODE)


// LISTS
/* LISTS IN C# BASICS
List<string> colors = new List<string> { "red", "green", "blue" }; // Creates a list of strings with assigned values
List<int> scores = new List<int>(); // Creates an empty list of integers
*/

/* MAKING CHANGES TO LISTS IN C#
List<string> colors = new List<string> { "red", "green", "blue" };

Console.WriteLine(colors.Count); // Output: 3
colors.Add("yellow");            // Adds "yellow" to the end
Console.WriteLine(colors.Count); // Output: 4

colors.Remove("red");            // Removes "red"
colors[0] = "purple";            // Replaces "green" with "purple"
*/

/* LIST OPERATIONS IN C#
list.count; // Returns the number of elements in the list
list.Add("yellow"); // Adds "yellow" to the end of the list
list.remove("yellow"); // Removes "yellow" from the list
list[i]; // Accesses the element at index i
list.RemoveAt(i); // Removes the element at index i
List.Sort(); // Sorts the list in ascending order
*/

/* FOREACH LOOP WITH LISTS IN C#
List<int> scores = new List<int> { 95, 82, 76, 91 };

foreach (int score in scores) // creates a variable score to hold each value in the scores list
{
    Console.WriteLine(score);
}
*/

// ARRAYS
/* ARRAYS IN C# BASICS
int[] scores = new int[4]; // Array of 4 integers (default to 0)
scores[0] = 10; // Assigning value to the first element of array

string[] colors = { "red", "green", "blue" }; // // Array of 3 strings (with values listed in the curly braces)
Console.WriteLine(colors[0]); // Output: red
Console.WriteLine(colors[2]); // Output: blue

colors[0] = "purple"; // Replaces "red" with "purple"
Console.WriteLine(colors[0]); // Output: purple
*/

/* FOREACH LOOP WITH ARRAYS IN C#
int[] scores = { 95, 82, 76, 91 }
;

foreach (int score in scores) // Declares int variable score to hold each value in the scores array
{
   Console.WriteLine(score);
}
*/

// LOOPS
/* Nested loop example
for (int round = 1; round <=2; round++)
{
    Console.WriteLine($"Round {round} ");
    for(int rep = 1; rep <=3;  rep++)
    {
        Console.WriteLine($"Rep {rep} ");
        if(rep == 3)
        {
            Console.WriteLine("Round Complete!");
        }
    }
}
*/

/* THE FOR LOOP IN C#

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
*/

/* THE WHILE LOOP IN C#
int health = 3;

while (health > 0)
{
    Console.WriteLine($"Player is alive. Health: {health}");
    health--;
}
*/

/* THE DO-WHILE LOOP IN C#
int attempts = 0;

do
{
    attempts++;
    Console.WriteLine($"Attempt number {attempts}");
}
while (attempts < 3);
*/

/* USING BREAK STATEMENT IN C#
for (int count = 0; count < 10; count++)
{
    if (count == 5)
    {
        break;
    }
    Console.WriteLine(count);
}

Console.WriteLine("Loop ended.");
*/

/* USING CONTINUE STATEMENT IN C#
 
for (int count = 0; count < 6; count++)
{
    if (count == 3)
    {
        continue;
    }
    Console.WriteLine(count);
}
*/

/* WHILE LOOP BREAK EXAMPLE
while (true)
{
    Console.Write("Type 'exit' to stop the loop: ");
    string userInput = Console.ReadLine();

    if (userInput.ToLower() == "exit")
    {
        break;
    }

    Console.WriteLine($"You entered: {userInput}");
}

Console.WriteLine("Goodbye!");
*/

/* WHILE LOOP CONTINUE EXAMPLE
int currentSlot = 0;

while (currentSlot < 5)
{
    currentSlot++; // Crucial: the update happens before the continue check

    if (currentSlot == 3)
    {
        Console.WriteLine($"Skipping item slot {currentSlot}.");
        continue;
    }

    Console.WriteLine($"Successfully processed item in slot {currentSlot}.");
}

Console.WriteLine("Inventory scan complete!");
*/