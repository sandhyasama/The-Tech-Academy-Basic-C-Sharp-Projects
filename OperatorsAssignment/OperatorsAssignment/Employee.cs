using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment
{
    public class Employee
    {
        //Id property of Employee class
        public int Id { get; set; }
        //firstName property of Employee class
        public string firstName { get; set; }
        //lastName property of Employee class
        public string lastName { get; set; }

        //== operator overload to compare two Employee objects based on their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            //if both are null, return tru 
            if (emp1 is null && emp2 is null)
                return true;
            //if one of them is null, return false
            if (emp1 is null || emp2 is null)
                return false;
            //otherwise , compare their Ids
            return emp1.Id == emp2.Id;
        }

        //i!= operator overload to compare two Employee objects based on their Id
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }
    }
}
