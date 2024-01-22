using challenge_app21;

var emp1 = new Employee("Marcin", "Winer" , 38);



emp1.AddScoreAward(10);
emp1.AddScoreAward(20);
emp1.AddScoreAward(30);
emp1.AddScoreAward(40);
emp1.AddScoreAward(50);    // średnia 30 


var statisticsForEach = emp1.GetStatisticsWithForEach();
Console.WriteLine("For Each");
Console.WriteLine($"Average:  {statisticsForEach.Average:N2}");  
Console.WriteLine($"Min:  {statisticsForEach.Min:N1}");
Console.WriteLine($"Max:  {statisticsForEach.Max:N1}");


var statisticsWithFor = emp1.GetStatisticsWithFor();
Console.WriteLine("For");
Console.WriteLine($"Average:  {statisticsWithFor.Average:N2}");
Console.WriteLine($"Min:  {statisticsWithFor.Min:N1}");
Console.WriteLine($"Max:  {statisticsWithFor.Max:N1}");


var statisticsWithDoWhile = emp1.GetStatisticsWithDoWhile();
Console.WriteLine("Do while");
Console.WriteLine($"Average:  {statisticsWithDoWhile.Average:N2}");
Console.WriteLine($"Min:  {statisticsWithDoWhile.Min:N1}");
Console.WriteLine($"Max:  {statisticsWithDoWhile.Max:N1}");


var statisticsWithWhileDo = emp1.GetStatisticsWithWhileDo();
Console.WriteLine("WhileDo");
Console.WriteLine($"Average:  {statisticsWithWhileDo.Average:N2}");
Console.WriteLine($"Min:  {statisticsWithWhileDo.Min:N1}");
Console.WriteLine($"Max:  {statisticsWithWhileDo.Max:N1}"); 