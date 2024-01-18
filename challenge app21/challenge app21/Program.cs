using challenge_app21;

var emp1 = new Employee("Marcin", "Winer" , 38);

emp1.AddScoreAward(2);
emp1.AddScoreAward(2);
emp1.AddScoreAward(6);

var statistics = emp1.GetStatistics();
Console.WriteLine($"Average:  {statistics.Average:N2}");  // ŚREDNIA Z DOKŁADNOŚCIĄ O JEDNĄ CYFRĘ WIĘCEJ NIŻ ONENA
Console.WriteLine($"Min:  {statistics.Min:N1}");
Console.WriteLine($"Max:  {statistics.Max:N1}");


