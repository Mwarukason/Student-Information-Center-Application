using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*NAMES OF GROUP MEMBERS:        ID:
 * 1. ISMAIEL SALEM ALTAHAN      209110237
 * 2. AMRI SHABANI MWARUKA       102120494
 * 3. MD. ASIF RAHMAN            111100045
 * 4. MANADIR MOHAMMAD MAHI      209110271
  */

namespace Assignment_Correct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creation Of 3 Objects for Calling Mehtods Created Within The Classes
            CreateFiles Obj_Create = new CreateFiles();
            ReadFiles Obj_Read = new ReadFiles();
            SearchOrCheck Obj_Check = new SearchOrCheck();


            Console.WriteLine("\t Please Enter Informations Of 10 Students: \n");
            Console.WriteLine("\t :---------------------------------------: \n");
            Obj_Create.Create_StudentFile();
            Console.WriteLine();

            Console.WriteLine("\t Enter Courses For Students To Registe: \n");
            Obj_Create.CreateCourseFile();
            Console.WriteLine();

            Console.Write("Enter Your ID to Check if You Are Elegible to Register Courses: ");
            Obj_Check.Check_Student();

            Console.WriteLine("\t :---------------------------------------: \n");
            Console.WriteLine("Start registrations: ");

            Console.Write("Check Name of the Course or CourseCode For The Course You Want To Register: ");
            Obj_Check.Check_Courses();           
            Obj_Create.Create_Register();

            Console.WriteLine("\t :---------------------------------------: \n");
            Obj_Check.Check_Registration();

            Console.WriteLine("Press Enter To See REGISTERED Courses:");

            Console.WriteLine("\t The List Registered Courses Are: \n");
            Obj_Read.Read_2();
            Console.WriteLine("\t :---------------------------------------: \n");
            Console.ReadLine();
        }
    }
}