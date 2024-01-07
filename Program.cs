using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try //this command will run the code below 
            {
                Console.WriteLine("Pick a number.");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick another number.");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Quotien is: " + (num1 / num2));
                Console.ReadLine();

            }
            catch(FormatException ex) //the catch will catch an error if the format inputted by the user does not meet the datatype - in this case it's an int data type
            {
                //Console.WriteLine(ex.Message);//this is a system generated message
                Console.WriteLine("Please enter a whole number");
            }
            Console.ReadLine();




        }
    }
}
