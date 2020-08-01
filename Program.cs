using System;

namespace _5_4_Lab_Creating_Mario
{
    class Program
    {
        public struct Mario // Structure for the Mario Character
        {
            public enum Size
            {
                small, 
                large
            }

            public int numOfLives;
            public string currentLevel;
            public Size sizeOfMario;
            public bool canShootFireBalls;
            public bool isJumping;
            public int numOfCoins;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Our Mario with default values
            Mario mario = new Mario();
            mario.numOfLives = 3;
            mario.currentLevel = "World 1-1";
            mario.sizeOfMario = Mario.Size.small;
            mario.canShootFireBalls = false;
            mario.isJumping = false;
            mario.numOfCoins = 25;
            //Adding in the starter code to simulating Mario (mario) as he progresses

            Console.WriteLine("Mario is running through the level and meets a Gooba. Set Mario to jumping so he can kill it");
            //enter your code here.
            mario.isJumping = true;
            
            Console.WriteLine("Mario squashes the Gooba. Now he needs to land!");
            //enter your code here.
            mario.isJumping = false;

            Console.WriteLine("Mario hits a block and finds a 1UP. Increase Mario's life by one.");
            //enter your code here.
            mario.numOfLives = mario.numOfLives + 1;

            Console.WriteLine("Mario finds a secret Fire Flower and can now shoot fireballs. Change mario!");
            //enter your code here.
            mario.canShootFireBalls = true;

            Console.WriteLine("Mario finds another power up mushroom and gets big. Change Mario");
            //enter your code here.
            mario.sizeOfMario = Mario.Size.large;

            Console.WriteLine("Mario finds a stash of gold coins. Give Mario 10 coins.");
            //enter your code here.
            mario.numOfCoins = mario.numOfCoins + 10;

            Console.WriteLine("Mario finshes the level! Change Mario's current level to World 1-2");
            //enter your code here.
            mario.currentLevel = "World 1-2";
        }
    }
}
