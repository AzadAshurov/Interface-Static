namespace Static
{
    internal class Group
    {
        public static Student[][] Groups = new Student[0][];
        private static int GroupCount = 0;
        private int GroupCountCopy;
        private string GroupId;
        private string GroupName;
        public Student[] Students = new Student[0];

        public Group(string name)
        {
            GroupName = name;
            GroupCount++;
            GroupCountCopy = GroupCount;
            GroupId = "GR" + GroupCount;
            Array.Resize(ref Groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = Students;
        }
        public void AddStudent(string studentName, string studentSurname)
        {
            Student student = new Student(studentName, studentSurname);
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
            Console.WriteLine($"Added {student.Name} {student.Surname} to group {GroupName}");
            Groups[GroupCountCopy - 1] = Students;

        }
        public void GetGroupInfo()
        {
            Console.WriteLine($"Group Id: {GroupId} \n Group Name: {GroupName} \nAnd its students:");
            foreach (Student student in Students)
            {
                Console.WriteLine($"{student.Name} {student.Surname} {student.Id}");
            }

        }
        public void GetStudent(string id)
        {
            foreach (Student student in Students)
            {
                if (id == student.Id)
                {
                    Console.WriteLine(student.Name);
                    break;
                }
            }
        }
        public void Search(string name)
        {

            foreach (Student student in Students)
            {
                if (name == student.Name || name == student.Surname)
                {
                    Console.WriteLine($"{student.Name} \n{student.Surname}\n{student.Id}");


                }
            }

        }
        public void ShowStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine($"{student.Name} {student.Surname} {student.Id}");
            }
        }

        public void RemoveStudent(string id)
        {
            int indexToRemove = -1;


            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id)
                {
                    indexToRemove = i;
                    break;
                }
            }
            if (indexToRemove != -1)
            {
                for (int i = indexToRemove; i < Students.Length - 1; i++)
                {
                    Students[i] = Students[i + 1];
                }
                Array.Resize(ref Students, Students.Length - 1);
                Console.WriteLine($"Removed student with Id: {id}");
            }
            else
            {
                Console.WriteLine($"Student with Id: {id} not found.");
            }
            Groups[GroupCountCopy - 1] = Students;
        }


        public static void ShowAllGroups()
        {
            for (int i = 0; i < Groups.Length; i++)
            {
                for (int j = 0; j < Groups[i].Length; j++)
                {
                    Console.WriteLine($"{Groups[i][j].Name} {Groups[i][j].Surname} {Groups[i][j].Id} ");
                }
            }
        }
        public static void AddGroup(Student[] group)
        {
            Array.Resize(ref Groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = group;
            Console.WriteLine("Group added");

        }
        public static void RemoveGroup(string groupId)
        {
            int groupIndex;
            groupIndex = Convert.ToInt32((groupId.Substring(2))) - 1;
            if (groupIndex < 0 || groupIndex >= Groups.Length)
            {
                Console.WriteLine("No group with this index");
                return;
            }
            for (int i = groupIndex; i < Groups.Length - 1; i++)
            {
                Groups[i] = Groups[i + 1];
            }
            Array.Resize(ref Groups, Groups.Length - 1);
            Console.WriteLine($"Group {groupId} removed");
            int newIndex = 0;
            for (int i = 0; i < Groups.Length; i++)
            {
                for (int j = 0; j < Groups[i].Length; j++)
                {
                    newIndex++;
                    Groups[i][j].Id = "ST" + newIndex;

                }
            }
        }



    }
}
