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
            mario.canShootFireBall = false;
            mario.isJumping = false;
            mario.numOfCoins = 25;



    }
    }
}
