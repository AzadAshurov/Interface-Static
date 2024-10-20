using Interface.Models;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Azad";
            string surname = "Ashurov";

            if (Student.CheckName(name) && Student.CheckName(surname))
            {
                Student student = new Student(name, surname);
                student.GetInfo();
            }
            else
            {
                Console.WriteLine("Invalid expression");
            }

            string name1 = "Quentin";
            string surname1 = "Tarantino";

            if (Student.CheckName(name1) && Student.CheckName(surname1))
            {
                Student student = new Student(name1, surname1);
                student.GetInfo();
            }
            else
            {
                Console.WriteLine("Invalid expression");
            }
        }
    }
}
