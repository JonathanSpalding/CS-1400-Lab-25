// Author: Jonathan Spalding
// Assignment: Lab 25
// Instructor Roger deBry
// Clas: CS 1400
// Date Written: 4/12/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using System.IO;
using static System.Console;

namespace ReadingFromAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // state all constants and variables
            const int MAX = 50;
            var count = 0;
            string inputString;
            double total = 0;
            // create an array to hold all scores up to 50 scores.
            int[] grades = new int [MAX];
            // get the current path to the user's My Documents Folder
            string environment = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "\\";
            // write out the file location just "for fun"
            WriteLine(environment);
            // Write what the program will display
            WriteLine("Here is a list of all test scores, followed by the average score.");
            // set the path equal to the path concatinated with grades.txt so that the user doesn't have to input anything.
            string path = environment + "grades.txt";
            // use the full path to get to the document.
            StreamReader theTextFile = new StreamReader(path);
            // do while loop for if the document gets a null return.
            do
            {
                // read each line in the document
                inputString = theTextFile.ReadLine();
                // if statement for when it is acutally a number.
                if (inputString != null)
                {
                    // add the score to your grades array
                    grades[count] = int.Parse(inputString);
                    WriteLine($"{grades[count]}");
                    // count++ to move to the next index in the array
                    count++;
                }           
                //while for when it reaches null  
            } while (inputString != null);
            //call back the method ArrayAverage to display the writeline in the method.
            ArrayAverage(grades, total, count);
            // readkey to keep the info there until the user presses enter.
            ReadKey(true);
        }
        // The ArrayAverage method
        // Purpose: adds all of the elements in the array together, and divides them to get the average
        // Parameters: int[] grades, double Total, int count
        // returns: none
        static void ArrayAverage(int[] grades, double total, int count)
        {
            // for loop that runs as many times as there were actual elements added to the array.
            for (var i = 0; i < count; i++)
            {
                // add all together
                total += grades[i];
            }
            // divide the scores by how many scores were entered to find the average
            var average = total / count;
            // writeline the average
            WriteLine($"Your average is {average}.");
        }
    }
}
