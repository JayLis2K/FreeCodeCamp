// SCRATCHPAD (PRACTICE CODE)

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