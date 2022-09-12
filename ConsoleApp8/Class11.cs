using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day9
{
    class student
    {
        public student()
        {
            ID = 101;
            StudentName = "Arpit bhadoria";
        }
        public int ID { get; set; }
        public string StudentName { get; set; }

        public void WriteInFile()
        {
            student e = new student();
            FileStream fs = new FileStream("student.json", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(e.StudentName);
            sw.WriteLine(e.ID);
            sw.Flush();
            sw.Close();
            fs.Close();


            //Reading from a file
            FileStream fsR = new FileStream("student.Json", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fsR);
            Console.WriteLine("======Content from file========");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            while (e != null)
            {
                Console.WriteLine(e.StudentName);
                e.StudentName = sr.ReadLine();
                Console.WriteLine(e.ID);
                e.ID = Convert.ToInt32(sr.ReadLine());
                break;
            }
            sr.Close();
            fsR.Close();
        }
    }
    class Class2
    {
        public static void Main()
        {
            //c# code to json format
            student student = new student();

            //convert to json
            var json = JsonConvert.SerializeObject(student);
            Console.WriteLine(json);

            //json to object
            var studentObj = JsonConvert.DeserializeObject<student>(json);
            student.WriteInFile();
        }
    }
}