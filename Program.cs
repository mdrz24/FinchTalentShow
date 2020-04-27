using System;
using System.Collections.Generic;
using System.IO;
using FinchAPI;

namespace Project_Capstone
{
    /// <summary>
    /// User Commmands
    /// </summary

    class Program
    {
        /// <summary>
        /// first method run when the app starts up
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SetTheme();

            DisplayWelcomeScreen();
            DisplayMenuScreen();
            DisplayClosingScreen();
        }

        /// <summary>
        /// setup the console theme
        /// </summary>
        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
        }


        /// <summary>
        /// *****************************************************************
        /// *                     Main Menu                                 *
        /// *****************************************************************
        /// </summary>
        static void DisplayMenuScreen()
        {
            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;

            Finch finchRobot = new Finch();

            do
            {
                DisplayScreenHeader("Main Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Connect Finch Robot");
                Console.WriteLine("\tb) Alphabet");
                Console.WriteLine("\tc) Disconnect Finch Robot");
                Console.WriteLine("\td) Quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        DisplayConnectFinchRobot(finchRobot);
                        break;

                    case "b":
                        DisplayLettersAlphabet(finchRobot);
                        break;

                    case "c":
                        DisplayDisconnectFinchRobot(finchRobot);
                        break;

                    case "d":
                        DisplayDisconnectFinchRobot(finchRobot);
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }

        static void DisplayLettersAlphabet(Finch finchRobot)
        {
            bool quitApplication = false;
            string answer;
            string userResponse;
            finchRobot.connect();
            do
            {
                Console.Clear();
                Console.WriteLine("would you like to have the finch trace out a letter?");
                answer = Console.ReadLine().ToLower();

                if (answer =="yes")
                {
                Console.WriteLine("Hey Pick a letter for the finch to move in the shape of ");
                userResponse = Console.ReadLine().ToLower();

                //
                //switch case
                //

                     switch (userResponse)
                     {
                      case "a":
                        Console.WriteLine("place the finch in a safe area to watch it shape into an A");
                        Console.ReadKey();
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(150, 0);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(150, 0);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(-150, -150);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(0, -150);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "b":
                        Console.WriteLine("here is your b");
                        Console.ReadKey();
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(-150, -150);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(500, 100);
                        finchRobot.wait(3000);
                        finchRobot.setMotors(0, 0);

                        break;

                      case "c":
                        Console.WriteLine("here is your c");
                        Console.ReadKey();
                        finchRobot.setMotors(300, 200);
                        finchRobot.wait(5000);
                        finchRobot.setMotors(0, 0);

                        break;

                      case "d":
                        Console.WriteLine("here is your d");
                        Console.ReadKey();
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(-150, -150);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(100, 500);
                        finchRobot.wait(3000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "e":
                        Console.WriteLine("here is your e");
                        Console.ReadKey();
                        finchRobot.setMotors(300, 200);
                        finchRobot.wait(4000);
                        finchRobot.setMotors(200, 50);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(300, 200);
                        finchRobot.wait(3000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "f":
                        Console.WriteLine("here is your f");
                        Console.ReadKey();
                        finchRobot.setMotors(150,150);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(150, 0);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(150, 150);
                        finchRobot.wait(1500);
                        finchRobot.setMotors(-150, -150);
                        finchRobot.wait(1500);
                        finchRobot.setMotors(-150, 0);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(150, 150);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(150, 0);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(150, 150);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "g":
                        Console.WriteLine("here is your g make sure you have this one vertical with nose pointing down ");
                        Console.ReadKey();
                        finchRobot.setMotors(100,300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(100,300);
                        finchRobot.wait(3000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "h":
                        Console.WriteLine("here is your h make sure you have this one vertical with nose pointing up ");
                        Console.ReadKey();
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(-150, -150);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(300, 150);
                        finchRobot.wait(2500);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "i":
                        Console.WriteLine("here is your i make sure you have this one vertical with nose pointing up ");
                        Console.ReadKey();
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "j":
                        Console.WriteLine("here is your j make sure you have this one vertical with nose pointing down ");
                        Console.ReadKey();
                        finchRobot.setMotors(100, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "k":
                        Console.WriteLine("here is your k make sure you have this one vertical with nose pointing up ");
                        Console.ReadKey();
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(-300, -300);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(50, 0);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(100, 100);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(-100, -100);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(100, 0);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(100, 100);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(0, 0);

                        break;

                      case "l":
                        Console.WriteLine("here is your l make sure you have this one vertical with nose pointing up ");
                        Console.ReadKey();
                        finchRobot.setMotors(100, 0);
                        finchRobot.wait(1500);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(-300, -300);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(-100, 0);
                        finchRobot.wait(1500);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "m":
                        Console.WriteLine("M");
                        Console.ReadKey();
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(100, 0);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(0, 100);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(100, 0);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "n":
                        Console.WriteLine("here is your N make sure you have this one vertical with nose pointing up ");
                        Console.ReadKey();
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(100, 0);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(0, 100);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "o":
                        Console.WriteLine("here is your o make sure you have this one vertical with nose pointing up ");
                        Console.ReadKey();
                        finchRobot.setMotors(300, 150);
                        finchRobot.wait(4000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "p":
                        Console.WriteLine("here is your p make sure you have this one vertical with nose pointing up ");
                        Console.ReadKey();
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(300, 100);
                        finchRobot.wait(3000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "q":
                        Console.WriteLine("here is your q make sure you have this one vertical with nose pointing up ");
                        Console.ReadKey();
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(100, 300);
                        finchRobot.wait(3000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "r":
                        Console.WriteLine("here is your r make sure you have this one vertical with nose pointing up ");
                        Console.ReadKey();
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(300, 100);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "s":
                        Console.WriteLine("here is your s make sure you have this horizontal with nose pointing to the right ");
                        Console.ReadKey();
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(100, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(300, 100);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "t":
                        Console.WriteLine("here is your t make sure you have this vertical with nose pointing to the up ");
                        Console.ReadKey();
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(100, 0);
                        finchRobot.wait(1500);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(-300, -300);
                        finchRobot.wait(3000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "u":
                        Console.WriteLine("here is your u make sure you have this vertical with nose pointing to the down ");
                        Console.ReadKey();
                        finchRobot.setMotors(150, 350);
                        finchRobot.wait(2700);
                        finchRobot.setMotors(-300, -300);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "v":
                        Console.WriteLine("here is your v make sure you have this vertical with nose pointing to the down ");
                        Console.ReadKey();
                        finchRobot.setMotors(0, 50);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(0, 100);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "w":
                        Console.WriteLine("here is your w make sure you have this vertical with nose pointing to the down ");
                        Console.ReadKey();
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(100, 0);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(0, 100);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(100, 0);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "x":
                        Console.WriteLine("here is your x make sure you have this vertical with nose pointing to the down ");
                        Console.ReadKey();
                        finchRobot.setMotors(0, 50);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(0, 100);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(-300, -300);
                        finchRobot.wait(4000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(100, 0);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(0, 0);
                        break;

                      case "y":
                        Console.WriteLine("here is your y make sure you have this vertical with nose pointing to the down ");
                        Console.ReadKey();
                        finchRobot.setMotors(0, 50);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(0, 100);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(2000);
                        finchRobot.setMotors(-300, -300);
                        finchRobot.wait(4000);
                        break;

                      case "z":
                        Console.WriteLine("here is your z make sure you have this horizontal with nose pointing to the left ");
                        Console.ReadKey();
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(200, 0);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(0, 200);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(300, 300);
                        finchRobot.wait(1000);
                        finchRobot.setMotors(0, 0);
                        break;
 
                      default:
                        Console.WriteLine(" Try using a letter of the alphabet");
                        break;
                     }

                }
                else
                {
                    DisplayDisconnectFinchRobot(finchRobot);
                    quitApplication = true;
                }

            } while (!quitApplication);
        }



        #region FINCH ROBOT MANAGEMENT

        /// <summary>
        /// *****************************************************************
        /// *               Disconnect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void DisplayDisconnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Disconnect Finch Robot");

            Console.WriteLine("\tAbout to disconnect from the Finch robot.");
            DisplayContinuePrompt();

            finchRobot.disConnect();

            Console.WriteLine("\tThe Finch robot is now disconnect.");

            DisplayMenuPrompt("Main Menu");
        }

        /// <summary>
        /// *****************************************************************
        /// *                  Connect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        /// <returns>notify if the robot is connected</returns>
        static bool DisplayConnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            bool robotConnected;

            DisplayScreenHeader("Connect Finch Robot");

            Console.WriteLine("\tAbout to connect to Finch robot. Please be sure the USB cable is connected to the robot and computer now.");
            DisplayContinuePrompt();

            robotConnected = finchRobot.connect();

            // TODO test connection and provide user feedback - text, lights, sounds

            DisplayMenuPrompt("Main Menu");

            //
            // reset finch robot
            //
            finchRobot.setLED(0, 0, 0);
            finchRobot.noteOff();

            return robotConnected;
        }

        #endregion

        #region USER INTERFACE

        /// <summary>
        /// *****************************************************************
        /// *                     Welcome Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tCapstone Project");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Closing Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using Finch Control!");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display menu prompt
        /// </summary>
        static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\tPress any key to return to the {menuName} Menu.");
            Console.ReadKey();
        }

        /// <summary>
        /// display screen header
        /// </summary>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion
    }
}
