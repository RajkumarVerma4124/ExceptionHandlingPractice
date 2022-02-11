using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingProgram
{
    public class Program
    {
        /// <summary>
        /// Testing different exception
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            try
            {
                TestExceptionTypes.TestIndexOutOfRange();
                TestExceptionTypes.TestNullReference();
                TestExceptionTypes.TestArgumentNullException(null);
                TestExceptionTypes.TestInvalidOperator();
                TestExceptionTypes.TestArgumentOutOfRange("Test");
                TestExceptionTypes.TestDivideByZero();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }


        }
    }
}
