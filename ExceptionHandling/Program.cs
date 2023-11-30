
using ExceptionHandling;

try
{

    //try executing this code
    //Maths.Divide(12, 0);
    Twitter.GetTweets("Doe");
}
catch(Exception ex)
{
    //if an error happens handle it here 
    Console.WriteLine(ex.Message);
}