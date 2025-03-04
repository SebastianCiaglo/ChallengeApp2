using ChallengeApp2;

Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine();
Console.WriteLine();

var employee = new Employee();

while(true)
{
    Console.WriteLine("Podaj ocene pracownika: ");
    var input = Console.ReadLine();

    if (input == "q")
    { 
        break; 
    }

    employee.AddGrade(input);
}    



var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Letter: {statistics.AverageLetter}");



