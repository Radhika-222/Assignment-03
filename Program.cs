using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example using TryParse to convert a string to an integer
            string number;
            Console.WriteLine("Enter a String Number to convert to an integer:");
            number = Console.ReadLine();
            if (int.TryParse(number, out int intValue))
            {
                Console.WriteLine("TryParse Result: " + intValue);
            }
            else
            {
                Console.WriteLine("TryParse Error: Invalid input");
            }


            // Example using Convert to convert a string to a double
            string doubleString;
            Console.WriteLine("Enter a String value to double");
            doubleString = Console.ReadLine();
            try
            {
                double doubleValue = Convert.ToDouble(doubleString);
                Console.WriteLine("Convert Result: " + doubleValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Convert Error:" + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of Program");
            }


            // Example using Parse to convert a string to a decimal
            string value;
            Console.WriteLine("Enter a value to convert to decimal");
            value = Console.ReadLine();
            try
            {
                decimal decimalValue = decimal.Parse(value);
                Console.WriteLine("Parse Result: " + decimalValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Parse Error: Invalid input format" + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of Program");
            }
            Console.ReadKey();
        }
    }
}