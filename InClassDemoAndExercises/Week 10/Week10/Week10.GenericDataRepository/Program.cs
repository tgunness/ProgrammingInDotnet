using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Week10.GenericRepositoryExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericRepository<Student> students = new GenericRepository<Student>();

            students.Add(GenerateStudents());

            foreach(var student in students.GetAll())
            {
                Console.WriteLine(student.ID);
            }


            var educators = new GenericRepository<Educator>(GenerateEducators());

            foreach (var educator in educators.GetAll())
            {
                Console.WriteLine(educator.ID);
            }

            Console.ReadLine();
        }

        public static List<Student> GenerateStudents()
        {
            return new List<Student>()
            {
                new Student(1,"abe", "cde","123"),
                new Student(2,"abe", "cde","456"),
                new Student(3,"abe", "cde","789"),
                new Student(4,"abe", "cde","901"),
            }; 
        }

        public static List<Educator> GenerateEducators()
        {
            return new List<Educator>()
            {
                new Educator(5,"aaa", "xxx","222"),
                new Educator(6,"bbb", "yyy","333"),
                new Educator(7,"ccc", "zzz","444"),
                new Educator(8,"ddd", "www","555"),
            };
        }
    }
}
