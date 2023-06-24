// See https://aka.ms/new-console-template for more information

//  basic OOP concepts and learning the "call by referance" and "call by value things " [[[[he he]]]]

using OOPBasics;

//Person person = new Person();

//person.FirstName = "MD";
//person.MiddleName = "Nadim";
//person.LastName = "Hasan";
 //string fullname=  person.GetFullName();
  

//Person p1 =  new Person();
//p1.FirstName = "Test";
//p1.MiddleName = " ";
//p1.LastName = "donno";

//Person p2 = new Person();
//p2.FirstName = "Mohammad";
//p2.LastName = "Rasel vai";
//p2 = p1;
//p1 = null;
  
//Person p3 = p2;

//p3.FirstName = "Test_one";
//p3.MiddleName = "middle name ";
//p3.LastName = " last name";  



//Console.WriteLine("Hello "+ fullname );



Person person= new Person("MD","RIFAT","Hasan");

Person person1 = new Person("MD", "Hasan");

Person person2 = new Person();

Person p1 = new Person(person);

//person.salary = 2000;
//person.SetSalary(200000);


person.Salary = 100000000;  


Console.WriteLine(person.GetFullName());
Console.ReadLine();    