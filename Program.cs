
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpliLearnOOPSProj
{
    internal class Problem
    {
        static void Main(string[] args)
        {
            List<Student> stud = new List<Student>();
            Student s1 = new Student() { Name = "Darshan", Class_Section = "XII A" };
            Student s2 = new Student() { Name = "Seshan", Class_Section = "X A" };
            Student s3 = new Student() { Name = "Ashwin", Class_Section = "IX D" };
            Student s4 = new Student() { Name = "Ashmitha", Class_Section = "VI A" };
            Student s5 = new Student() { Name = "Aashvik", Class_Section = "X B" };
            Student s6 = new Student() { Name = "Ishaan", Class_Section = "XI D" };
            Student s7 = new Student() { Name = "Sonia", Class_Section = "XII A" };
            Student s8 = new Student() { Name = "Roshni", Class_Section = "IV A" };


            stud.Add(s1);
            stud.Add(s2);
            stud.Add(s3);
            stud.Add(s4);
            stud.Add(s5);
            stud.Add(s6);
            stud.Add(s7);
            stud.Add(s8);
            List<Subject> subjects = new List<Subject>();

            Subject sub1 = new Subject() { Name = "Mrs Gayatri", SubjectCode = "ENG", Class_Section = "IV C", SubName = "English" };
            Subject sub2 = new Subject() { Name = "Sister Shaila", SubjectCode = "SST", Class_Section = "X A", SubName = "Social Science" };
            Subject sub3 = new Subject() { Name = "Mr Udayakumar", SubjectCode = "PHY", Class_Section = "IX D", SubName = "Physics" };
            Subject sub4 = new Subject() { Name = "Mrs Prabha Jain", SubjectCode = "HIN", Class_Section = "V B", SubName = "Hindi" };
            Subject sub5 = new Subject() { Name = "Mr Janarthanan", SubjectCode = "MAT", Class_Section = "XI C", SubName = "Maths" };
            Subject sub6 = new Subject() { Name = "Mrs Varalakshmi", SubjectCode = "CPA", Class_Section = "XI D", SubName = "Computer Applications" };
            Subject sub7 = new Subject() { Name = "Mrs Uma", SubjectCode = "TAM", Class_Section = "X A", SubName = "Tamil" };

            subjects.Add(sub1);
            subjects.Add(sub2);
            subjects.Add(sub3);
            subjects.Add(sub4);
            subjects.Add(sub5);
            subjects.Add(sub6);
            subjects.Add(sub7);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Displaying data:");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Students in  class");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            foreach (Student s in stud)
            {
                Console.WriteLine("Student Name : " + s.Name);
                Console.WriteLine("Class And Section : " + s.Class_Section);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Subjects Taught By Teacher:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            foreach (Subject s in subjects)
            {
                Console.WriteLine("Teacher Name      : " + s.Name);
                Console.WriteLine("Subject Code      : " + s.SubjectCode);
                Console.WriteLine("Class_Section and Section : " + s.Class_Section);
                Console.WriteLine("Subject Name      : " + s.SubName);
                Console.WriteLine();

            }


            Console.ReadLine();
        }
    }
}
