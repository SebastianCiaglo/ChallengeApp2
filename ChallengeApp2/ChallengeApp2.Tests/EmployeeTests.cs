using System.Reflection.Metadata;

namespace ChallengeApp2.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void WhenEmployeeCollectsGrades_ShouldReturnCorrectSum()
        {
            // arrange

            var employee = new Employee("Bogdan", "R", 'k');
            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(2);
            employee.AddPenalty(-12);

            // act

            var result = employee.Result;

            // assert

            Assert.AreEqual(2, result);

        }

        [Test]
        public void WhenEmployeeCollectsGrades_ShouldReturnCorrectAverage()
        {
            // arrange

            var employee = new Employee("Bogdan", "R", 'k');
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);


            // act

            var statistics = employee.GetStatistics();

            // assert

            Assert.AreEqual(Math.Round(3.33,2), Math.Round(statistics.Average,2));
            

        }


        [Test]
        public void WhenEmployeeCollectsGrades_ShouldReturnCorrectMax()
        {
            // arrange

            var employee = new Employee("Bogdan", "R", 'k');
            employee.AddGrade(5);
            employee.AddGrade(7);


            // act

            var statistics = employee.GetStatistics();

            // assert

            
            Assert.AreEqual(7, statistics.Max);
            

        }


        [Test]
        public void WhenEmployeeCollectsGrades_ShouldReturnCorrectMin()
        {
            // arrange

            var employee = new Employee("Bogdan", "R", 'k');
            employee.AddGrade(5);
            employee.AddGrade(7);


            // act

            var statistics = employee.GetStatistics();

            // assert

           
            Assert.AreEqual(5, statistics.Min);

        }

        [Test]
        public void WhenEmployeeCollectsGrades_ShouldReturnCorrectLetter()
        {
            // arrange

            var employee = new Employee("Bogdan", "R", 'k');
            employee.AddGrade('a');
            employee.AddGrade("a");
            employee.AddGrade(100);
            employee.AddGrade('f');


            // act

            var statistics = employee.GetStatistics();

            // assert

            Assert.AreEqual('B', statistics.AverageLetter);

        }


    }
}