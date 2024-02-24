using challenge_app21;

Console.WriteLine("Welcome in employee evaluation app");
Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");

var emp1 = new EmployeeInFile("Marcin", "file", "male",39);
var emp2 = new EmployeeInFile("Marcin", "mem", "male", 39);
emp1.GradeAdded += EmployeeGradeAdded;
emp2.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded (object sender, EventArgs args)
{
    Console.WriteLine("New grade added");
}

emp1.AddScoreAward('A');
emp1.AddScoreAward("100");
emp1.AddScoreAward("100");
emp1.AddScoreAward(100);


emp2.AddScoreAward('A');
emp2.AddScoreAward("100");
emp2.AddScoreAward("100");
emp1.AddScoreAward(90);


while (true)
{
    Console.WriteLine(" Input employee evaluation or q to finish");
    string input = Console.ReadLine();
    if ((input == "q" ) || (input == "Q"))
    {
        break;
    }
    try
    {
        emp1.AddScoreAward(input);
    }
    catch (Exception e)
    {
        Console.WriteLine ($"Exception catched: {e.Message}");
    }
}


try
{
    var statistics = emp1.GetStatistic();
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max {statistics.Max}");
    Console.WriteLine($"Average {Math.Round(statistics.Average, 2)}");
    Console.WriteLine($"Number of notes {statistics.NumberOfNotes}");
    Console.WriteLine($"Rank {statistics.Rank}");
}
catch (Exception e)
{
    Console.WriteLine($"Exception catched: {e.Message}");
}