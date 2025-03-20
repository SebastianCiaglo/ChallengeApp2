using ChallengeApp2;

Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine();
Console.WriteLine();

var employee = new Employee("Bogdan", "R", 'k');
var employeeInMemory = new EmployeeInMemory("Bogdan", "Rr");
var employeeInFile = new EmployeeInFile("Bogdan", "Rr");

/*
try
{



}
catch(Exception exception)
{

    Console.WriteLine(exception.Message);

}
*/


while(true)
{
    Console.WriteLine("Podaj ocene pracownika: ");
    var input = Console.ReadLine();

    if (input == "q")
    { 
        break; 
    }

    try
    {
        //employee.AddGrade(input);
        employeeInMemory.AddGrade(input);
        employeeInFile.AddGrade(input);
    }
    catch(Exception exception)
    {
        Console.WriteLine($"Exception catched: {exception.Message}");
    }
}    



var statistics = employeeInFile.GetStatistics();
//var statistics = employeeInMemory.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Letter: {statistics.AverageLetter}");



