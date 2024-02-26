

using static challenge_app21.EmployeeBase;

namespace challenge_app21
{
    internal interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        string Sex { get; }

        int Age { get; }

        void AddScoreAward(float rate);

        void AddScoreAward(string rate);

        void AddScoreAward(char rate);

        void AddScoreAward(double rate);

        event GradeAddedDelegate GradeAdded;

        Statistics GetStatistic();
    }
}
