using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingProgram
{
    /// <summary>
    /// Testing the different exception types
    /// </summary>
    public class TestExceptionTypes
    {
        //Method to test index out of range exception
        public static void TestIndexOutOfRange()
        {
            try
            {
                int[] arr = { 1, 2, 3, 4, 5 };
                Console.WriteLine(arr[6]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Method to test null reference exception
        public static void TestNullReference()
        {
            try
            {
                LinkedList<int> arr = null;
                Console.WriteLine(arr.ToString());
            }
            catch (NullReferenceException msg)
            {
                Console.WriteLine(msg.Message);
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg.Message);
            }
        }

        //Method to test invalid operator exception
        public static void TestInvalidOperator()
        {
            try
            {
                var numbers = new List<int>() { 1, 2, 3, 4, 5 };
                foreach (var number in numbers)
                {
                    int square = (int)Math.Pow(number, 2);
                    Console.WriteLine("{0}^{1}", number, square);
                    Console.WriteLine("Adding {0} to the collection...\n", square);
                    numbers.Add(square);
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Method to test argument null exception exception
        public static void TestArgumentNullException(string fName)
        {
            try
            {
                if (fName == null )
                {
                    throw new ArgumentNullException();
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Method to test argument out of range exception
        public static void TestArgumentOutOfRange(string s)
        {
            try
            {
                string res = s.Substring((s.Length) + 2);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Method to test divide by zero exception
        public static void TestDivideByZero()
        {
            try
            {
                int numZero = 0;
                double num = 1 / numZero;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
