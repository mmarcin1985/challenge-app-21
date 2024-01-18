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

        public void AddScoreAward(float rate)
        {
            this.score.Add(rate);
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
