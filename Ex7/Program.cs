//Amend the program above so that it can read in the data from the user when prompted for each days rainfall. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
  class Program
  {
    static void Main(string[] args)
    {
      
      string[] days = new string[7] {"Monday", "Tuesday","Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
      double[] rainfall = new double[7];

      double total = 0;
      

      for (int i = 0; i < rainfall.Length; i++)
      {
        Console.WriteLine("Enter rainfall for {0} >>", days[i]);
        rainfall[i] = Convert.ToDouble(Console.ReadLine());
        
      }
      Console.ReadLine();

        for (int i = 0; i < rainfall.Length; i++)
      {
        Console.WriteLine("The rainfall for {0} is {1}", days[i],rainfall[i]);
        total = total + rainfall[i];
      } 

      Console.WriteLine("\nTotal rainfall is {0}", total);
      Console.WriteLine("Average daily rainfall is {0:F1}", total / rainfall.Length);

      Console.ReadLine();
    }
  }
}