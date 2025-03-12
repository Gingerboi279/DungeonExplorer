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
    }
}