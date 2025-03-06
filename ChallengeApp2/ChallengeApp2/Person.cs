
namespace ChallengeApp2
{
    public abstract class Person
    {
        private readonly char sex;

        public Person(string name, string surname, char sex) 
        {
            this.Name = name;
            this.Surname = surname;
            this.sex = sex;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }
    }
}
