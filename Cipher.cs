/**
* Cipher.cs
* Jon Fuller / Thursday 2:30
* The Cipher class has methods to encrypt and decrypt messages. The encryption method 
* takes a message and shifts each letter by a certain number of positions in the alphabet based 
* on a secret key. The decryption method reverses this process to reveal the original message. The class 
* also overrides the ToString() method to return the current message. This class is intended to be used in 
* conjunction with the main program to perform encryption and decryption tasks.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj10
{
    internal class Cipher
    {
        private int key;
        private string message;

        // Constructor - given to students	
        public Cipher(int k, string message)
        {
            key = k;
            this.message = message;
        } // end Constructor

        // Student creates	
        public void Encrypt(String message)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                int ascii = (int)message[i];
                ascii += key;

                if (ascii > 122)
                {
                    ascii = ((ascii - 97) % 26) + 97;
                }
                sb.Append((char)ascii);
            }

             this.message = sb.ToString();
        } // end encrypt()

        // Student creates	
        public void Decrypt(String message)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                int ascii = (int)message[i];
                ascii -= key;

                if (ascii < 97)
                {
                    ascii = ascii + 26;
                }

                // Regardless of key used, once decrypted, a ':' is a space			
                if (ascii == ':')
                    ascii = ' ';    // replace with a space

                sb.Append((char)ascii);
            }

            this.message = sb.ToString();
    
        } // end decrypt()


        public override string ToString() {
            return message;
        }


    }


}
