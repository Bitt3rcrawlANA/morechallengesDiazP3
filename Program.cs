// See https://aka.ms/new-console-template for more information

using System.Data;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

class Challenges
{
    static void Main(string[] args)
    {
        bool validInput1 = false;

        Console.WriteLine("Welcome to More Challlenges! There are 4 challenges to choose from: \n Age Challenge, \n TriArea Challenge, \n ZeroCompare Challenge, \n HundredCompare Challenge, \n EqualTo Challenge, \n Something Challenge, \n Reverse Challenge, \n Hours Challenge, \n Polygon Challenge, \n Edabit Challenge, \n And Challenge, \n Points Challenge, \n RectPerimeter Challenge, \n Greet Challenge, \n Animals Challenge, \n Score Challenge, \n Month Challenge.");

        do
        {

            Console.WriteLine("Please type which Challenge you'd like to test. (Type the name without the word Challenge): ");

            string choice = Console.ReadLine();

            if (choice == "Age")
            {
                validInput1 = true;
                Console.WriteLine("I will now take a number to represent a number of years, and convert it into days.");
                Console.WriteLine("Please enter an age:");


                var ageNum = Console.ReadLine();
                int ageInt = int.Parse(ageNum);

                Console.WriteLine($"Got it! " + ageNum + " years is equivalent to " + Convert(ageInt) + " days.");

                validInput1 = false;
            }

            else if (choice == "TriArea")
            {
                validInput1 = true;
                Console.WriteLine("I will use two numbers to calculate the area of a triangle. \n Please type a number to act as the base:");

                var baseNum = Console.ReadLine();
                int baseInt = int.Parse(baseNum);

                Console.WriteLine("Alright, the base of the triangle is " + baseNum + ".");
                Console.WriteLine("Please type a number to act as the height:");

                var heiNum = Console.ReadLine();
                int heiInt = int.Parse(heiNum);

                Console.WriteLine($"Got it! The area of your triangle is: " + TriStateArea(baseInt, heiInt));

                validInput1 = false;
            }

            else if (choice == "ZeroCompare")
            {
                validInput1 = true;
                Console.WriteLine("Now, I will determine whether a number is less than or equal to zero. \n Please type a number:");

                var equNum = Console.ReadLine();
                int equInt = int.Parse(equNum);

                if (EqualOrLessThan(equInt) == true)
                {
                    Console.WriteLine($"Got it! " + equNum + " is not more than 0!");

                    validInput1 = false;
                }
                if (EqualOrLessThan(equInt) != true)
                {
                    Console.WriteLine($"Got it! " + equNum + " is more than 0!");

                    validInput1 = false;
                }
            }

            else if (choice == "HundredCompare")
            {
                validInput1 = true;
                Console.WriteLine("Now, I will determine whether the sum of two numbers is less than or equal to 100. \n Please type the first number:");

                var smallNum = Console.ReadLine();
                int smallInt = int.Parse(smallNum);

                Console.WriteLine("Alright, your first number is " + smallNum + ".");
                Console.WriteLine("Please type your second number:");

                var mikuNum = Console.ReadLine();
                int mikuInt = int.Parse(mikuNum);

                if (SumEqualOrLess(smallInt, mikuInt) == true)
                {
                    Console.WriteLine($"Got it! " + ActualSum(smallInt, mikuInt) + " is not more than 100!");

                    validInput1 = false;
                }
                if (SumEqualOrLess(smallInt, mikuInt) != true)
                {
                    Console.WriteLine($"Got it! " + ActualSum(smallInt, mikuInt) + " is more than 100!");

                    validInput1 = false;
                }
            }
            else if (choice == "EqualTo")
            {
                validInput1 = true;
                Console.WriteLine("I will determine whether or not two numbers are equal to each other. \n Please type the first number:");

                var birdNum = Console.ReadLine();
                int birdInt = int.Parse(birdNum);

                Console.WriteLine("Alright, your first number is " + birdNum + ".");
                Console.WriteLine("Please type your second number:");

                var cageNum = Console.ReadLine();
                int cageInt = int.Parse(cageNum);

                if (IsEqual(birdInt, cageInt) == true)
                {
                    Console.WriteLine($"Got it! " + birdNum + " is  equal to " + cageNum + ".");

                    validInput1 = false;
                }
                if (IsEqual(birdInt, cageInt) != true)
                {
                    Console.WriteLine($"Got it! " + birdNum + " is not equal to " + cageNum + ".");

                    validInput1 = false;
                }
            }

            else if (choice == "Something")
            {
                validInput1 = true;
                Console.WriteLine("I've got a sentence for you to finish, starting with the word 'Something.' Please finish the sentence:");

                string mari = Console.ReadLine();

                Console.WriteLine($"Got it! The finished sentence is: " + MariOmori(mari));

                validInput1 = false;

            }
            else if (choice == "Reverse")
            {
                validInput1 = true;

                bool ogTrue = true;
                bool ogFalse = false;

                bool reverseT = Reverse(ogTrue);
                bool reverseF = Reverse(ogFalse);

                Console.WriteLine("I am now going to take a boolean value and reverse it. Type T for true, F for false:");

                string ral = Console.ReadLine();

                if (ral == "T")
                {
                    Console.WriteLine($"Our original value, " + ogTrue + ", will get reversed. \n Reversing true makes it become " + reverseT + ".");
                }
                if (ral == "F")
                {
                    Console.WriteLine($"Our original value, " + ogFalse + ", will get reversed. \n Reversing true makes it become " + reverseF + ".");
                }

                validInput1 = false;
            }

            else if (choice == "Hours")
            {
                validInput1 = true;
                Console.WriteLine("I will now take a number to represent a number of hours, and convert it into seconds.");
                Console.WriteLine("Please enter the number of hours:");


                var hourNum = Console.ReadLine();
                int hourInt = int.Parse(hourNum);

                Console.WriteLine($"Got it! " + hourNum + " hours is equivalent to " + SecConvert(hourInt) + " seconds!");

                validInput1 = false;
            }

            else if (choice == "Polygon")
            {

                validInput1 = true;
                bool validInput2 = false;
                Console.WriteLine("I will now calculate the sum of internal angles in a polygon.");

                do
                {
                    Console.WriteLine("Please enter the number of number of angles over 2:");

                    var soulNum = Console.ReadLine();
                    int soulInt = int.Parse(soulNum);

                    if (soulInt > 2)
                    {
                        Console.WriteLine($"Got it! The sum of the internal angles of an " + soulNum + "-sided polygon is " + SumPolygon(soulInt) + "!");

                        validInput1 = false;
                    }
                    if (soulInt <= 2)
                    {
                        Console.WriteLine($"Sorry, a polygon cannot be made up of only " + soulInt + " angle(s).");
                        validInput2 = true;
                    }
                }
                while (validInput2 == true && validInput1 == true);
            }

            else if (choice == "Edabit")
            {

                validInput1 = true;
                Console.WriteLine("I will link together a name you type and Edabit.");
                Console.WriteLine("Please enter any name:");

                string name = Console.ReadLine();

                Console.WriteLine($"Your result is: " + Name(name) + ".");

                validInput1 = false;
            }
            else if (choice == "And")
            {
                validInput1 = true;

                bool sp = true;
                bool te = true;

                Console.WriteLine("I am now going to take two boolean values and return true if both are true. For the first, type T for true, F for false:");

                string spa = Console.ReadLine();

                if (spa == "T")
                {
                    sp = true;
                }
                if (spa == "F")
                {
                    sp = false;
                }

                Console.WriteLine("For the second, type T for true, F for false:");

                string ten = Console.ReadLine();

                if (ten == "T")
                {
                    te = true;
                }
                if (ten == "F")
                {
                    te = false;
                }

                Console.WriteLine($" I will now return the value of these booleans combined");

                if (And(sp, te) == true)
                {
                    Console.WriteLine($"Both booleans were true, so the results return true.");
                }
                else if (And(sp, te) == false)
                {
                    Console.WriteLine($"One or more booleans were false, so the results return false.");
                }

                validInput1 = false;
            }
            else if (choice == "Points")
            {
                validInput1 = true;
                Console.WriteLine("Imagine the points being counted for a basketball game. \n Please enter a number to represent how many 3-pointers the team earned:");

                var threeNum = Console.ReadLine();
                int threeInt = int.Parse(threeNum);

                Console.WriteLine("Now, please type a number to represent how many 2-pointers the team earned:");

                var twoNum = Console.ReadLine();
                int twoInt = int.Parse(twoNum);

                Console.WriteLine($"Got it! The total amount of points earned is " + Points(threeInt, twoInt) + "!");

                validInput1 = false;
            }
            else if (choice == "RectPerimeter")
            {
                validInput1 = true;
                Console.WriteLine("I will now calculate the perimeter of a rectangle. Please enter a number to represent the height:");

                var feaNum = Console.ReadLine();
                int feaInt = int.Parse(feaNum);

                Console.WriteLine("Now, please enter a number to represent the width:");

                var preNum = Console.ReadLine();
                int preInt = int.Parse(preNum);

                Console.WriteLine($"Got it! The perimeter of the rectangle " + Perim(feaInt, preInt) + "!");

                validInput1 = false;
            }
            else if (choice == "Greet")
            {

                validInput1 = true;
                Console.WriteLine("Please enter your name:");

                string name2 = Console.ReadLine();

                Console.WriteLine($"Alright. " + Hello(name2));

                validInput1 = false;
            }
            else if (choice == "Animals")
            {
                validInput1 = true;
                Console.WriteLine("I will now calculate the amount of legs between all the animals a farmer raises. \nPlease enter a number for the amount of chickens (one chicken = two legs) he has:");

                var chiNum = Console.ReadLine();
                int chiInt = int.Parse(chiNum);

                Console.WriteLine("Now, please enter a number for the cows (one cow = four legs):");

                var cowNum = Console.ReadLine();
                int cowInt = int.Parse(cowNum);

                Console.WriteLine("Now, please enter a number for the pigs (one pig = four legs):");

                var pigNum = Console.ReadLine();
                int pigInt = int.Parse(pigNum);

                Console.WriteLine($"Got it! The amount of legs between all the animals is " + Animals(chiInt, cowInt, pigInt) + " legs!");

                validInput1 = false;
            }
            else if (choice == "Score")
            {
                validInput1 = true;
                Console.WriteLine("Imagine the points being counted for a football game. \nPlease enter a number to represent how many wins the team obtained:");

                var winNum = Console.ReadLine();
                int winInt = int.Parse(winNum);

                Console.WriteLine("Now, please type a number to represent how many 2-pointers the team earned:");

                var drawNum = Console.ReadLine();
                int drawInt = int.Parse(drawNum);

                Console.WriteLine("Finally, please type a number to represent how many losses the team obtained:");

                var lossNum = Console.ReadLine();
                int lossInt = int.Parse(lossNum);

                Console.WriteLine($"Got it! The total amount of points the football teamed earned is " + TotalPoints(winInt, drawInt, lossInt) + "!");

                validInput1 = false;
            }
            else if (choice == "Month")
            {
                validInput1 = true;
                bool errorCheck = true;
                do
                {
                    Console.WriteLine("I will now print the name of a Month depending on the number you type below. \nPlease enter a number from 1-12:");

                    var monthNum = Console.ReadLine();
                    int monthInt = int.Parse(monthNum);

                    if (monthInt > 12 || monthInt < 1)
                    {
                        errorCheck = true;
                        Console.WriteLine($"Not a month that exists. Try again!");
                    }

                    if (monthInt <= 12 && monthInt >= 1)
                    {
                        errorCheck = false;
                        Console.WriteLine($"Got it! Based on this number, the month of the year is: " + MonthName(monthInt) + "!");

                        validInput1 = false;
                    }
                }
                while (errorCheck == true && validInput1 == true);
            }
            else
            {
                Console.WriteLine($"Sorry, that Challenge doesn't exist.");

                validInput1 = false;
            }
        } 
        while (validInput1 == false);

    }

