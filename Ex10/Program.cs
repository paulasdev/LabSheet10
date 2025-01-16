//Write a program which stores student grades in an array.  The program should have the following functionality
//Create an array to store the marks of 10 students
//Use a loop and Random to randomly assign 10 grades between 0-100.
//Use a loop to print out the marks of the 10 students
//Write a piece of code to print the average mark of the 10 students
//Write a piece of code to print the highest mark
//Write a piece of code to print the smallest mark
//Write a piece of code that print the number of students that obtained a pass mark (>= 40)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
  class Program
  {
    static void Main(string[] args)
    {
      //declare variables
      double total = 0;
      double[] grades = new double[10];
      Random rand = new Random();

      double highest = 0;
      double lowest = 100;

      int numberOfPasses = 0;

      //assign values to array
      for(int i = 0; i < grades.Length; i++)
      {
        grades[i] = rand.Next(0, 101); //bet 0 and 100
        Console.WriteLine("The grade for student {0} is {1}", i + 1, grades[i]);
        total += grades[i];

      }


      //work out highest and lowest
      for (int j = 0; j < grades.Length; j++)
      {
        if (grades[j] > highest)
        highest = grades[j];

        if (grades[j] < lowest)
        lowest = grades[j];

        if (grades[j] >= 40)
        numberOfPasses++;
      }//end of for

      Console.WriteLine("Average is {0:F1}", total / grades.Length);
      Console.WriteLine("Highest is {0}", highest);
      Console.WriteLine("Lowest is {0}", lowest);
      Console.WriteLine("Number of passes is {0}", numberOfPasses);

      Console.ReadLine();
    }
  }
}
