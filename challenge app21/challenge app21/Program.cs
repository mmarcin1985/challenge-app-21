using challenge_app21;


Console.WriteLine("Welcome in employee evaluation app");
Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");

var emp1 = new EmployeeInMemory("Marcin", "Memory", "male", 39);
var emp2 = new EmployeeInFile("File", "file", "female", 55);

emp1.GradeAdded += EmployeeGradeAdded;
emp2.GradeAdded += EmployeeGradeAdded;


void EmployeeGradeAdded (object sender, EventArgs args)
{
    Console.WriteLine("New grade added");
}


while (true)   // testowo dodaje obu uzytkownikom  tą sama note
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
        emp2.AddScoreAward (input);
    }
    catch (Exception e)
    {
        Console.WriteLine ($"Exception catched: {e.Message}");
    }
}


try
{
    var statistics = emp1.GetStatistic();
    Console.WriteLine($" {emp1.Name}   {emp1.Surname} ");
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

try
{
    var statistics = emp2.GetStatistic();
    Console.WriteLine($" {emp2.Name}   {emp2.Surname} ");
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

