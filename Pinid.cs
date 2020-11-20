using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your contact number");
            string contactNumber = Console.ReadLine();

            Console.Write("Your Unique Id in organisation is:");
            char[] firstNameChar = firstName.ToCharArray(0, 2);
            Console.Write(firstNameChar);

            char[] lastNameChar = lastName.ToCharArray(0, 2);
            Console.Write(lastNameChar);

            char[] contactNumberChar = contactNumber.ToCharArray(0, 2);
            Console.WriteLine(contactNumberChar);        
        }
    }
}