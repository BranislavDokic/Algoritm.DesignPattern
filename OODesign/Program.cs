using System.Reflection.Emit;

namespace OODesign
{
   
    internal class Program
    {
       

        static void Main(string[] args)
        {
            AuthenticationProxy authenticationProxy = new AuthenticationProxy();

            while (true)
            {
                Console.WriteLine("Welcome to User Management System!");
                Console.WriteLine("Would you like to login or create an account? (login/register)");
                string response = Console.ReadLine();

                if (response.ToLower() == "register")
                {
                    // User wants to register
                    Console.WriteLine("Please enter your desired username:");
                    string username = Console.ReadLine();

                    Console.WriteLine("Please enter your password:");
                    string password = Console.ReadLine();

                    // Builder Pattern - User Creation
                    var userBuilder = new UserBilder(username, password);

                    Console.WriteLine("Please enter your email:");
                    string email = Console.ReadLine();
                    userBuilder.SetEmail(email);

                    Console.WriteLine("Please enter your age:");
                    int age;
                    while (!int.TryParse(Console.ReadLine(), out age))
                    {
                        Console.WriteLine("Invalid age. Please enter a valid age:");
                    }
                    userBuilder.SetAge(age);

                    var user = userBuilder.GetBild();

                    // Register the user
                    authenticationProxy.Register(user.UserName, user.Password);
                }
                else if (response.ToLower() == "login")
                {
                    // User wants to login
                    Console.WriteLine("Please enter your username:");
                    string loginUsername = Console.ReadLine();

                    Console.WriteLine("Please enter your password:");
                    string loginPassword = Console.ReadLine();

                    if (authenticationProxy.LogIn(loginUsername, loginPassword))
                    {
                        // Chain of Command Pattern - Authentication
                        AuthanticationHandler usernameHandler = new UsernameAuthanticationHandler();
                        AuthanticationHandler passwordHandler = new PasswordAuthanticationHandler();
                        usernameHandler.SetNextHandler(passwordHandler);

                        usernameHandler.Authenticate(loginUsername, loginPassword);
                        SortingManu sortingManu = new SortingManu();
                        sortingManu.Manu();

                    }
                }
                else
                {
                    Console.WriteLine("Invalid option. Please select either 'login' or 'register'.");
                }
            }

        }
    }
}
