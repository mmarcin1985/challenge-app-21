

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace challenge_app21
{
    internal class EmployeeInFile : EmployeeBase
    {
        private List<float> score = new List<float>();
        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInFile(string name, string surname, string sex, int age) : base(name, surname, sex, age)
        {
        }

        private string FileNamer()
        {
            string FileName = "Gradesfor" + base.Name + base.Surname + ".txt";
            return FileName;
        }



        public override void AddScoreAward(float rate)
        {
            if ((rate >= 0) && (rate <= 100))
            {
                using (var writer = File.AppendText(this.FileNamer()))
                {
                    writer.WriteLine(rate);
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception($" {rate} out of range please input number from range  0-100");
            }

        }

        // metody dla string, char , double bazuja na metodzie dla float , dzięki przciążeniu float  mogly wrocić do klasy bazowej.

        private void  CreateListFromFile()
        {
            if (File.Exists(this.FileNamer())) 
            {
               using (var reader = File.OpenText(this.FileNamer()))
                {
                    var line = reader.ReadLine();
                    while (line != null) 
                    {
                        if (float.TryParse(line, out float results))
                        {
                            if (results >= 0 && results <= 100)
                            {
                                score.Add(results);
                                line = reader.ReadLine();
                            }
                            else
                            {
                                line = reader.ReadLine();
                            }
                        }
                        else
                        {
                            line = reader.ReadLine();
                            
                        }
                    }
                }
            }
            else 
            {
                throw new Exception($" {this.FileNamer} don't exist statistics can not be generated ");
            }
        }


        public override Statistics GetStatistic()
        {
            CreateListFromFile();
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
                throw new Exception("No correct rate existing in file, statistic can not be generated");
            }
        }
    }
}

