using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_Correct
{
   public class CreateFiles
    {      
     public void CreateCourseFile()
      { 
        FileStream CoursesFile = new FileStream("Courses1.dat", FileMode.OpenOrCreate);
        StreamWriter WriteCourses = new StreamWriter(CoursesFile); 
        int[] courseCode_array = new int[15]; 
           for (int h = 0; h < 3; h++) 
             { 
           int CourseCode = 100;
           while (true)
             {
               Console.Write("Enter Course_Code :");

               try
               {
                   CourseCode = int.Parse(Console.ReadLine());
                   if (CourseCode < 101 || CourseCode > 200)
                   {
                       throw new Exception();
                   }
               }
               catch
               {
                   Console.WriteLine("Invalid Course_Id, Please Enter Correct Course_Id");
                   continue;
               }
               break;
           }
           Z:Console.Write("Enter the name of the course: ");
           String CourseName = Console.ReadLine();
           string coz_name = CourseName.ToUpper();
           if ((coz_name.Count() > 15 || coz_name == string.Empty))
           { Console.WriteLine("Please Enter Corret format: "); goto Z; }
           Console.WriteLine("\t :---------------------------------------: \n");
           WriteCourses.WriteLine(CourseCode + " " + CourseName); 
           courseCode_array[h] = CourseCode; 
      }       
      WriteCourses.Flush();    
      CoursesFile.Close(); 
      }

       //Class for Creating Student File and Read.
     public void Create_StudentFile()
     {
         FileStream File = new FileStream("Students.dat", FileMode.OpenOrCreate);
         StreamWriter StreamWriter1 = new StreamWriter(File);
         int[] id_array = new int[10];
         for (int i = 0; i < 2; i++)
         {
             {
             C: Console.Write("Enter Student Name: ");
                 string name = Console.ReadLine();
                 string stud_name = name.ToUpper();
                 if ((stud_name.Count() > 10 || stud_name == string.Empty))
                 { Console.WriteLine("Please Enter Corret format: "); continue; }
                 else
                     foreach (char m in stud_name)
                     {
                         if (!(m >= 'A' && m <= 'Z'))
                         { Console.WriteLine("Enter Alphabet Only, No Other Characters: "); goto C; }
                     }
                 int Id_Num = 9;
                 while (true)
                 {
                     Console.Write("Enter Student Id_Number :");
                     //Id_Num = int.Parse(Console.ReadLine());
                     try
                   {
                       Id_Num = int.Parse(Console.ReadLine());
                       if (Id_Num < 10 || Id_Num > 99)
                       {
                           throw new Exception();
                       }
                   }
                   catch
                   {
                       Console.WriteLine("Invalid Id, Please Enter Correct Id");
                       continue;
                   }
                   break;
               }         
                     if (i == 0)
                         id_array[i] = Id_Num;
                     else
                     {
                         int idbreaker = 0;
                         for (int k = 0; k < id_array.Length; k++)
                         {
                             if (id_array[k] == Id_Num)
                             {
                                 idbreaker++;
                                 if (idbreaker < 4)
                                 {
                                     Console.WriteLine("This Id is already Existed!. please reenter your Id :");                                     
                                     k = -1;
                                 }
                                 else
                                     Environment.Exit(0);
                             }
                             break;
                         }

                         StreamWriter1.WriteLine(name + " " + Id_Num);
                          
                     }
                    
                 }            
             }
         StreamWriter1.Flush();
         File.Close(); 
         }
     

       public void Create_Register()
       {
           FileStream registrationFile = new FileStream("Register.dat", FileMode.Create);
           StreamWriter Streamwriter2 = new StreamWriter(registrationFile);
           for (int g = 0; g < 3; g++)
           {              
               Console.WriteLine();               
               int Id_Num = 9;
               while (true)
               {
                   Console.Write("Enter your Id :");
                   try
                   {
                       Id_Num = int.Parse(Console.ReadLine());
                       if (Id_Num < 10 || Id_Num > 99)
                       {
                           throw new Exception();
                       }
                   }
                   catch
                   {
                       Console.WriteLine("Invalid Id, Please Enter Correct Id");
                       continue;
                   }
                   break;
               }               
               int courseCode = 100;
               while (true)
               {
                   Console.Write("Enter your CourseCode :");
                   try
                   {
                       courseCode = int.Parse(Console.ReadLine());
                       if (courseCode < 101 || courseCode > 200)
                       {
                           throw new Exception();
                       }
                   }
                   catch
                   {
                       Console.WriteLine("Invalid Course_Id, Please Enter Correct Course_Id");
                       continue;
                   }
                   break;
               }                        
              C:Console.Write("Enter the Name Of The Course: ");
               string courseName = Console.ReadLine();
               string stud_name = courseName.ToUpper();
               if ((stud_name.Count() > 10 || stud_name == string.Empty))
               { Console.WriteLine("Please Enter Corret format: "); continue; }
               else
                   foreach (char m in stud_name)
                   {
                       if (!(m >= 'A' && m <= 'Z'))
                       { Console.WriteLine("Enter Alphabet Only, No Other Characters: "); goto C; }
                   }
               Console.WriteLine("\n Continue With Your Registration: ");

               Streamwriter2.WriteLine(Id_Num + "  " + courseCode + "    " + courseName + "  " + DateTime.Today.ToString("d/MM/yyyy"));                          
           }
           Streamwriter2.Flush();
          registrationFile.Close();          
       }
    }
}
