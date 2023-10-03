using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week5InClassDemo.SchoolExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            //Employee emp = new Employee(); //abstract types, cant new
            FacultyMember fm = new FacultyMember("abc", "def", 120);
            Teacher teacher = new Teacher("abc", "def", 120);
            Admin admin = new Admin("abc", "def", 120);
            //Student student = new Student(); //abstract types, cant new
            GraduatedStudent graduate = new GraduatedStudent();
        }
    }
}