    static int Convert(int a)
    {
        return a * 365;
    }

    static int TriStateArea(int a, int b)
    {
        return a * b / 2;
    }

    public static bool EqualOrLessThan(int a)
    {
        return a <= 0;
    }

    public static bool SumEqualOrLess(int a, int b)
    {
        return a + b <= 100;
    }
    static int ActualSum(int a, int b)
    {
        return a + b;
    }

    public static bool IsEqual(int a, int b)
    {
        return a == b;
    }

    static string MariOmori(string a)
    {
        return "Something" + " " + a;
    }
    public static bool Reverse(bool value)
    {
        return !value;
    }
    static int SecConvert(int a)
    {
        return a * 3600;
    }
    static int SumPolygon(int a)
    {
       return (a - 2) * 180;
    }
    
    public static string Name(string name)
    {
        string result = name + "Edabit";
        return result;
    }

    public static bool And(bool a, bool b)
    {
        if (a == false)
        {
            return false;
        }
        else if (a == true && b == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static int Points(int a, int b)
    {
        return a * 3 + b * 2;
    }

    public static int Perim(int a, int b)
    {
        return a * 2 + b * 2;
    }
    public static string Hello(string name)
    {
        string result = "Hello, " + name + "! Thank you for running these code challenges!";
        return result;
    }

    public static int Animals(int a, int b, int c)
    {
        return a * 2 + b * 4 + c * 4;
    }
    public static int TotalPoints(int a, int b, int c)
    {
        return a * 3 + b + c * 0;
    }
    public static string MonthName(int a)
    {
        if (a == 1)
        {
            string result = "January";
            return result;
        }
        else if (a == 2)
        {
            string result = "February";
            return result;
        }
        else if (a == 3)
        {
            string result = "March";
            return result;
        }
        else if (a == 4)
        {
            string result = "April";
            return result;
        }
        else if (a == 5)
        {
            string result = "May";
            return result;
        }
        else if (a == 6)
        {
            string result = "June";
            return result;
        }
        else if (a == 7)
        {
            string result = "July";
            return result;
        }
        else if (a == 8)
        {
            string result = "August";
            return result;
        }
        else if (a == 9)
        {
            string result = "September";
            return result;
        }
        else if (a == 10)
        {
            string result = "October";
            return result;
        }
        else if (a == 11)
        {
            string result = "November";
            return result;
        }
        else if (a == 12)
        {
            string result = "December";
            return result;
        }
        else
        {
            string error = "Error";
            return error;
        }
    }
}

