using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace challenge_app21
{
     public class Employee
    {
        private List<float> score = new List<float>();

        public
            Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public void AddScoreAward(float rate)  // obsłuży rownież int
        {
            if (rate >= 0 && rate <= 100)
            {
                this.score.Add(rate);
            }
            else
            {
                Console.WriteLine($" {rate}  poza zakresem należy podać ocene z zakresu 0-100");
            }
        }


        public void AddScoreAward(string rate)   
        {
            if (float.TryParse(rate, out float results))
            {
                this.AddScoreAward(results);
            }
            else
            {
                Console.WriteLine($" {rate} -  ciag znaków nie moze być przetworzony na liczbe");
            }
        }

        public void AddScoreAward(char rate)
        { 
            string rate1 = rate.ToString();  // mamy string czyli wywolujemy metode dla string
            this.AddScoreAward(rate1);
        }

        
        public void AddScoreAward(double rate)
        { 
            float rate1 = (float)rate;
            this.AddScoreAward(rate1);
        }

        public void AddScoreAward(long rate)
        {
            float rate1 = (long)rate;
            this.AddScoreAward(rate1);
        }

        public void AddScoreAward(decimal rate)
        {
            string rate1 = rate.ToString();
            this.AddScoreAward(rate1);
        }

        public void AddScorePunish(float rate)
        {
            this.score.Add(-rate);
        }
        public float Rating
        {
            get
            {
                return this.score.Sum();
            }
        }
        public Statistics GetStatistics ()
        {
            var statistics = new Statistics ();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            foreach (var score in this.score)
            {
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Average += score;
            }
            statistics.Average /=  this.score.Count;
            return statistics;
        }
    }
}
