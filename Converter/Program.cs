using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number below ( from 0 - 999, 999): ");
            string userInput = "";

            try
            {
                userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    throw new Exception("Input cannot be blank");
                }

                int inputToNumber = int.Parse(userInput);
                string result = NumberToWordConverter.ConvertMethod(inputToNumber);
                Console.WriteLine(result);


            }
            catch (FormatException)
            {
                Console.WriteLine("Ops! '{0}' is  not a digit !", userInput);
            }

            catch (Exception e)
            {

                Console.WriteLine("Oops! an error occured. See below for more details: \n{0}\nor debug see:\n{1}", e.Message, e.StackTrace);
            }
            

        }
    }
}
