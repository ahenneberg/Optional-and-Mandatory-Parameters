/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_and_Mandatory_Parameters
{
    class Program
    {
        /******************* OPTIONAL PARAMETERS *************************/
        /* From C# 4.0, methods, constructors, and indexers can declare 
         * OPTIONAL parameters. A parameter is optional if it specifies
         * a DEFAULT VALUE in its declaration:                           */
        static void Opt(int x = 23) { Console.WriteLine(x); }
        /******************* MANDATORY PARAMETERS ************************/
        /* Mandatory parameters must occur BEFORE optional parameters in
         * both the method declaration and the method call (the exception
         * is with params arguments, which still always come last).      */
        static void Man(int x = 0, int y = 0) { Console.WriteLine(x + ", " + y); }
        /******************* NAMED ARGUMENTS *****************************/
        /* Names arguments are particularly useful in conjunction with 
         * optional parameters. For instance, consider the following method: */
        static void Bar ( int a = 0, int b = 0, int c = 0, int d = 0)
            {
                Console.WriteLine(a + ", " + b + ", " + c + ", " + d);
            }
        static void Main()
        {
            /************** OPTIONAL PARAMETERS EXAMPLE ****************/
            // Optional Parameters may be omitted when calling the method
            Opt();      // 23
            /* The DEFAULT argument of 23 is actually PASSED to the 
             * optional parameter Z-the compiler bakes the value 23 into
             * the compiled code at the CALLING side. The preceding call
             * to Opt is semantically identical to: Opt(23);            */
            /* The default value of an optional parameter must be
             * specified by a constant expression, or a paramaterless
             * constructor of a value type. Optional parameters cannot
             * be marked with ref or out.                               */
            /************** MANDATORY PARAMETERS EXAMPLE ****************/
            /* In the following example, the explicit value of 1 is passed
             * to x, and the default value of 0 is passed to y:         */
            Man(1);    // 1, 0
            /* To do the converse (pass a default value to x and an 
                * explicit value to y) you must combine optional parameters
                * with named arguments.                        */
            /************** NAMED ARGUMENTS EXAMPLE *********************/
            /* Rather than identifying an argument by position, you can 
                * identify an argument by name. For Example:            */
            Man(x: 1, y: 2);    // 1, 2
            // Named arguments can occur in any order.
            Man(y: 2, x: 1);    // 1, 2
            // You can mix names and positional arguments:
            Man(1, y: 2);       // 1, 2
            /* However, there is a restriction: positional arguments must
             * come before named arguments. So we couldn't call Man like
             * this:    Man(x:1, 2);    // Compile-time error           */
            /* For the bar method, we can call this, supplying only 1 value
             for d as follows:                                          */
            Bar (d:3);
            // This is particularly useful when calling COM APIS (CH. 3).
        }
    }
}
