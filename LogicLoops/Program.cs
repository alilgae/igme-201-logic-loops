namespace LogicLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = "adventurer";
            string userChoice = "NONE";

            Console.Write("Welcome to the jungle\n" +
                "We got fun and games\n" +
                "We got everything you want\n" +
                "Honey, we know the names\n\n");
            
            Console.WriteLine("Wait... I don't actually know your name.");
            Console.WriteLine("What is your name?");
            Console.WriteLine("[Please enter your name, then press 'ENTER' on the keyboard]");
            playerName = Console.ReadLine();

            Console.WriteLine("\nWelcome to the jungle " + playerName + "!");

            Console.WriteLine("" +
                "We approach a clearing in the jungle\n" +
                "There seems to be a trail to the left...\n" +
                "And a cave entrance to the right.\n"
                );
            Console.WriteLine("Which path do you chose?");
            Console.WriteLine("Type 'left' to choose the path and go left or type 'right' to choose the cave and go right.");
            userChoice = Console.ReadLine();
            Console.WriteLine("\nYou chose: " + userChoice + "\n");

            //Select our path
            while (userChoice != "left" && userChoice != "right")
            {
                userChoice = "NONE";
                Console.WriteLine("Please enter either \"left\" or \"right\".");
                userChoice = Console.ReadLine();
            }

            if (userChoice == "left")
                Console.WriteLine("Congrats, you found the exit!");
            else if (userChoice == "right")
                Console.WriteLine("You went into the cave when- Oh no! There was a cave-in and you're now stuck :(");
        }
    }
}
