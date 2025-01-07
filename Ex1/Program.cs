//Declare an array of strings and output wuthout initialising. 
//Use a while loop to iterate through this array and output.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
  class Program
  {
    static void Main(string[] args)
    {
      string[]testing = new string [10]; //default value of ""

      testing[0] = "Tom";
      testing[1] = "Dick";
      testing[5] = "Harry";
    

      int counter = 0;
      while(counter < 10)
      {
        Console.WriteLine("Element{0} of the array >>{1}<<", counter, testing[counter]);
        
        counter++;
      }
      // for (int i = 0; i < 10; i++)
      // {
      // Console.WriteLine("Element {0} of the array >>{1}<<", i, testing[i]);
      // }
      Console.ReadLine();
    }

  }
}