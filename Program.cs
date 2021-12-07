using System;

namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your best friend's name?");
            var friendsName = Console.ReadLine();

            Console.WriteLine("How did you meet your best friend?");
            var meetFriend = Console.ReadLine();

            Console.WriteLine("What is your favorite thing to do with your best friend?");
            var thingToDo = Console.ReadLine();


            Console.WriteLine($"My best friends name is {friendsName}.");
            Console.WriteLine($"I meet my best friend {meetFriend}.");
            Console.WriteLine($"My favorite thing to do with my best friend is {thingToDo}.");
         
        
            

        }
    }
}
