

namespace ChallengeApp2.Tests
{
    public class SupervisorTests
    {
        [Test]

        public void WhenSupervisorCollectsGrades_ShouldReturnCorrectAverage()
        {
            // arrange

            var supervisor = new Supervisor("Bogdan", "R");
            supervisor.AddGrade("2+");
            supervisor.AddGrade("2+");
            supervisor.AddGrade(6);


            // act

            var statistics = supervisor.GetStatistics();

            // assert

            Assert.AreEqual(Math.Round(50.00, 2), Math.Round(statistics.Average, 2));


        }

    }
}
