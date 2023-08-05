using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATORS_SUBMISSION_ASSIGNMENT___STEP_314
{
    public class EMPLOYEE
    {
        // CREATE 3 PROPERITES 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        // OVERLOAD == OPERATOR
        public static bool operator ==(EMPLOYEE employee1, EMPLOYEE employee2)
        {
            if (employee1.Id.Equals(employee2.Id))
            {
                return true;
            }
            return false;
        }
        // OVERLOAD  != OPERATOR
        public static bool operator !=(EMPLOYEE employee1, EMPLOYEE employee2)
        {
            if (!employee1.Id.Equals(employee2.Id))
            {
                return true;
            }
            return false;
        }
        // OVERRIDE EQUALS MEHTOD
        public override bool Equals(object obj)
        {
            EMPLOYEE employee = obj as EMPLOYEE;

        if (employee !=null)

        {
            return employee.Id.Equals(this.Id);
        }
            return false;
        }

        // OVERRIDE HASH CODE METHOD
        public override int GetHashCode()
        {
            return this.Id;
        }

    }
   
}
