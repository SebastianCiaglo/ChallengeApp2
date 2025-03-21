

namespace ChallengeApp2
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname) : base(name, surname)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }

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

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);


                            statistics.Max = Math.Max(statistics.Max, number);
                            statistics.Min = Math.Min(statistics.Min, number);
                            statistics.Average += number;

                            index++;
                        line = reader.ReadLine();
                    }
                    
                    if(index!=0)
                    { 
                        statistics.Average /= index; 
                    }

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

                }
            }
            return statistics;
        }
    }
}
