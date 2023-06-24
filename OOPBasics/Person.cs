using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class Person
    {
        //  public string Name;
        public string firstName;
        public string middleName;
        public string lastName;
        private decimal salary;


        public decimal Salary
        {
            get
            {
                return salary; 
            }
            set
            {
                if (Salary > 0) {
                    Salary = value;
                }
                
            }
        }

        //public void SetSalary (decimal salary)
        //{
        //    if (salary > 0) { 
            
        //    this.salary = salary;
        //    }
            
        //}

        //public decimal GetSalary()
        //{
        //    return salary;
        //}


        public Person(string firstName, string middleName, string lastName):this(firstName, lastName)   /// this is called constactor chaining ...    
        {  
            //this.LastName =lastName;
            this.firstName = firstName;
            //this.MiddleName = middleName;   
        }

        public Person(string firstName, string lastName): this ()
        {
            this.lastName = lastName;
            this.firstName = firstName;
          
        }
        public Person()
        {  
        }

        public Person(Person person) //copy constructor kortechi 
        {
            firstName = person.firstName;
            middleName = person.middleName;
            lastName = person.lastName;
        }
        public string  GetFullName(){

            return  "  "+ firstName +" "+ middleName +" "+  lastName;
        }

    }
}
