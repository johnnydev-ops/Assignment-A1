using System;
//Jonatan Rassekhnia
//Programming in C#
//02-07-2021
//professor Farid
//Malmö Univeristy 
namespace Assignment1A
{
    //Pet Owner Main program, Main controls where it executes the console application
    //for the console application. Class pet owner main is created into the main program
    class PetOwnerMain
    {

        //Main program for Pet Application and it constructed by objects and it calls its method

        static void Main(string[] args)

        {
            //Design the Console Application with a Console Title
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Title = "Jdog's Pet Owner";


            //Decale and execute a pet object
            Pet myPet = new Pet();
            //Run the method on pet object
            myPet.Start();
            //Print out Exit message to user on cosole application
            Console.WriteLine("Press Enter to Exit");
            //Waits for user input
            Console.ReadLine();
            //DateTime prints out on the console application
            Pet myDateTime = new Pet();



        }
    }
}