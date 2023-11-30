

using lambdaExpressions;

Func<int,int> square =number => number * number;

Console.WriteLine(square(5));
Console.WriteLine(Maths.Square(5));
