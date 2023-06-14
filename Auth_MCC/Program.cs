namespace Auth_MCC
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("=====BASIC AUTHENTICATION=====");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1. Create User");
                Console.WriteLine("2. Show User");
                Console.WriteLine("3. Search User");
                Console.WriteLine("4. Login User");
                Console.WriteLine("5. Exit");
                Console.WriteLine("-------------------------------");
                Console.Write("Input : ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty.");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu();

                }
                if (!int.TryParse(input, out int Input))
                {
                    Console.WriteLine("Input must be a number.");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu();
                }
                if (int.TryParse(input, out int choice))
                {
                    Console.Clear();
                    switch (choice)
                    {
                        case 1:
                            User.CreateUser();
                            Console.Clear();
                            break;
                        case 2:
                            User.ShowUser();
                            Console.Clear();
                            break;
                        case 3:
                            User.SearchUser();
                            Console.Clear();
                            break;
                        case 4:
                            User.LoginUser();
                            Console.Clear();
                            break;
                        case 5:
                            System.Environment.Exit(0);
                            return;
                        default:
                            Console.WriteLine("Invalid input");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
            }
        }
    }
}