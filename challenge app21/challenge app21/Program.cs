using challenge_app21;

var emp1 = new Employee("Marcin", "Winer" , 38);

string teststring = "80";
char testchar = '9';
double testdouble = 11.48;
long testlong = 50;
decimal testdecimal = 100;

emp1.AddScoreAward(teststring);
emp1.AddScoreAward(testchar);
emp1.AddScoreAward(testdouble);
emp1.AddScoreAward(testlong);
emp1.AddScoreAward(testdecimal);


var statistics = emp1.GetStatistics();
Console.WriteLine($"Average:  {statistics.Average:N2}");  // ŚREDNIA Z DOKŁADNOŚCIĄ O JEDNĄ CYFRĘ WIĘCEJ NIŻ OcENA
Console.WriteLine($"Min:  {statistics.Min:N1}");
Console.WriteLine($"Max:  {statistics.Max:N1}");



