namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("BP217");
            group.AddStudent("Azad", "Ashurov");
            group.AddStudent("Aslan", "Aslanli");
            group.AddStudent("Dart", "Veider");
            group.AddStudent("Tom", "Soer");
            Group group2 = new Group("BP217");
            group2.AddStudent("Murad", "Aslikov");
            group2.AddStudent("Asab", "Asimof");
            group2.AddStudent("Daret", "Veiderov");
            group2.AddStudent("Tomofei", "Soerov");

            group.Search("Azad");
            group2.GetStudent("ST5");


            group.GetGroupInfo();
            group2.GetGroupInfo();
            Group.ShowAllGroups();
            Student[] newGroup = new Student[]
      {
            new Student("Wert", "Greenov"),
            new Student("Klop", "Dertov"),
            new Student("Walter", "White")
      };
            Group.AddGroup(newGroup);
            Group.ShowAllGroups();
            Group.RemoveGroup("GR2");
            Group.ShowAllGroups();




        }
    }
}
