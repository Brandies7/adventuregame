using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventurestory.cs
{
    class Adventures
    {
        public string Adventure;
        public string ChooseJob;
        public string ChooseCollege;
        public string ChooseMilitary;
        public string CollegeChoice;
        public Adventures()
        {

        }

        public void startAdventure()
        {
            Console.WriteLine("Imagine, if you will, you're back in High School. It's graduation day and your teacher asks you, What are you going to do after you graduate? What is your response? Choose '1' To get a job. Choose '2' to go to college. or Choose '3' to join the military.");
            string Adventure = Console.ReadLine();

            switch (Adventure)
            {
                case "1":
                    chooseJob();
                    break;
                case "2":
                    chooseCollege();
                    break;
                case "3":
                    chooseMilitary();
                    break;
                default:
                    Console.WriteLine("Sorry, not a valid entry");
                    startAdventure();
                    break;

            }
        }

        public void chooseJob()
        {
            Console.WriteLine("What kind of job will you choose? 'janitor', 'factory', 'tradesman'?");
            string ChooseJob = Console.ReadLine();

            switch (ChooseJob)
            {
                case "janitor":
                    Console.WriteLine("You should've went to college. You became an alcoholic and lost your job. Currently you are homeless.");
                    Console.ReadLine();
                    break;
                case "factory":
                    Console.WriteLine("Congratulations, you landed a job with a well respected company and worked your way to becoming a manager.");
                    Console.ReadLine();
                    break;
                case "tradesman":
                    Console.WriteLine("Excellent choice. You served an apprenticeship and are currently an electrician making $45 an hour.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Not a valid entry. Try Again.");
                    chooseJob();
                    break;
            }

        }

        public void chooseCollege()
        {
            Console.WriteLine("What kind of college will you go to? 'University' or 'Community College'?");
            CollegeChoice = Convert.ToString(Console.ReadLine());
            if (CollegeChoice == "University")
            {
                Console.WriteLine("Youd didn't do so well. Your grades fell off and you dropped out. Mom and Dad are very dissapointed!");
                Console.ReadLine();
            }
            else if (CollegeChoice == "Community College")
            {
                Console.WriteLine("You fell in love with your teacher and lived happily ever after!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not a valid entry. Try Again");
                chooseCollege();
            }
        }

        public void chooseMilitary()
        {
            Console.WriteLine("What branch of the military would you like to join? Select '1' for Army, Select '2' for Marines, Select '3' for AirForce, or Select '4' for Navy");
            string ChooseMilitary = Console.ReadLine();

            switch (ChooseMilitary)
            {
                case "1":
                    Console.WriteLine("Welcome to The Army jughead, you'll make a perfect infantryman! You served 2 years before being medicaly discharged!");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("What were you thinking soldier? You really think you got what it takes to be a Marine? You serve 10 years before being honorably discharged");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("You become a pilot of a F-22 Raptor for the Air Force. You retire after 20 years of service.");
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("You try out for the Navy Seals and fail miserably. You return home ashamed and take a job as a bartender.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Not a valid entry Soldier!");
                    chooseMilitary();
                    break;
            }
        }
    }
}

