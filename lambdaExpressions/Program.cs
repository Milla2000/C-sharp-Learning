

using lambdaExpressions;

Func<int,int> square =number => number * number;

Func<int,string,string> concatenate= (a,b)=> {
    return a + b;
};

//Console.WriteLine(square(5));
//Console.WriteLine(Maths.Square(5));



var employees = Maths.initializeEmployees();
employees = employees.FindAll(Maths.CheckEmployeeswithIdOne);
//public static bool CheckEmployeeswithIdOne(Employee employee)
//{
//    return employee.Id == 1;

//}


employees= employees.FindAll(x=>x.Id == 1);