using Interface.Interface;

namespace Interface.Models
{
    internal class Student : ICodeAcademy
    {


        private static int _count = 0;
        private int _id;
        private string _name;
        private string _surname;


        public static int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = Capitalaze(value); }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = Capitalaze(value); }
        }

        public string CodeEmail { get; set; }

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Count++;
            Id = Count;

            CodeEmail = GenerateEmail();
        }

        public static string Capitalaze(string name)
        {
            return char.ToUpper(name[0]) + name.Substring(1).ToLower();

        }

        public static bool CheckName(string name)
        {
            bool checkPass = false;
            if (name.Length >= 3 && name.Length <= 25)
            {
                checkPass = true;
                foreach (char c in name)
                {
                    if (char.IsDigit(c))
                    {
                        checkPass = false;
                        break;
                    }
                }

            }
            return checkPass;

        }
        public string GenerateEmail()
        {
            string email = Name.ToLower() + "." + Surname.ToLower() + Id + "@code.edu.az";
            return email;
        }

        public void GetInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Surname);
            Console.WriteLine(CodeEmail);

        }
    }
}
