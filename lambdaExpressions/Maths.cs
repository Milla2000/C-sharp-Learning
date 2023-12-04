namespace lambdaExpressions
{
    public  class Maths
    {



        
        public static int  Square(int number)
        {
            return number * number;
        }

        public static List<Employee> initializeEmployees()
        {
            Employee emp = new Employee()
            {
                Id = 1,
                Name = "Samuel",
                Salary = 170000
            };

            Employee emp1 = new Employee()
            {
                Id = 2,
                Name = "John",
                Salary = 1000000
            };

            Employee emp2 = new Employee()
            {
                Id = 3,
                Name = "John",
                Salary = 100000
            };

            Employee emp3 = new Employee()
            {
                Id = 4,
                Name = "Nancy ",
                Salary = 2000000
            };

            Employee emp5 = new Employee()
            {
                Id = 5,
                Name = "Zipeta ",
                Salary = 5000000
            };
            Employee emp4 = new Employee()
            {
                Id = 5,
                Name = "Jane Doe ",
                Salary = 500000
            };
            List<Employee> employees = new List<Employee>() { emp, emp1, emp2, emp3, emp4, emp5 };
            return employees;
        }
        public  static bool CheckEmployeeswithIdOne(Employee employee) {
            return employee.Id == 1;

        }

        // (number) => {return number * number} return -Multilines
        // const square =(number) => number * number
        // 

    }
}
