using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;

namespace RentC
{

    public class Menu
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
        }

        public static void RegRent() //Car Rent Registration screen
        {
            Console.Clear();
            Console.WriteLine("Opening the car rent registration form.");
            Application.Run(new RegRentForm());
            Console.WriteLine("Car rent registration finished. Press ESC to return to the menu. Press ENTER to repeat the operation.\n ");
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter) RegRent();
            if (key.Key == ConsoleKey.Escape) MMenu();

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
            Console.Clear();

            string strMMenu = "//  1. Register new Car Rent/  2. Update Car Rent/  3. List Rents/  4. List Available Cars/  5. Register new Customer/  6. Update Customer/  7. List Customers/  8. Quit///////    Enter the number of your choice and press (ENTER) to confirm the selection./////";
            Console.Write(strMMenu.Replace("/", System.Environment.NewLine));

            
            bool valid = false; //Precaution for unexpected operations on do while loop

            var key = Console.ReadKey(true); //Save the key pressed


            do  //Switch cases not working due "key"'s variable type. Cannot reiterate "key" without using "input".   Todo: Check alternatives to Console.ReadKey while keeping the semi-recursive loop structure.
            {
                
                if (key.Key == ConsoleKey.D1 | key.Key == ConsoleKey.NumPad1)
                {
                    Console.WriteLine(" Current selection: 1. Register new Car Rent. Press ENTER to confirm.            ");

                    var input = Console.ReadKey(true);
                    key = input;

                    if (key.Key == ConsoleKey.Enter)
                    {
                        RegRent();  //Call car rent registration screen
                        valid = true;
                    }

                    Console.SetCursorPosition(0, Console.CursorTop - 1);  //Set cursor to overwrite the last line

                }

                else if (key.Key == ConsoleKey.D2 | key.Key == ConsoleKey.NumPad2)
                {
                    Console.WriteLine(" Current selection: 2. Update Car Rent. Press ENTER to confirm.                  ");

                    var input = Console.ReadKey(true);
                    key = input;

                    if (key.Key == ConsoleKey.Enter)
                    {
                        UpRent();  //Call car rent update screen
                        valid = true;
                    }

                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                }

                else if (key.Key == ConsoleKey.D3 | key.Key == ConsoleKey.NumPad3)
                {
                    Console.WriteLine(" Current selection: 3. List Rents. Press ENTER to confirm.                       ");

                    var input = Console.ReadKey(true);
                    key = input;

                    if (key.Key == ConsoleKey.Enter)
                    {
                        ListRent();  //Call Rent List screen
                        valid = true;
                    }

                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                }

                else if (key.Key == ConsoleKey.D4 | key.Key == ConsoleKey.NumPad4)
                {
                    Console.WriteLine(" Current selection: 4. List Available Cars. Press ENTER to confirm.              ");

                    var input = Console.ReadKey(true);
                    key = input;

                    if (key.Key == ConsoleKey.Enter)
                    {
                        ListCar();  //Call Available Car List screen
                        valid = true;
                    }

                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                }

                else if (key.Key == ConsoleKey.D5 | key.Key == ConsoleKey.NumPad5)
                {
                    Console.WriteLine(" Current selection: 5. Register new Customer. Press ENTER to confirm.            ");

                    var input = Console.ReadKey(true);
                    key = input;

                    if (key.Key == ConsoleKey.Enter)
                    {
                        RegCust();  //Call Customer Registeration screen
                        valid = true;
                    }

                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                }

                else if (key.Key == ConsoleKey.D6 | key.Key == ConsoleKey.NumPad6)
                {
                    Console.WriteLine(" Current selection: 6. Update Customer. Press ENTER to confirm.                  ");

                    var input = Console.ReadKey(true);
                    key = input;

                    if (key.Key == ConsoleKey.Enter)
                    {
                        UpCust();  //Call Customer Update screen
                        valid = true;
                    }

                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                }

                else if (key.Key == ConsoleKey.D7 | key.Key == ConsoleKey.NumPad7)
                {
                    Console.WriteLine(" Current selection: 7. List Customers. Press ENTER to confirm.                   ");

                    var input = Console.ReadKey(true);
                    key = input;

                    if (key.Key == ConsoleKey.Enter)
                    {
                        ListCust();  //Call Customer List screen
                        valid = true;
                    }

                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                }

                else if (key.Key == ConsoleKey.D8 | key.Key == ConsoleKey.NumPad8)
                {
                    Console.WriteLine(" Are you sure you want to quit? Press ENTER to confirm.                          ");

                    var input = Console.ReadKey(true);
                    key = input;

                    if (key.Key == ConsoleKey.Enter) Environment.Exit(0);  //Exit the app

                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                }

                //Todo: Create report menu

                else
                {
                    Console.WriteLine(" This is not a valid option.                                                     ");  //Display Error Message

                    var input = Console.ReadKey(true);
                    key = input;

                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                }

            }
            while (!valid);

        }
    }

    public class Program
    {
        [STAThread]  //Enables the use of STA model for Windows Forms compatibility

        public static void Main(string[] args)
        {

            Application.EnableVisualStyles(); //Forms compatibility, enables visual styles for the app
            Application.SetCompatibleTextRenderingDefault(false); //Forms compatibility, alters TextRenderer behavior

            Menu.Welc(); //Call Welcome screen

            Menu.MMenu(); //Call Main menu

        }
    }
}
