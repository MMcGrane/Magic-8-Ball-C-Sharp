using System;

namespace Magic_8_Ball
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();

            string[] answers = { "Yes", "No", "Not a chance!", "The Stars say No", "The Stars say yes",
            "Maybe", "I don't know!", "Better not tell you.", "Without a doubt", "Very doubtful", 
            "You may rely on it", "Ask yourself!"
            };


            Console.WriteLine("Welcome To Magic 8 Ball! \n");

            Console.WriteLine("Please ask your question! \n");
            string question = Console.ReadLine();

            Console.WriteLine("You asked " + question + "\n");
            Console.WriteLine(answers[r.Next(0, answers.Length)]);
        }
    }
}
