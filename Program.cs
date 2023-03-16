using System.Text.RegularExpressions;

namespace UserRegistrationLambda
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Master Branch of Lambda Expression Problem.");

            Console.WriteLine("Enter your Email Id: ");
            string name = Console.ReadLine();

            Func<string, bool> validate = (email) =>
                Regex.IsMatch(email, "^[A-Za-z0-9]+(.[a-zA-Z0-9]+)?@[a-zA-Z]+.[a-zA-Z]{2,}(.[A-Za-z]{2,})?$");

            if (validate(name))
            {
                Console.WriteLine("Valid Email Id");
            }
            else
            {
                Console.WriteLine("Invalid Email Id!");
            }
        }
    }
}