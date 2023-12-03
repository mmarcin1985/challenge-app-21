using challenge_app21;

Employee emp1 = new Employee("Marcin", "Winer" , 38);
Employee emp2 = new Employee("Edward", "Loser" , 23);
Employee emp3 = new Employee("Andrzej", "Averager" , 35);

emp1.AddScoreAward(9);
emp2.AddScoreAward(9);
emp3.AddScoreAward(9);
emp1.AddScoreAward(5);
emp2.AddScoreAward(9);
emp3.AddScoreAward(9);
emp1.AddScoreAward(9);
emp2.AddScoreAward(9);
emp3.AddScoreAward(9);

emp1.AddScorePunish(8);
emp2.AddScorePunish(7);
emp3.AddScorePunish(1);


List<Employee> emps = new List<Employee>()
{
    emp1,emp2,emp3
};

int maxRate = 0;
List<Employee> bestsEmp = new List<Employee>(); // Lista użytkownikow z najlepszym rezulatem na wypadek kilku z tym samym 


foreach (var emp in emps)  // ustalamy najwyższa ocenę
{
    if (emp.Rating > maxRate)
        maxRate = emp.Rating;
}


foreach (var emp in emps)  // wyszukujemy użytkownikow z najwyżsża oceną i dodajemy do listy
{
    if (emp.Rating == maxRate)
        bestsEmp.Add(emp);
}

Console.WriteLine("Najlepszy/najlepsze wyniki :  " + maxRate + " uzyskał/ła/li:  ");

foreach (var emp in bestsEmp)  //drukujemy użytkownikow z najlepszym wynikiem
{
    Console.WriteLine(emp.Name + "   "  + emp.Surname);
}