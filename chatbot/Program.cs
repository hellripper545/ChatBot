using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shutdown = false;
            bool notFound;
            string inputValue;
            string outputValue = "";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Computer : Hello!");
            Console.WriteLine("");
            Console.ResetColor();
            while (!shutdown)
            {
                notFound = false;
                Console.Write("User :");
                
                inputValue = Console.ReadLine().ToLower();
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Computer : ");
                
                switch (inputValue)
                {
                    case "hello":
                    case "hi":
                    case "hai":
                    case "hella":
                    case "yo":
                        outputValue = "i've just said hello";
                        notFound = true;
                         break;
                    case "tell me a joke":
                        outputValue = "Go and look at your mirror :p";
                        notFound = true;
                        break;
                    case "sing a song ":
                        outputValue = "really? do you want to die now :v";
                        notFound = true;
                        break;
                    case "bye":
                    case "cya":
                    case "goodbye":
                    case "see you":
                        outputValue = "Goodbye";
                        notFound = true;
                        break;
                    case "how are you":
                        outputValue = "i'm fine! what about you?";
                        notFound = true;
                        break;
                    case "whats up":
                    case "how was you doing":
                    case "how are you":
                        outputValue = "come on i'm doing well";
                        notFound = true;
                        break;
                    case "what is your father name":
                        outputValue = "It's basically sai teja :p who created me ";
                        notFound = true;
                        break;

                }
                if (notFound)
                {
                    Console.WriteLine(outputValue);
                }
                else
                {
                    Console.WriteLine("No response found.");
                }
                Console.WriteLine("");
                Console.ResetColor();
            }
        }
    }
}
