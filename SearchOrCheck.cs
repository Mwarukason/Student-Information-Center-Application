using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_Correct
{
    class SearchOrCheck
    {
        public void Check_Courses()
        {   
            //Spliting 
            string IdOrcourseCode = Console.ReadLine();
            FileStream File2 = new FileStream("Courses1.dat", FileMode.Open);
            StreamReader CheckFile = new StreamReader(File2);

            string data = CheckFile.ReadToEnd();
            File2.Close();

            //Creating an Array For Spling Data
            string[] Araay_1 = data.Split('\n');
            foreach (string blue in Araay_1)
            {
                
                string CourseName = string.Empty;
                for (int i = 0; i < blue.Length - 1; i++) CourseName += blue[i];
                try
                {
                    string[] _array_1 = CourseName.Split(' ');
                    if (IdOrcourseCode == _array_1[0] || IdOrcourseCode == _array_1[1]) { Console.WriteLine(blue); break; } 
                }
                catch (Exception)
                { Console.WriteLine("Please enter the correct CourseCode"); }
            }
            
        }

        public void Check_Student()
        {
        A: string IdOrcourseCode = Console.ReadLine();
            FileStream File2 = new FileStream("Students.dat", FileMode.Open);
            StreamReader CheckFile = new StreamReader(File2);

            string data = CheckFile.ReadToEnd();
            File2.Close();          
            
            string[] Array_2 = data.Split('\n');
            foreach (string s1 in Array_2)
            {

             string Id = string.Empty;
                for (int i = 0; i < s1.Length - 1; i++) Id += s1[i];
                try
                {
                string[] HB = Id.Split(' ');               
                    if (IdOrcourseCode == HB[0] || IdOrcourseCode == HB[1])                       
                    { 
                        Console.WriteLine(s1); break;
                    }
                 }
                catch (Exception)
                {
                    Console.WriteLine("This ID is Not Exist,Please enter the correct ID"); goto A;}                                   
                }           
                }

        public void Check_Registration()
        {
        A: string IdOrcourseCode = Console.ReadLine();
            FileStream File2 = new FileStream("Students.dat", FileMode.Open);
            StreamReader CheckFile = new StreamReader(File2);

            string data = CheckFile.ReadToEnd();
            File2.Close();

            string[] Array_2 = data.Split('\n');
            foreach (string s1 in Array_2)
            {
                string Id = string.Empty;
                for (int i = 0; i < s1.Length - 1; i++) Id += s1[i];
                try
                {
                    string[] HB = Id.Split(' ');
                    if (IdOrcourseCode == HB[0] || IdOrcourseCode == HB[1])
                    {
                        Console.WriteLine(s1); break;
                    }
                }
                catch (Exception)
                {
                    Console.Write("This ID is Not Exist, Please enter the correct ID"); goto A;    
                }
            }
        }
     }                         
}
