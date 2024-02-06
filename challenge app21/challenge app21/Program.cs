using challenge_app21;

Console.WriteLine("Welcome in employee evaluation app");
Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");

var emp1 = new Employee("Marcin", "Winer" );

//testy jedmostkowe dla liter
// ocena koncowa w literach 

while (true)
{
    Console.WriteLine(" Input employee evaluation or q to finish");
    var input = Console.ReadLine();
    if ((input == "q" ) || (input == "Q"))
    {
        break;
    }
    emp1.AddScoreAward(input);

}

var statistics = emp1.GetStatistic();
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max {statistics.Max}");
Console.WriteLine($"Average {Math.Round(statistics.Average,2)}");
Console.WriteLine($"Number of notes {statistics.NumberOfNotes}");
Console.WriteLine($"Rank {statistics.Rank}");
