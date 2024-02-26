
namespace challenge_app21

{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public float Average
        {
            get
            {
                return this.Sum / this.NumberOfNotes;
            }
        }

        public char Rank 
        { 
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 90:
                        return 'A';
                    case var average when average >= 70:
                        return 'B'; 
                    case var average when average >= 50:
                        return'C';
                    case var average when average >= 30:
                        return 'D';
                    case var average when average >= 10:
                        return 'E';
                    case var average when average >= 0:
                        return 'F';
                    default:
                        return 'N';
                }
            }
        }

        public int NumberOfNotes {get; private  set; }
 

        public Statistics()
        {
            this.NumberOfNotes = 0;
            this.Sum = 0;
            this.Max = float.MinValue; 
            this.Min = float.MaxValue;
        }

        public void Addgrade(float grade)
        {
            this.NumberOfNotes++;
            this.Sum += grade;
            this.Min= Math.Min(this.Min, grade);
            this.Max = Math.Max(this.Max, grade);
        }


    }
}
