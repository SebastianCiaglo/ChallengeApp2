
namespace ChallengeApp2
{
    public class EmployeeInMemory : EmployeeBase
    {
        //public override delegate void GradeAddedDelegate(object sender, EventArgs args);

        public override event GradeAddedDelegate GradeAdded;


        private List<float> grades = new List<float>();

        public EmployeeInMemory(string name, string surname) : base(name, surname)
        {

        }

        private void WriteMessageInConsole(string message)
        {
            Console.WriteLine(message); 
        }

        private void WriteMessageInConsoleInUpper(string message)
        {
            Console.WriteLine(message.ToUpper());
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }

            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char charresult))
            {
                this.AddGrade(charresult);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                case 'F':
                case 'f':
                    this.AddGrade(0);
                    break;
                default:
                    throw new Exception("Invalid grade value");
            }
        }

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }
        

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            var index = 0;

            do
            {

                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];

                index++;

            } while (index < this.grades.Count);




            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
