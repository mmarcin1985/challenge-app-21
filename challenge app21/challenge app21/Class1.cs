namespace challenge_app21
{
     public class Employee
    {
        private List<int> score = new List<int>();

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

        public void AddScoreAward (int rate)
        {
            this.score.Add(rate);
        }

        public void AddScorePunish(int rate)
        {
            this.score.Add(-rate);
        }

        public int Rating
        {
            get
            {
                return this.score.Sum();
            }
        }
    }
}
