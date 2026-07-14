using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7PM
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            string fullName = "kiran";  // Identifers
            int studentAge = 25;
            int studentMarks = 500;


            Console.WriteLine(fullName);
            Console.WriteLine(studentAge);
            Console.WriteLine(studentMarks);

            Console.WriteLine($"Full Name : {fullName}\nAge : {studentAge}\nMarks : {studentMarks}");
            Console.WriteLine("Name  : {0}      Age : {1}     Marks : {2}",fullName,studentAge,studentMarks);
        }
    }
}



// Identifiers : variable names, class Names, Methods Names , enum
// Identifiers can't be keywords.
// Example : Main,WriteLine,Console, void,static, class, internal,string,int,float

// In order to declare any variable we use data types, Identfier names must follow
// naming convention

/*
 * 1.PASCAL CASE Naming Convention
 *          Class Name, Method Name, Namespace Name must be PASCAL CASE.
 *          Example Console.WriteLine()
 *          
 *          
 * 2.Camel Case Naming Convention
 *          This naming convention can be applied to variable names,enums
 *          
 *          firstName
 *          lastName
 *          middleName
 * 
 * 
 * 3.Snake Case Naming Convention
 *          This naming convetion can be applied variables
 *          first_name_student
 *          
 */
