using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourse
{
    public  class Student
    {
        public List<Course> EnrolledCourse=  new List<Course>();
        public string Id { get; set; }
        public string Name { get; set; }
        public List<string> EmailCollection = new List<string>();

        public double GetCGPA()
        {

            throw new NotImplementedException(); /// be professional ... 
                                                 ///  need to throw exception when yoiu dont make implementation.....
           // return 0;
        }
    }
}
