
using delagates;

try
{
    PhotoProcessor photoProcessor = new PhotoProcessor();
    Filters filters = new Filters();

    Action<Photo> filterHandler = filters.AddBrightness;
    filterHandler += filters.changeBackground;
    filterHandler += MyCustomFilter.addCircle;

    //var num = 67;
    //num = 65;
    //num = 34;
    //    Console.WriteLine(num);

    photoProcessor.Process(filterHandler);
}
catch(Exception ex)
{

    Console.WriteLine(ex.Message);
}
//invoking/calling- just pointing to the method 