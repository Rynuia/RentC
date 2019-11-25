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
            Console.Clear();
            Console.WriteLine("Car rent registration finished. Press ESC to return to the menu. Press ENTER to repeat the operation.\n ");
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter) RegRent();
            if (key.Key == ConsoleKey.Escape) MMenu();

        }

        public static void UpRent() //Car Rent Update screen
        {
            Console.Clear();
            Console.WriteLine("Opening the car rent update form.");
            Application.Run(new UpRentForm());
            Console.Clear();
            Console.WriteLine("Car rent update finished. Press ESC to return to the menu. Press ENTER to repeat the operation.\n ");
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter) UpRent();
            if (key.Key == ConsoleKey.Escape) MMenu();
        }

        public static void ListRent() //Rent Listing screen
        {
            Console.Clear();
            Console.WriteLine("Opening the car rent list.");
            Application.Run(new ListRentForm());
            Console.Clear();
            Console.WriteLine("Car rent listing finished. Press ESC to return to the menu. Press ENTER to repeat the operation.\n ");
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter) ListRent();
            if (key.Key == ConsoleKey.Escape) MMenu();
        }

        public static void ListCar() //Available Car Listing screen
        {
            Console.Clear();
            Console.WriteLine("Opening the car list.");
            Application.Run(new ListCarForm());
            Console.Clear();
            Console.WriteLine("Car listing finished. Press ESC to return to the menu. Press ENTER to repeat the operation.\n ");
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter) ListCar();
            if (key.Key == ConsoleKey.Escape) MMenu();
        }

        public static void RegCust() //Customer Registration screen
        {
            Console.Clear();
            Console.WriteLine("Opening the customer registration form.");
            Application.Run(new RegCustForm());
            Console.Clear();
            Console.WriteLine("Customer registration finished. Press ESC to return to the menu. Press ENTER to repeat the operation.\n ");
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter) RegCust();
            if (key.Key == ConsoleKey.Escape) MMenu();
        }

        public static void UpCust() //Customer Update screen
        {
            Console.Clear();
            Console.WriteLine("Opening the customer update form.");
            Application.Run(new UpCustForm());
            Console.Clear();
            Console.WriteLine("Customer update finished. Press ESC to return to the menu. Press ENTER to repeat the operation.\n ");
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter) UpCust();
            if (key.Key == ConsoleKey.Escape) MMenu();
        }

        public static void ListCust() //Customer Listing screen
        {
            Console.Clear();
            Console.WriteLine("Opening the customer list.");
            Application.Run(new ListCustForm());
            Console.Clear();
            Console.WriteLine("Customer listing finished. Press ESC to return to the menu. Press ENTER to repeat the operation.\n ");
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter) ListCust();
            if (key.Key == ConsoleKey.Escape) MMenu();
        }

        public static void MMenu() //Main menu
        {
            Console.Clear();

            string strMMenu = "//  1. Register new Car Rent/  2. Update Car Rent/  3. List Rents/  4. List Available Cars/  5. Register new Customer/  6. Update Customer/  7. List Customers/  8. Quit///////    Enter the number of your choice and press (ENTER) to confirm the selection./////";
            Console.Write(strMMenu.Replace("/", System.Environment.NewLine));

            
            bool valid = false; //Precaution for unexpected operations on do while loop

            var key = Console.ReadKey(true); //Save the key pressed


            do
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

                else
                {
                    Console.WriteLine(" This is not a valid option.                                                     ");  //Display Error Message

                    var input = Console.ReadKey(true);
                    key = input;

                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                }

            }
            while (!valid);

            Console.Clear();
            Console.WriteLine("Unexpected error. Press ENTER to return to the menu. Press ESC to exit the application.\n ");
            var ekey = Console.ReadKey(true);
            if (ekey.Key == ConsoleKey.Enter) MMenu();  //Reiterate the menu
            if (ekey.Key == ConsoleKey.Escape) Environment.Exit(0);  //Exit the app

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
