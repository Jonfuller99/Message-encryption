/**
* Proj10.cs
* Jon Fuller / Thursday 2:30
* This program lets users encrypt and decrypt messages using a simple method called the Caesar cipher. 
* First, it asks for a secret number (the encryption key) and a message. Then, it scrambles the message 
* based on the secret number. Afterward, it unscrambles the message back to its original form. Finally, it 
* displays both the scrambled and unscrambled messages on the screen. You can also pause and view the results
* before the program exits.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create View object
            View v = new View();

            // Comment out line above / Uncomment this line for GUI Display
            //View_GUI v = new View_GUI();

            int key = v.GetKey();

            // Create Cipher object

            String msg = v.GetMessage();
            Cipher c = new Cipher(key, msg);

            
            c.Encrypt(msg);
            String enc = c.ToString();
            v.DisplayResult("\nEncrypted: " + enc);

            c.Decrypt(enc);
            enc = c.ToString();
            v.DisplayResult("Decrypted: " + msg);
            v.HoldScreen();
            
        }
    }
}
