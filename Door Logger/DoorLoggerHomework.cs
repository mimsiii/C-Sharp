using System;
using System.Collections.Generic;
using System.IO;

namespace DoorLogger
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Dictionary<string, bool> people = new Dictionary<string, bool>();
                people.Add("Adeline", false);
                people.Add("Mario", false);
                people.Add("John", false);

                if (!File.Exists("logIn.txt"))
                {
                    File.Create("logIn.txt").Close();
                }

                Console.Write("Enter persons name to enter/leave the building: ");
                string logInName = Console.ReadLine();

                if (people.ContainsKey(logInName))
                {
                    if (people[logInName] == false)
                    {
                        people[logInName] = true;
                        File.AppendAllLines("logIn.txt", new string[] { logInName + " entered" });
                    }
                    else
                    {
                        people[logInName] = false;
                        File.AppendAllLines("logIn.txt", new string[] { logInName + " exited" });
                    }
                }

                else
                {
                    Console.WriteLine("Not found.");
                }

                Console.WriteLine("Press number 0 to close or any other key to continue");
                var answer = Console.Read();
                
                if(answer == 0)
                {
                    break;
                }
            }
        }
    }
}
