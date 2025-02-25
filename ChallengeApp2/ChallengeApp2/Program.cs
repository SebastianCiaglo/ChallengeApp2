using ChallengeApp2;


Employee employee1 =new Employee("Arek","T", 33);
Employee employee2 = new Employee("Michal", "R", 43);
Employee employee3 = new Employee("Julka", "B", 26);


employee1.AddGrade(5);
employee1.AddGrade(9);
employee1.AddGrade(2);
employee1.AddGrade(10);
employee1.AddGrade(3);

employee2.AddGrade(5);
employee2.AddGrade(8);
employee2.AddGrade(7);
employee2.AddGrade(1);
employee2.AddGrade(3);

employee3.AddGrade(4);
employee3.AddGrade(3);
employee3.AddGrade(4);
employee3.AddGrade(10);
employee3.AddGrade(7);

List<Employee> employees = new List<Employee>()
{ employee1, employee2, employee3 };

int MaxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if(employee.Result> MaxResult)
    {
        employeeWithMaxResult = employee;
        MaxResult = employee.Result;
    }
}



Console.WriteLine(employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " lat " + employeeWithMaxResult.Age + " ma ocene " + employeeWithMaxResult.Result);



