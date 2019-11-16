using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentC
{
    class Menu
    {
        public static void Welc() //Welcome screen
        {
            string strWelc = "Welcome to RentC, your brand new solution to manage and control your company's data without missing anything.//////////////Press ENTER to continue or ESC to quit/";
            Console.Write(strWelc.Replace("/", System.Environment.NewLine));

            while (true)
            {
                var key = Console.ReadKey(true); //Save the key pressed
                if (key.Key == ConsoleKey.Escape) Environment.Exit(0);  //Exit the app
                if (key.Key == ConsoleKey.Enter) break;  //Break from loop, continue the app
            }

            Console.Clear();
        }

        public static void RegRent() //Car Rent Registeration screen
        {

        }

        public static void UpRent() //Car Rent Update screen
        {

        }

        public static void ListRent() //Rent Listing screen
        {

        }

        public static void ListCar() //Available Car Listing screen
        {

        }

        public static void RegCust() //Customer Registeration screen
        {

        }

        public static void UpCust() //Customer Update screen
        {

        }

        public static void ListCust() //Customer Listing screen
        {

        }

        public static void MMenu() //Main menu
        {
            string strMMenu = "//  1. Register new Car Rent/  2. Update Car Rent/  3. List Rents/  4. List Available Cars/  5. Register new Customer/  6. Update Customer/  7. List Customers/  8. Quit///////    Enter your choice and press (ENTER) to go to the selection./////";
            Console.Write(strMMenu.Replace("/", System.Environment.NewLine));

            
            bool valid = false; //Precaution for unexpected operations on do while loop

            var key = Console.ReadKey(true); //Save the key pressed

            do  //Switch cases not working due "key" variable type. Todo: Check alternatives to Console.ReadKey while keeping the semi-recursive loop structure.
            {
                
                if (key.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Current selection: 1. Register new Car Rent. Press ENTER to confirm.            ");

                    var input = Console.ReadKey(true);
                    key = input;

                    if (key.Key == ConsoleKey.Enter)
                    {
                        RegRent();
                        valid = true;
                    }

                    Console.SetCursorPosition(0, Console.CursorTop - 1);  //Clear last line

                }

                else if (key.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("Current selection: 2. Update Car Rent. Press ENTER to confirm.                  ");

                    var input = Console.ReadKey(true);
                    key = input;

                    if (key.Key == ConsoleKey.Enter)
                    {
                        UpRent();
                        valid = true;
                    }

                    Console.SetCursorPosition(0, Console.CursorTop - 1);  //Clear last line

                }

                else if (key.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("Current selection: 3. List Rents. Press ENTER to confirm.                       ");

                    var input = Console.ReadKey(true);
                    key = input;

                    if (key.Key == ConsoleKey.Enter)
                    {
                        ListRent();
                        valid = true;
                    }

                    Console.SetCursorPosition(0, Console.CursorTop - 1);  //Clear last line

                }

                else if (key.Key == ConsoleKey.D4)
                {
                    Console.WriteLine("Current selection: 4. List Available Cars. Press ENTER to confirm.              ");

                    var input = Console.ReadKey(true);
                    key = input;

                    if (key.Key == ConsoleKey.Enter)
                    {
                        ListCar();
                        valid = true;
                    }

                    Console.SetCursorPosition(0, Console.CursorTop - 1);  //Clear last line

                }

                else if (key.Key == ConsoleKey.D5)
                {
                    Console.WriteLine("Current selection: 5. Register new Customer. Press ENTER to confirm.            ");

                    var input = Console.ReadKey(true);
                    key = input;

                    if (key.Key == ConsoleKey.Enter)
                    {
                        RegCust();
                        valid = true;
                    }

                    Console.SetCursorPosition(0, Console.CursorTop - 1);  //Clear last line

                }

                else if (key.Key == ConsoleKey.D6)
                {
                    Console.WriteLine("Current selection: 6. Update Customer. Press ENTER to confirm.                  ");

                    var input = Console.ReadKey(true);
                    key = input;

                    if (key.Key == ConsoleKey.Enter)
                    {
                        UpCust();
                        valid = true;
                    }

                    Console.SetCursorPosition(0, Console.CursorTop - 1);  //Clear last line

                }

                else if (key.Key == ConsoleKey.D7)
                {
                    Console.WriteLine("Current selection: 7. List Customers. Press ENTER to confirm.                   ");

                    var input = Console.ReadKey(true);
                    key = input;

                    if (key.Key == ConsoleKey.Enter)
                    {
                        ListCust();
                        valid = true;
                    }

                    Console.SetCursorPosition(0, Console.CursorTop - 1);  //Clear last line

                }

                else if (key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Are you sure you want to quit? Press ENTER to confirm.                          ");

                    var input = Console.ReadKey(true);
                    key = input;

                    if (key.Key == ConsoleKey.Enter) Environment.Exit(0);  //Exit the app

                    Console.SetCursorPosition(0, Console.CursorTop - 1);  //Clear last line

                }

                else
                {
                    MessageBox.Show("This is not a valid option.");

                    var input = Console.ReadKey(true);
                    key = input;

                }

            }
            while (!valid);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Menu.Welc(); //Call Welcome screen

            Menu.MMenu(); //Call Main menu

        }
    }
}
