
Random randomNumber = new Random();
int computerNumber = randomNumber.Next(1, 101);

while (true)
{
    Console.Write("Guess a number (1-100): ");

    string playerMove = Console.ReadLine()!;
    bool isValid = int.TryParse(playerMove, out int playerNumber);

    if (isValid)
    {
        if(playerNumber == computerNumber)
        {
            Console.WriteLine("You guessed it!");
            break;
        }
        else if(playerNumber > computerNumber) 
        {
            Console.WriteLine("Too high");
        }
        else
        {
            Console.WriteLine("Too low");
        }
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
}