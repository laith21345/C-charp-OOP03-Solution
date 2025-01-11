using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program.Enums;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Program
{
    #region Q1
    //1.Design and implement a Class for the employees in a company:
    //  Notes:
    //•	Employee is identified by an ID, Name, security level, salary, hire date and Gender.
    //•	We need to restrict the Gender field to be only M or F[Male or Female] 
    //•	Assign the following security privileges to the employee(guest, Developer, secretary and DBA) in a form of Enum.
    //•	We want to provide the Employee Class to represent Employee data in a string Form(override ToString()), display employee salary in a currency format. [Use String.Format() Function].

    #endregion
    internal class Employee
    {
        #region Attributes
        int id;
        string name;
        SecurityLevel securityLevel;
        float salary;
        DateOnly hireDate;
        Gender gender;
        #endregion

        #region Properties
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (Id >= 0)
                    id = value;
                else
                    Console.WriteLine("ID can't be negative");
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public SecurityLevel SecurityLevel
        {
            get
            {
                return securityLevel;
            }
            set
            {
                if (value >= SecurityLevel.guest && value <= SecurityLevel.DBA)
                    securityLevel = value;
                else
                    Console.WriteLine("wrong value for SecurityLevel!");
            }
        }
        public float Salary 
        {
            get 
            {
                return salary;
            }
            set 
            {
                salary = value;
            }
        }
        public DateOnly HireDate
        {
            get
            {
                return hireDate;
            }
            set
            {
                hireDate = value;
            }
        }

        public Gender Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value >= Gender.M && value <= Gender.F)
                    gender = value;
                else
                    Console.WriteLine("wrong value for Gender!");
            }
        }
        #endregion

        public Employee(int _Id, string _Name, SecurityLevel _SecurityLevel, float _Salary,DateOnly _HireDate, Gender _Gender)
        {
            Id= _Id;
            Name= _Name;
            SecurityLevel = _SecurityLevel;
            Gender = _Gender;
            Salary = _Salary;
            Gender = _Gender;
            HireDate = _HireDate;
        }

        public override string ToString()
        {
            return $"the Emp info:\nID :{Id}, Name :{Name}, Gender :{Gender}, SecurityLevel :{SecurityLevel}, HireDate :{HireDate}, Salary {Salary:c}";
        }
    }
}
