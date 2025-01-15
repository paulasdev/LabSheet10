//Declare and initialise an array to hold the rainfall data for each of the seven days of the week.
//The program should output the numbers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
  class Program
  {
    static void Main(string[] args)
    {
      double[] rainfall = new double[7] {3.9, 0.7, 9.8, 0.1, 3.5, 6.2, 1};
      string[] days = new string[7] {"Monday", "Tuesday","Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

      for (int i = 0; i < rainfall.Length; i++)
      {
        Console.WriteLine("{0, -12}{1:F1}", days[i],rainfall[i]);
      }
      Console.ReadLine();
    }

  }
}

