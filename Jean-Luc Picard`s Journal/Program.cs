using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string input;
        string journal = "Captain's log\nStartdate " + DateTime.Now.ToString("yyyy-MM-dd") + "\n";
        bool isWriting = false;

        Console.WriteLine("Enter 'start' to begin writing in Jean-Luc Picard's journal, 'stop' to end writing.");

        while (true)
        {
            input = Console.ReadLine();
            if (input == "start")
            {
                isWriting = true;
                Console.WriteLine("Writing in Jean-Luc Picard's journal...");
            }
            else if (input == "stop")
            {
                isWriting = false;
                Console.WriteLine("Writing in Jean-Luc Picard's journal stopped.");
                break;
            }
            else if (isWriting)
            {
                journal += input + "\n";
            }
            else
            {
                Console.WriteLine("Please indicate an correct value !");
            }
        }

        journal += "Jean-Luc Picard";
        string fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
        File.WriteAllText(fileName, journal);
        Console.WriteLine("Jean-Luc Picard's journal saved in " + fileName);
    }
}
