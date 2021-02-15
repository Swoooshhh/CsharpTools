using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            files data = new files();
            string filelocation = "C:\\Users\\Swoos\\Documents\\c.txt";
            do
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1: Find someone, 2: Add someone to the list, 3: Exit : ");
                string response = Console.ReadLine();
                if (response == "1")
                {
                    Console.WriteLine("Who would you like to find? : ");
                    string name = Console.ReadLine();
                    data.filefind(filelocation, name);
                }
                else if (response == "2")
                {
                    Console.WriteLine("What's the name of the person you'd like to add? : ");
                    string name2add = Console.ReadLine();
                    Console.WriteLine("What's their address? : ");
                    string address = Console.ReadLine();

                    data.filewrite(filelocation, name2add, address);
                }
                else if (response == "3")
                {
                    Console.WriteLine("Bye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice. Choose 1-3");
                }

            } while (true);

        }
    }
}
