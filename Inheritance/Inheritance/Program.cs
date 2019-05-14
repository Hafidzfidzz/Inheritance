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
            Person person = new Person("Hafidz", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Thomas", 30, "190302", "Math");
            person.GetNameAndAge();

            Student student = new Student("Andreas", 19, "10506", "Andreas1234@amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
