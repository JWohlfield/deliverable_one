using System;

namespace Deliverable1
{
    /*
        Author:   Jeffrey Wohlfield
        Date  11-24-2020
        
        This program will prompt for a user password and run validation against the user input
        The password must contain:
            At least one lower case letter
            At least one upper case letter
            A minimum of 7 characters
            A maximum of 12 characters
            An exclamation point
    */
    class Program
    {
        static void Main(string[] args) { 

            string input;
            bool valid = false;
                
                //Display password parameters    
            Console.WriteLine("The Password must contain:\n\tAt least one lower case letter\n\tAt least one upper case letter" +
                    "\n\tA minimum of 7 characters\n\tA maximum of 12 characters\n\tAn exclamation point\n");
            
            while (!valid)
            {
                //Prompt for input
                Console.Write("Please enter a password: ");
                input = Console.ReadLine();

                //Run all validation against entered password
                if (HasUpperLowerSpecial(input))
                {
                    Console.WriteLine("Password valid and accepted");
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
        public static bool HasUpperLowerSpecial(string text)
        {
            bool hasUpper = false; bool hasLower = false; bool hasSpecial = false;
            if (text.Length >= 7 && text.Length <= 12)
            {
                for (int i = 0; i < text.Length && !(hasUpper && hasLower && hasSpecial); i++)
                {
                    char c = text[i];
                    if (!hasUpper) hasUpper = char.IsUpper(c);
                    if (!hasLower) hasLower = char.IsLower(c);
                    if (!hasSpecial) hasSpecial = char.Equals(c, '!');
                }
            }
            return hasUpper && hasLower && hasSpecial;
        }
    }
}
