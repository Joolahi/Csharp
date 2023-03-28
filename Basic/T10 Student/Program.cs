using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace T10_Student
{
    class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public string FieldOfStudy { get; set; }
        public int Year { get; set; }
        public double GradeAverage { get; set; }


        public Student(string name, int studentId, string fieldOfStudy, int year, double gradeAverage)
        {
            Name = name;
            StudentId = studentId;
            FieldOfStudy = fieldOfStudy;    
            Year = year;
            GradeAverage = gradeAverage;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Student ID: {StudentId}, Field of Study: {FieldOfStudy}, Year: {Year}, Grade Average: {GradeAverage}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>()
            {
                new Student( "Iida", 3575, "Biology", 2019, 3.87 ),
                new Student("Kristian", 7845, "Psychology", 2021, 1.92),
                new Student("Joonas", 1251, "Physics", 2022, 4.6),
                new Student("Tero", 9494, "History", 2016, 2.2),
                new Student("Liisa", 1238, "Economic Sciences", 2023, 4.7),
            };
            foreach(Student student in list)
            {
                Console.WriteLine(student);
            }
        }
    }
}
