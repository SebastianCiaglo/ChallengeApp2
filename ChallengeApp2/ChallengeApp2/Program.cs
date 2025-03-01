using ChallengeApp2;


Employee employee1 =new Employee("Arek","T");

employee1.AddGrade(5);
employee1.AddGrade(9);
employee1.AddGrade(2);


var statistics = employee1.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");  

void SetSth(out Statistics statistics)
{
    statistics = new Statistics();
}


