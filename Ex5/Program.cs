//Calculate the total rainfall for the week and the average rainfall.  Output these values

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

      double total = 0, average = 0;

      for (int i = 0; i < rainfall.Length; i++)
      {
        Console.WriteLine("{0, -12}{1:F1}", days[i],rainfall[i]);
        total += rainfall[i];
      }
      
      average = total / rainfall.Length;

      Console.WriteLine("\nThe total rainfall for the week is {0}", total);
      Console.WriteLine("\nAverage daily rainfall for the week is {0:F1}", average);

      Console.ReadLine();
    }

  }
}

