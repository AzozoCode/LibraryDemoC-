using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args)
    {
        Console.WriteLine("WELCOME");
        string[] Questions = new string[3]; // An array to contain the questions
        
        /* A conditional loop to store the questions typed into the array created */

        for (int i = 0; i < Questions.Length; i++) 
        {
            Console.WriteLine("Enter Question");
            Questions[i] = Console.ReadLine();
           

        }

        Console.WriteLine("");
        Console.WriteLine("Question One");
        Console.WriteLine(Questions[0]);
        Console.Write("Enter your Answer: ");
        string Answer1 = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine("Question Two");
        Console.WriteLine(Questions[1]);
        Console.Write("Enter your Answer: ");
        string Answer2 = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine("Question Three");
        Console.WriteLine(Questions[2]);
        Console.Write("Enter your Answer: ");
        string Answer3 = Console.ReadLine();







        Console.ReadKey();
    }
}
