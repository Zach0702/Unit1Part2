using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Recommendations
{
    class funTimes
    {
      static void whatVehicle(int option)  //Function to determine what vehicle to drive
        {
            if (option == 0)
            {
                Console.WriteLine("you should travel in sneakers");
            }
            else if (option == 1 || option <= 4)
            {
                Console.WriteLine("you should travel in a sedan");
            }
            else if (option == 5 || option <= 10)
            {
                Console.WriteLine("you should travel in a bus");
            }
            else if (option >= 11)
            {
                Console.WriteLine("you should travel in an air plane");
            }
        }
        static void Main(string[] args)
        {
            //variable declaration
            int userOption1;  //variable for user option
            int userOption2; //variable for second user option

            //Asking user what they are in the mood for
            Console.WriteLine("Greetings user, what are you looking to do: ?");
            Console.WriteLine("1. Action");
            Console.WriteLine("2. Chilling");
            Console.WriteLine("3. Danger Danger");
            Console.WriteLine("4. That good food");
            Console.WriteLine("Please select an option: ");

            //Reading in user input
            
            //Converting input to int
            userOption1 = Convert.ToInt32(Console.ReadLine());

            //Making sure user entered in valid choice
            while(userOption1 < 1 || userOption1 > 4)
            {
                Console.WriteLine("ERROR: You have entered an invalid choice please try again.");
                Console.WriteLine();
                //Asking user what they are in the mood for
                Console.WriteLine("Greetings user, what are you looking to do: ?");
                Console.WriteLine("1. Action");
                Console.WriteLine("2. Chilling");
                Console.WriteLine("3. Danger Danger");
                Console.WriteLine("4. That good food");
                //Reading in user input

                //Converting input to int
                userOption1 = Convert.ToInt32(Console.ReadLine());
            }

            //clear line
            Console.WriteLine();

            //Asking user how many people are coming with them
            Console.WriteLine("How many people will be in your party?");
            //Reading in user input
           
            //Converting input to int variable type
            userOption2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

       

            //Displaying results on what user should do with if statements

            if (userOption1 == 1)
            {
                Console.WriteLine("Looks like you're in the mood for action you should go see a movie and "); whatVehicle(userOption2);
            }

            else if (userOption2 == 2)
            {
                Console.WriteLine("Looks like you're in the mood for chilling you should go to your freinds house and "); whatVehicle(userOption2);

            }

            else if (userOption2 == 3)
            {
                Console.WriteLine("Looks like you're in the mood for danger you should go mountain climbing and "); whatVehicle(userOption2);

            }

            else
            {
                Console.WriteLine("Looks like you're in the mood for some good food you should go to Slows BBQ and "); whatVehicle(userOption2);

            }

            //Exiting APP
            Console.WriteLine();
            Console.WriteLine("End of Application");

            //SystemPause
            Console.ReadKey();

        }
    }
}
