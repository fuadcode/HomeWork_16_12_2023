

namespace HomeWork_16_12_2023.Domain.Models
{
    public class Student
    {
        private static int _nextId = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }    
        public int Point { get; set; }

        public Student( string name, string surname, int age, int point)
        {
            Id = _nextId++;
            Name = name;
            Surname = surname;
            Age = age;
            Point = point;
        }
        public void ShowInfo()
        {    
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Point: {Point}");    
        }
        public static bool maxpoint (Student info1, Student info2)
        {
            return info1.Point > info2.Point;
        }
        public static bool minpoint (Student info1, Student info2)
        {
            return info1.Point < info2.Point;
        }
    }
   
}
