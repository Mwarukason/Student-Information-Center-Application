using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_Correct
{
    class ReadFiles
    {
        public void Read_2()
        {
            FileStream FileReader_2 = new FileStream("Register.dat", FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FileReader_2);
            string body_2 = SR.ReadToEnd();
            SR.Close();
            FileReader_2.Close();
            Console.WriteLine(body_2);
            Console.ReadLine();
        }
    }
}
