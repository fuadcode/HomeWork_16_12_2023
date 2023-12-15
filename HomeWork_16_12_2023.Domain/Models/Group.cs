
namespace HomeWork_16_12_2023.Domain.Models
{
    public class Group
    {
        private static int _nextGroupNo = 100;
        public string No { get; set; }

        private List<Student> Std { get; set; }
        public Group ()
        {
            Std = new List<Student>();
            No = $"AP{_nextGroupNo++}";
        }
        public List<Student> AddStudent(Student stdinfo)
        {
           Std.Add(stdinfo);
           return Std;
        }
        public List<Student> GettAllStudents()
        {
            return Std;
        }
        public List<Student> Sort()
        {
           List<Student> stage = new List<Student>(Std);
           stage.Sort((std1, std2) => std1.Point.CompareTo(std2.Point));
           return stage;
        }
    }
}
