// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using StudentCourse;

Course course1 = new Course() { Title = "C# basis", CGPA = 4.0 };
Course course2= new Course() { Title = "DB basics", CGPA = 4.0 };
Course course3 = new Course() { Title = "ASP. NET", CGPA = 4.0 };

Student student1 = new Student();

student1.Name = "Nadim";
student1.EmailCollection.Add("nadimhasan753990@gmail.com");
student1.EmailCollection.Add("aethowri0htel@gmail.com");
student1.Id = "12-34";
student1.EnrolledCourse.Add(course1);
student1.EnrolledCourse.Add(course2);
foreach(Course aCourse in student1.EnrolledCourse)
{
    Console.WriteLine(aCourse.Title);
}

//Console.WriteLine(student1.EnrolledCourse.Title);

foreach(string email in student1.EmailCollection)
{
    Console.WriteLine(email);

}



Student student2 = new Student();

student2.Name = "Hasan";
//student2.Email = "hasan753990@gmail.com";
student2.Id = "12-35";

double cgpa =  student1.GetCGPA();