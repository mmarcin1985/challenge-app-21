
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



        public override Statistics GetStatistic()
        {
            var statistics = new Statistics();
            if (this.score.Count > 0)
            { 
                foreach (var score in this.score)
                {
                    statistics.Addgrade(score);
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
