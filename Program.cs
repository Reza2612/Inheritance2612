using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Rolando", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Rooney", 35, "190302", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Zidane", 19, "10506", "zidane07@amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}