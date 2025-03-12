using System;
using System.Media;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private Room currentRoom;
        private Random random;




        public Game()
        {
            // Initialize the game with one room and one player
            player = new Player("Joe");
            rooms = new Room[]
            {
                new Room("A dark and ominous cave with the sound of dripping water somewhere in the distance");
                new Room("A quiet forest clearing with the faint smell of flowers");
                new Room("An abandoned castle room with broken furniture and dust");
            }
            playing = true;
        }
        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = false;
            while (playing)
            {
               PathwayChoice()
                int choice = GetUserChoice();

                if (choice == 1, choice == 2, choice == 3)
                {
                    VisitRoom(choice);
                }
                else if (choice == 4)
                {
                    player.ShowInventory();
                }
                else if (choice == 5)
                {
                    playing = false;
                    Console.WriteLine("Thank you for playing Dungeon Explorer! Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

            }
        }

        private void PathwayChoice()
        {
            Console.WriteLine("1. Visit Room 1");
            Console.WriteLine("2. Visit Room 2");
            Console.WriteLine("3. Visit Room 3");
            Console.WriteLine("4. View Inventory");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");
        }
        private void GetUserChoice()
        {
            int choice;
            while (choice < 1 or choice > 5)
            {
                console.Write("it appears you entered an invalid number, please try again");
            }
            return choice;
        }
        private void VisitRoom(int roomNumber)
        {
            Room room = rooms[roomNumber - 1];
            Console.WriteLine($"\nYou have entered a room: {room.Description}");
            Console.WriteLine($"You see a {room.Item} on the ground.");

            Console.Write("Would you like to pick it up? (y/n): ");
            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                player.PickUpItem(room.Item);
            }
            else
            {
                Console.WriteLine("You chose not to pick up the item.");
            }
        }
    }
}