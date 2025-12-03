namespace TextAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the adventure game !");
            Console.WriteLine("Enter your characters name");
            string playerName = Console.ReadLine();
            Console.WriteLine("Choose your character's type (Warrior,Wizard,Archer)");
            string characterType= Console.ReadLine();

            Console.WriteLine($"You {playerName} the {characterType} find your self at the edge of a dark forest");
            Console.WriteLine("Do you enter the forest or camp outside? (Enter/Camp)");

            string choice1 = Console.ReadLine();

            if(choice1.ToLower() == "enter")
            {
                Console.WriteLine("You bravely entered the forest");
                    
            }
            else
            {
                Console.WriteLine("You decided to camp outside and wait for daylight");
            }

            bool gameContinues = true;

            while (gameContinues)
            {
                Console.WriteLine("You come to a fork in the road. Go left or right?");
            
                string direction = Console.ReadLine();
                if(direction.ToLower() == "left")
                {
                    Console.WriteLine("You found a treasure ");
                    gameContinues= false;
                }
                else
                {
                    Console.WriteLine("You encounter a wild beast!");
                    Console.WriteLine("Fight or flee? (fight/flee)");   
                    string fightChoice = Console.ReadLine();   
                    if(fightChoice.ToLower() == "fight")
                    {
                        Random random = new Random();
                        int luck = random.Next(1, 11);
                        if (luck > 5)
                        {
                            Console.WriteLine("You beat the beast");
                            if (luck > 8)
                            {
                                {
                                    Console.WriteLine("The beast dropped a treasure");
                                }
                            }
                            else
                            {
                                Console.WriteLine("YOU DIED");
                                gameContinues = false;
                            }
                        }
                    }
                }

            }


            Console.ReadKey();

        }


    }
    
}
