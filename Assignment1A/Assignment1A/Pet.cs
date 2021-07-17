using System;
using System.Collections.Generic;
using System.Text;
//Jonatan Rassekhnia
//Programming in C#
//02-07-2021
//professor Farid
//Malmö Univeristy
namespace Assignment1A
{

    //Pet class is constructed here, the main object for the Pet Application
    //that will run and store the instance fields of the objects created.
  
    class Pet
    {
        //Declare the three variables as stated in instructions, name of the pet, age as an integer, 
        //true if female, false otherwise, with a little explantion to it. 
        private string name; //Private string constructed to string the name
        private int age; //Private integer to complete itself "age"
        private bool isFemale; //Private bool is contructed to know it he difference between the genders

        //Main start up where it executes the main controls of the console
        public void Start()
        {
            Console.WriteLine("Welcome to Jdog Pet Application");
            Console.ForegroundColor = ConsoleColor.DarkGray;//color for welcome print
            Console.ResetColor();//resets Color
            Console.WriteLine("-------------");//Design space
            Console.WriteLine("§§Welcome§§"); // Welcome print
            Console.WriteLine("-------------");//Design space

            ReadAndSavePetData();
            DisplayPetInfo();
            
        }
        
        //Method Constructed to read user input with pet information
        public void ReadAndSavePetData()
        {
            //Lets User know about the Pet Name
            ReadName();
            //Lets User know about the Pet Age
            ReadAge();
            //Lets User know if it a Male or Female
            ReadGender();
            //Lets User know about the DateTime
            ReadDateTime();
        }

        //Method that reads and saves the Name
        public void ReadName()
        {
            Console.Write("§§§What is the name of your pet?§§§");
            name = Console.ReadLine();
        }

        //Method that reads and saves the age while being printed on the console
        public void ReadAge()
        {
            Console.Write("What is the age of " + name + "?: ");
            string textValue = Console.ReadLine();
            age = int.Parse(textValue); //converts the string to a number
        }

        //This method Reads and Saves a Pet's Gender
        //to choose between the genders
        public void ReadGender()
        {
            Console.Write("What gender is your pet? Y/N");
            char response = char.Parse(Console.ReadLine());
            if ((response == 'y') || (response == 'Y')) //controls Yes or No by the users Input
                isFemale = true;
            else
                isFemale = false;
        }
        
        //Method to Display the pet information on the console application
        public void DisplayPetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("§§++++++++++++++++++++++++++++++++§§");
            string textOut = "Name: " + name + " Age: " + age;
            Console.WriteLine(textOut);
            if (isFemale)
                Console.WriteLine(name + " !GoodGirl! ");
            else
                Console.WriteLine(name + " !GoodBoy! ");
          
            Console.WriteLine("§§++++++++++++++++++++++++++++++++§§");
            Console.WriteLine();


        }
        //DateTime Method to be display on the console application
        //i dont think this was part of the assignment but was self learning about it
        public void ReadDateTime()
        {
            //The lesson of this Datetime Structure. Which includes year, month, date, hour, minutes, seconds
            //My Parameters were selected on my birthday 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PetOwners Date of Birth");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            
            var date01 = new DateTime(2009, 12, 28, 7, 15, 45);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(date01);

            //DateTime Properties 
            var date02 = DateTime.Now;
            var date03 = DateTime.UtcNow;
            var date04 = DateTime.Today;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Current Time and Date");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(date02);
            Console.WriteLine(date03);
            Console.WriteLine(date04);
            

            //DateTime Methods 
            //Adding or Subtracting days/time
            var tomorrow = date02.AddDays(1);
            Console.WriteLine(tomorrow);

            //DateTime Formats
            //added color to the lines as well
            //Display the print of DateTime Constucted intomy pet application
            Console.WriteLine(date02.ToString());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Authorized on the following Date");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(date02.ToString("yy-MM-dd"));
            Console.ResetColor();



        }
    }
}
