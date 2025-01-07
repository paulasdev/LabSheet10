//Declare an array to hold names of beatles.
//Use a for loop to iterate through this array and output.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] beatles = new string[4] { "John", "Paul", "George", "Ringo"};

      for (int i = 0; i < beatles.Length; i++)
      {
        Console.WriteLine(beatles[i]);
      }
      Console.ReadLine();
    }

  }
}

