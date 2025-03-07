using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp2
{
    interface IEmployee
    {
        public string Name { get; }

        public string Surname { get; }

        public void AddGrade(float grade);

        public void AddGrade(string grade);

        public void AddGrade(char grade);

        public void AddGrade(double grade);


        Statistics GetStatistics();
    }
}
