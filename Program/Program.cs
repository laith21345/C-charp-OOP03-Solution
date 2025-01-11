
using Program.Enums;

namespace Program
{
    internal class Program
    {
        // C# OOP 03 Assignment Solution
        static void Main(/*string[] args*/)
        {
            #region Q1
            //1.Design and implement a Class for the employees in a company:
            //  Notes:
            //•	Employee is identified by an ID, Name, security level, salary, hire date and Gender.
            //•	We need to restrict the Gender field to be only M or F[Male or Female] 
            //•	Assign the following security privileges to the employee(guest, Developer, secretary and DBA) in a form of Enum.
            //•	We want to provide the Employee Class to represent Employee data in a string Form(override ToString()), display employee salary in a currency format. [Use String.Format() Function].

            //Employee employee = new Employee();
            //Console.WriteLine(employee);

            #endregion

            #region Q2
            //2.Develop a Class to represent the Hiring Date Data:
            //•	Consisting of fields to hold the day, month and Years.

            //Date myDate = new Date(12, 10, 1000);
            //Console.WriteLine(myDate);
            //myDate.Year = 0;
            //myDate.Year = 3;
            //Console.WriteLine(myDate);
            #endregion

            #region Q3
            //3.Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee[] EmpArr;)
            //Notes:
            //•	Implement All the Necessary Member Functions on the Class(Getters, Setters)
            //•	Define all the Necessary Constructors for the Class
            //•	Allow NO RUNTIME errors if the user inputs any data
            //•	Write down all the necessary Properties(Instead of setters and getters)

            Employee[] empArr =
            {
                new Employee(1, "Mohammed", Enums.SecurityLevel.DBA, 5000f,new DateOnly(2000,2,1),Gender.M),
                new Employee(2, "Ahmed", Enums.SecurityLevel.guest, 2000f,new DateOnly(2020,5,1),Gender.M),
                new Employee(3, "Ali", Enums.SecurityLevel.security, 3000f,new DateOnly(2000,2,4),Gender.M)
            };

            #endregion

            #region Q4
            //4. Sort the employees based on their hire date then Print the sorted array.
            //•	 While sorting(how many times Boxing and Unboxing process has occurred)

            Employee temp;
            for (int i = 0; i < empArr.Length -1; i++) //-1 because the last loop Not useful
            {
                for (int k = 0; k < empArr.Length -i-1 ; k++)// -1 because we compere with i+1  
                {
                    if (empArr[k].HireDate > empArr[k + 1].HireDate)
                    {
                        temp = empArr[k+1];
                        empArr[k+1]= empArr[k];
                        empArr[k]= temp;
                    }    
                }
            }
            for (int i = 0; i < empArr.Length; i++)
            {
                Console.WriteLine(empArr[i]);
                Console.WriteLine();
            }

            // 0 Boxing and Unboxing
            #endregion

            #region Q5
            //5. Design a program for a library management system where:
            //•	Book is a base class with properties like Title, Author, and ISBN.
            //•	EBook and PrintedBook are derived classes with additional properties like FileSize for EBook and PageCount for PrintedBook.
            //Demonstrate how inheritance simplifies the design.

            #endregion


        }
    }
}
