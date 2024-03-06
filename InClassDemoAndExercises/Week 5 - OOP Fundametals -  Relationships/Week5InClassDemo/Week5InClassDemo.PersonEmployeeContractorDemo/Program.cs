using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(35, "Jim", "Halpart");
            Contractor c = new Contractor("Pam","Beasley");
            Janitor j = new Janitor("John", "Smith");
            Person p = new Person("Micheal", "Scott");

            Person aa = new Employee(45, "a", "b");
            Person bb = new Contractor("c", "d");


            List<Person> allPersons = new List<Person>();
            allPersons.Add(e);
            allPersons.Add(c);
            allPersons.Add(p);
            allPersons.Add(j);

            foreach (Person item in allPersons)
            {
                Console.WriteLine(item.FirstName);

            }

            List<Object> allObjects = new List<Object>();
            allObjects.Add(e);
            allObjects.Add(c);
            allObjects.Add(p);

            foreach (Object item in allObjects)
            {
                Console.WriteLine(item.ToString());
            }

            List<IPayable> allPayables = new List<IPayable>();
            allPayables.Add(e);
            allPayables.Add(j);

            foreach (IPayable item in allPayables)
            {
                PayMe(item, 50);
            }


            DoListStuff(allPersons);

            Console.ReadKey();
        }

        public static void PayMe(IPayable a, int rate)
        {
            a.Pay(rate);
        }

        public static void DoListStuff(List<Person> persons)
        {
            foreach (Person a in persons)
            {
                //Console.WriteLine($"{a.FirstName} is an {a.GetType().Name}");

                if (a is Janitor)
                {
                    Console.WriteLine($"{a.FirstName} is an {a.GetType().Name}");
                }
                else if (a is Employee)
                {
                    //Console.WriteLine($"{a.FirstName} is an Employee");

                    //TODO: terminate employee
                    Employee tempE = (Employee)a;
                    tempE.Terminate(DateTime.Now);

                }
                else if (a is Contractor)
                {
                    //Console.WriteLine($"{a.FirstName} is an Contractor");

                    //TODO: pay contractor
                    Contractor tempC = (Contractor)a;
                    tempC.Pay(20);

                    ((Contractor)a).Pay(20);
                }
                else
                {
                    Console.WriteLine($"{a.FirstName} is just a Person");
                }
            }
        }
        public static void DoStuff(Person a)
        {
            if (a is Employee)
            {
                Console.WriteLine($"{a.FirstName} is an Employee");
            }
            else if (a is Contractor)
            {
                Console.WriteLine($"{a.FirstName} is an Contractor");
            }
            else if(a is Janitor)
            {
                Console.WriteLine($"{a.FirstName} is an Janitor");
            }
            else
            {
                Console.WriteLine($"{a.FirstName} is just a Person");
            }
        }
    }
}
