//Declare an array to hold the marks in an exam, loop through an total

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
  class Program
  {
    static void Main(string[] args)
    {
     int[] grades = new int [5] {45, 55, 60, 81, 39};

     double total = 0;

     for (int i = 0; i < grades.Length; i++)
     {
        total += grades[i]; //total = total + grades[i]
     }  
     Console.WriteLine("The total is {0}", total);
     Console.WriteLine("The avarage is {0}", total/grades.Length);
     Console.ReadLine();
    }

  }
}
