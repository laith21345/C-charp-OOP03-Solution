namespace Program
{
    #region Q3
    //3.Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee[] EmpArr;)
    //Notes:
    //•	Implement All the Necessary Member Functions on the Class(Getters, Setters)
    //•	Define all the Necessary Constructors for the Class
    //•	Allow NO RUNTIME errors if the user inputs any data
    //•	Write down all the necessary Properties(Instead of setters and getters)
    #endregion
    internal class Employees
    {
        Employee[] employees;
        
        public Employees()
        {
            employees = new Employee[3];
            employees[0].SecurityLevel = Enums.SecurityLevel.DBA;
            employees[1].SecurityLevel = Enums.SecurityLevel.guest;
            employees[2].SecurityLevel = Enums.SecurityLevel.security;
        }
    }
}
