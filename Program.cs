using System;

namespace Methods_Wilson_Kenny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number!");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another whole number!");
            int y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Multiply(x,y));

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            WelcomeUser(name);

            Farewell();
        }
         
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        
        static void WelcomeUser(string username)
        {
            Console.WriteLine($"Hello,{username}! Hello it is nice to meet you!");
        }
            
        /// <summary>
        /// Prints a farewell message to the console
        /// </summary>
            static void Farewell()
        {
            Console.WriteLine("Have a fantastic day!");
        }
        

    }
}
