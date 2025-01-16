//Add a second array called Days of the Week to the program above.  The elements of this array should be defined as follows
//{“Monday”, Tuesday”, “Wednesday”, “Thursday”, “Friday”, “Saturday”, “Sunday”}
//Incorporate this into the program so that the output looks as follows

//Note: Your output statement should call on the element of the array for day as opposed to typing each day separately. E.g. day[0] for Monday.


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
        Console.WriteLine("The rainfall for {0} is {1:F1}", days[i],rainfall[i]);
        
      }
      Console.ReadLine();
    }
  }
}