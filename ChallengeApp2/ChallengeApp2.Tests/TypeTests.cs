

namespace ChallengeApp2.Tests
{
    public class TypeTests
    {
        [Test]
        public void GetEmployeeShouldReturnSameValues()
        {
            // arrange

            int number1 = 1;
            int number2 = 1;

            // act


            // assert

            Assert.AreEqual(number1, number2);

        }



        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            // arrange

            var employee1 = GetEmployee("Janusz", "T", 'm');
            var employee2 = GetEmployee("Jan", "Z", 'm');

            // act


            // assert

            Assert.AreNotEqual(employee1, employee2);

        }

        private Employee GetEmployee(string name, string surname, char sex)
        {

            return new Employee(name, surname, sex);

        }


    }
}
