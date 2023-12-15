
using HomeWork_16_12_2023.Domain.Models;

Student student = new("Nihad","Verdizade",17,50);
Student student2 = new("Fuad", "Iskenderov", 20, 100);
Student student3 = new("Nazim", "Eliyev", 24, 75);
Student student4 = new("Elnur", "Velizade", 21, 80);
Student student5 = new("Rauf", "Iskenderli", 32, 65);

Group group = new ();
group.AddStudent (student);
group.AddStudent (student2);
group.AddStudent (student3);
group.AddStudent (student4);
group.AddStudent(student5);


foreach (var studentinfo in group.GettAllStudents())
{
  Console.WriteLine($"Name: {studentinfo.Name}, Surname: {studentinfo.Surname}, Point: {studentinfo.Point}" );
}

foreach (var studentinfo in group.Sort())
{
  Console.WriteLine($"Name: {studentinfo.Name}, Surname: {studentinfo.Surname},Point: {studentinfo.Point}");
}

Group group2 = new();
Console.WriteLine(group2.No);
Group group3 = new();
Console.WriteLine(group3.No);
Group group4 = new();
Console.WriteLine(group4.No);
Group group5 = new();
Console.WriteLine(group5.No);
Group group6 = new();
Console.WriteLine(group6.No);