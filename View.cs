/**
* View.cs
* Jon Fuller / Thursday 2:30
* The View class has methods to get user input for a message and a secret key. The GetMessage() method 
* prompts the user to enter a message and returns it. The GetKey() method prompts the user to enter a 
* number between 1 and 25 and returns it as the secret key for encryption. It ensures that the input is 
* within the valid range and of the correct data type. The DisplayResult() method prints messages to 
* the console. The HoldScreen() method prompts the user to press any key to end the program, allowing 
* them to view the results before exiting.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj10
{
    internal class View
    {
       

        // Constructor - given to students	
        public View()
        {
            
        } // end Constructor

        // Student creates	
        public String GetMessage()
        {
            Console.Write("\nEnter message: ");
            return Console.ReadLine();
            
        } // end getMessage()

        // Student creates	
        public int GetKey()
        {
            bool validInput = false;
            int input = 0;
            while (!validInput)
            {
                try
                {
                    Console.Write("Enter a number from 0 to 25: ");
                    input = int.Parse(Console.ReadLine());

                    if (input > 0 && input < 26) {
                        validInput = true;
                    }
                    else {
                        Console.WriteLine("Error: KEY must be between 1-25 (inclusive)");     
                    }


                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: KEY must be an integer");
                }
            }// end while
            return input;   
        } // end getKey()

        // Student creates	
        public void DisplayResult(String msg)
        {
            Console.WriteLine(msg);
        } // end displayResult

        public void HoldScreen()
        {
            Console.WriteLine("Press and key to end program...");
            Console.ReadKey(true);
        } 

    }
}
