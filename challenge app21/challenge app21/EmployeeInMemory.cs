
namespace challenge_app21
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> score = new List<float>();
        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInMemory(string name, string surname, string sex, int age) : base(name, surname, sex, age)
        {
        }

        public override void AddScoreAward(float rate) 
        {
            if (rate >= 0 && rate <= 100)
            {
                this.score.Add(rate);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception($" {rate} out of range, wll be not register,  please input number from range  0-100");
            }

        }


        // metody dla string, char , double bazuja na metodzie dla float , dzięki przciążeniu float  mogly wrocić do klasy bazowej


        public override Statistics GetStatistic()
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

            if (this.score.Count > 0)
            {
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
            else
            {
                throw new Exception("No correct rate added, statistics can not be generated");
            }
        }
    }
}
