

using System.ComponentModel.Design;

namespace challenge_app21
{
    public class Employee
    {
        private List<float> score = new List<float>();

        public
            Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
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
                switch (rate)
                {
                    case "a":
                    case "A":
                        this.score.Add(100);
                        break;
                    case "b":
                    case "B":
                        this.score.Add(80);
                        break;
                    case "c":
                    case "C":
                        this.score.Add(60);
                        break;
                    case "d":
                    case "D":
                        this.score.Add(40);
                        break;
                    case "e":
                    case "E":
                        this.score.Add(20);
                        break;
                    case "f":
                    case "F":
                        this.score.Add(0);
                        break;
                    default:
                        Console.WriteLine("Incorrect letter or string please input letter A/a, B/b,C/c, D/d, E/e  or Q/q to quit");
                        break;
                }
            }
        }


        public void AddScoreAward(char rate)
        {
            string rate1 = rate.ToString();
            this.AddScoreAward(rate1);
        }



        public void AddScoreAward(double rate)
        {
            float rate1 = (float)rate;
            this.AddScoreAward(rate1);
        }

       


        public float Rating
        {
            get
            {
                return this.score.Sum();
            }
        }
        public Statistics GetStatistic()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.NumberOfNotes = 0;
            statistics.Rank = 'N';
            foreach (var score in this.score)
            {
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Average += score;
            }
            statistics.Average /= this.score.Count;
            statistics.NumberOfNotes = this.score.Count;

            switch (statistics.Average)
            {
                case var average when average >= 90:
                    statistics.Rank = 'A';
                    break;
                case var average when average >= 70:
                    statistics.Rank = 'B';
                    break;
                case var average when average >= 50:
                    statistics.Rank = 'C';
                    break;
                case var average when average >= 30:
                    statistics.Rank = 'D';
                    break;
                case var average when average >= 10:
                    statistics.Rank = 'E';
                    break;
                case var average when average >= 0:
                    statistics.Rank = 'F';
                    break;
                default:
                    statistics.Rank = 'N';
                    break;
            }
            return statistics;
        }
    }
}
