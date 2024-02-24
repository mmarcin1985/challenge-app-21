


namespace challenge_app21
{
    
    public abstract class EmployeeBase : IEmployee

    {

        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public abstract event GradeAddedDelegate GradeAdded;
        
        public EmployeeBase(string name, string surname, string sex, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
            this.Age = age;
        }


        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }
        public int Age { get; private set; }



        public abstract void AddScoreAward(float rate);

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
                        this.AddScoreAward(100);
                        break;
                    case "b":
                    case "B":
                        this.AddScoreAward(80);
                        break;
                    case "c":
                    case "C":
                        this.AddScoreAward(60);
                        break;
                    case "d":
                    case "D":
                        this.AddScoreAward(40);
                        break;
                    case "e":
                    case "E":
                        this.AddScoreAward(20);
                        break;
                    case "f":
                    case "F":
                        this.AddScoreAward(0);
                        break;
                    default:
                        throw new Exception("Incorrect letter or string please input letter A/a, B/b,C/c, D/d, E/e, number from range 0-100  or Q/q to quit");
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


    public abstract Statistics GetStatistic();

    }
}
