using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            ///Variables
            ///
            string userResponse;
            string userName = null;
            double mpg;
            double gallonsPerTank;
            double milesPerTank;
            string userClass = null;
            string userDirection;

            ///
            ///Setup the console
            ///
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.CursorVisible = false;
            Console.CursorSize = 100;
			///
			/// opening screen
			/// 
			DisplayWelcomeScreen();

			///
			/// Name asking
			/// 
			DisplayGetUsername(userName);

			DisplayContinuePrompt();

			///
			/// Second Variable
			/// 

			DisplayGetClass(userClass);

			DisplayContinuePrompt();
            

            ///
            /// Waking up
            /// 

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("You awake, in a dark corridor that is made up of a smooth rock that in the dark you can barely make out is a tan color. You stand and begin to make your way in the dark down one way of the corridor before you reach a fork in the path. Which way do you go? Left or Right?");
            userDirection = Console.ReadLine();
            if (userDirection == "Left")
            {
                Console.WriteLine("You walk towards the left and continue for what feels like days before exhaustion overtakes you and collapse, your vision begins to fade but before it does you can hear the heavy breathing and foot steps of a massive beast before you lose consciousness, to never awake again.");
            }
            else if (userDirection == "Right")
            {
                Console.WriteLine("You walk till you reach a well lit chamber with writing on a large stone door, it reads ");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("What is 7+7?");
                userResponse = Console.ReadLine();
                mpg = double.Parse(userResponse);

                Console.WriteLine("What is 8+12?");
                userResponse = Console.ReadLine();
                gallonsPerTank = double.Parse(userResponse);

                milesPerTank = mpg + gallonsPerTank;
                Console.ForegroundColor = ConsoleColor.Black;
                if (milesPerTank == 34)
                {
                    Console.WriteLine("The door before you slowly lurches open revealing a large open field and the sun shining brightly, allowing you to leave the maze.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" 'You win this time {0}.' ", userClass);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("A voice echos out behind you before the door suddenly slams shut.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Suddenly a blast of blue energy arcs from the door, htting the center of your chest causing your vision to quickly fade to black and your consciousness follows it shortly.");
                    Console.ReadLine();
                }
            }

			DisplayContinuePrompt();
            Console.ForegroundColor = ConsoleColor.Black;

            ///
            /// Closing screen
            /// 
            DisplayClosingPrompt(userName);
        }

		static string DisplayGetUsername(string userName)
		{
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine("What is your name, intruder?");
			userName = Console.ReadLine();
			Console.WriteLine();
			Console.WriteLine(userName + " is it? Well try to escape my maze.");

			return userName;
		}

		static string DisplayGetClass(string userClass)
		{
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine("So Intruder, what would you call yourself? A wizard? A Rogue?");
			userClass = Console.ReadLine();
			if (userClass == "wizard")
			{
				Console.WriteLine("Well a simple hedge mage is no match for my creation.");
			}
			else if (userClass == "knight")
			{
				Console.WriteLine("You simple fool, all you can do is swing a sword.");
			}
			else if (userClass == "rogue")
			{
				Console.WriteLine("Oh so you are a thief!");
			}
			else
			{
				Console.WriteLine("I haven't heard of your kind before but I'm sure you are known for trouble.");
			}

			DisplayContinuePrompt();
			return userClass;
		}

		static void DisplayWelcomeScreen()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to my maze.");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void DisplayClosingPrompt(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Thank you for stopping by {0}!", userName);
            DisplayContinuePrompt();
        }

        static void DisplayContinuePrompt()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Press any button you want to escape.");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
