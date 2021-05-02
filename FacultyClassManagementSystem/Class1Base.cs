namespace FacultyClassManagementSystem
{
    public class Class1Base
    {
        public string name;
        public string address;
        public string subjectHandle;
        public string position;
        public string schedule;

        public string age { get; internal set; }

        public string getData()
        {
            return this.name + age + address + subjectHandle + position + position;
        }
    }
}