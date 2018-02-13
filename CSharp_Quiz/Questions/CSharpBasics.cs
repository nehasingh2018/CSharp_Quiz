//....................................
//NAME: Neha Singh
//Employee ID: 246450
//COMPANY: SYMANTEC
//.............................

using.System;


namespace Symc.Globalization.Localization
{
    class CSharpBasics
    {
        static void Main(strings[] args)
        int width; //variable declaration
        int height; //variable declaration
        
        CSharpBasics.WriteLine("Enter the width and height of an image"); //print this statement on console
        if (width==height) //if weidth and height is same
        {
            CSharpBasics.WriteLine("\nThis is a square image.");
        }
        else if(width < height) //if-else width is lesser than height condition
        {
            CSharpBasics.WriteLine("\nThe image is portrait")'
        }
        else //any other condition
        {
            CSharpBasics.WriteLine ("\nthe image is landscape.");
        }
    }
    
    
        
        // Write a program which takes a single argument from the console, computes the factorial and prints the value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        /// and display it as 5! = 120.
 class Program
    {
        static void Main(string[] args) //declaring null function
        {
            int i, number, fact; //declaring variable
            Console.WriteLine("Enter the Number"); //output on console
            number = int.Parse(Console.ReadLine()); //
            fact = number;
            for (i = number - 1; i >= 1; i--) //multiply the number subtracted by until it reaches 1
            {
                fact = fact * i;
            }
            Console.WriteLine("\nFactorial of Given Number is: "+fact); //output on console
            Console.ReadLine();
 
        }
    }
    
    
        // Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
        // Display the reversed name on the console.
class Prog
{
    static void Main(string[] args)
    {
        string Str, reversestring = ""; //variable declaration
        int Length; //variable declaration
        Console.Write("Enter A String : "); //console output
        Str = Console.ReadLine(); 
        Length = Str.Length - 1;
        while (Length >= 0) //the string should contain atleast 1 character
        {
            reversestring = reversestring + Str[Length]; //reversing the string 
            Length--;
        }
        Console.WriteLine("Reverse  String  Is  {0}", reversestring); //console output
        Console.ReadLine();
    }
}
        // Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        // if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        // display a message: "Consecutive"; otherwise, display "Not Consecutive".
    class Pro
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separate by hypen : "); //output statement
            var name = Console.ReadLine(); //variable entered being taken
            var numarray = name.Split('-'); //spliting numbers with hyphen
            for (var i = 0;i<=numarray.Length-1;i++ ) //when entered number is 
            {
                if (i>1 && (Convert.ToInt32(numarray[i]) != Convert.ToInt32(numarray[i - 1])+1)) //
                {
                    Console.WriteLine("Not Consecutive"); //console output
                    break;
                }
                if (i == numarray.Length-1) //if the numbers entered returns -1 when subtracting from the next number
                {
                    Console.WriteLine("Consecutive"); //console output
                }
            }
        }
    }
    
}
