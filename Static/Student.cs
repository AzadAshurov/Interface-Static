namespace Static
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public static int StudentCount = 0;
        public string Id;
        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            StudentCount++;
            Id = "ST" + StudentCount;

        }
    }
}
