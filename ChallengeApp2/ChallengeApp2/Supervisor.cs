using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp2
{
    public class Supervisor : IEmployee
    {
        public string Name { get; private set; }

        public string Surname { get; private set; }

        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }


        public void AddGrade(float grade)
        {
            if (grade >= 1 && grade <= 6)
            {
                string gradeAsString = grade.ToString();
                this.AddGrade(gradeAsString);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;
                case "5":
                    this.grades.Add(80);
                    break;
                case "4":
                    this.grades.Add(60);
                    break;
                case "3":
                    this.grades.Add(40);
                    break;
                case "-3":
                    this.grades.Add(35);
                    break;
                case "3-":
                    this.grades.Add(35);
                    break;
                case "2+":
                    this.grades.Add(25);
                    break;
                case "+2":
                    this.grades.Add(25);
                    break;
                case "2":
                    this.grades.Add(20);
                    break;
                case "1":
                    this.grades.Add(0);
                    break;
                default:
                    throw new Exception("Invalid grade value");

            }
        }

        public void AddGrade(char grade)
        {
            string gradeAsString= grade.ToString();
            this.AddGrade(gradeAsString);
        }

        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public Statistics GetStatistics()
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

        public void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }
    }
}
