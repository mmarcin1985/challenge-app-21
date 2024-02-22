using challenge_app21;

Console.WriteLine("Welcome in employee evaluation app");
Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");

var emp1 = new EmployeeInFile("Marcin", "Winer", "male",39);

/*
emp1.AddScoreAward('A');
emp1.AddScoreAward("100");
emp1.AddScoreAward("100");
emp1.AddScoreAward(100);
*/


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