using System.Reflection.Metadata;

namespace ChallengeApp2.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void WhenEmployeeCollectsGrades_ShouldReturnCorrectSum()
        {
            // arrange

            var employee = new Employee("Bogdan", "R");
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
        public void WhenEmployeeCollectsGrades_ShouldReturnCorrectStatistics()
        {
            // arrange

            var employee = new Employee("Bogdan", "R");
            employee.AddGrade(5);
            employee.AddGrade(7);


            // act

            var statistics = employee.GetStatistics();

            // assert

            Assert.AreEqual(6, statistics.Average);
            Assert.AreEqual(7, statistics.Max);
            Assert.AreEqual(5, statistics.Min);

        }





    }
}