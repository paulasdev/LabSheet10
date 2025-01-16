﻿//Create two arrays using the following code
//string[] studentNumbers = {"s123","s124","s125","s126","s127"};
//int[] studentGrades = {40,50,60,70,80};

//Display the student numbers to the user asking to select one.  Then search for the corresponding grade and display it.
//Put the above code in a while loop with -1 to exit



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
      string[] studentNumbers = { "s123", "s124", "s125", "s126", "s127"};
      int[] studentGrades = {40, 50, 60, 70, 80};
      string input = "0";

      while (input != "-1")
      {
        Console.WriteLine("Please select one of the following, -1 to exit");

      for(int i = 0; i < studentNumbers.Length; i++)
      {
        Console.WriteLine(studentNumbers[i]);
      }

      input = Console.ReadLine();
      
      Console.WriteLine();

      for (int i = 0; i < studentGrades.Length; i++)
      {
        if (studentNumbers[i] == input)
        {
          Console.WriteLine("The grade for {0} is {1}", input, studentGrades[i]);
        }//end of if
      }//end of for

      
      } //end of while
      Console.ReadLine();
    }

  }
}