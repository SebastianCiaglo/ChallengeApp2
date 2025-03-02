using ChallengeApp2;


Employee employee1 =new Employee("Arek","T");

employee1.AddGrade("a");
employee1.AddGrade(900);
employee1.AddGrade(2);


var statistics = employee1.GetStatistics();

var statistics1 = employee1.GetStatisticsWithForEach();
var statistics2 = employee1.GetStatisticsWithFor();
var statistics3 = employee1.GetStatisticsWithDoWhile();
var statistics4 = employee1.GetStatisticsWithWhile();


Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");  

void SetSth(out Statistics statistics)
{
    statistics = new Statistics();
}


