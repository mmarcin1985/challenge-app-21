

namespace challenge_app21.Tests
{

    public class LetterRankTest
    {

        [Test]
        public void LetterRankAndevaluationTest_WhenScoringByCharOrLetterShouldAssignCorrectNumberScoreAnDEvaluationByLetter()
        {

            // arrange
            var empA = new Employee("A","100");
            var empB = new Employee("B", "80");
            var empC = new Employee("B", "60");
            var empD = new Employee("B", "40");
            var empE = new Employee("E", "20");
            var empF= new Employee("F","0");

            empA.AddScoreAward('A');
            empB.AddScoreAward("B");
            empC.AddScoreAward("c");
            empD.AddScoreAward("D");
            empE.AddScoreAward('e');
            empF.AddScoreAward('f');
            empA.AddScoreAward(90);
            empB.AddScoreAward(70);
            empC.AddScoreAward(50);
            empD.AddScoreAward(30);
            empE.AddScoreAward(10);
            empF.AddScoreAward(10);

            //act
            var StatisticsA = empA.GetStatistic();
            var StatisticsB = empB.GetStatistic();
            var StatisticsC = empC.GetStatistic();
            var StatisticsD = empD.GetStatistic();
            var StatisticsE = empE.GetStatistic();
            var StatisticsF = empF.GetStatistic();

            //assert

            
            Assert.AreEqual(StatisticsA.Max, 100);
            Assert.AreEqual(StatisticsA.Min, 90);
            Assert.AreEqual(StatisticsA.Average, 95);
            Assert.AreEqual(StatisticsA.Rank, 'A'); 

            Assert.AreEqual(StatisticsB.Max, 80);
            Assert.AreEqual(StatisticsB.Min, 70);
            Assert.AreEqual(StatisticsB.Average, 75);
            Assert.AreEqual(StatisticsB.Rank, 'B');

            Assert.AreEqual(StatisticsC.Max, 60);
            Assert.AreEqual(StatisticsC.Min, 50);
            Assert.AreEqual(StatisticsC.Average, 55);
            Assert.AreEqual(StatisticsC.Rank, 'C');

            Assert.AreEqual(StatisticsD.Max, 40);
            Assert.AreEqual(StatisticsD.Min, 30);
            Assert.AreEqual(StatisticsD.Average, 35);
            Assert.AreEqual(StatisticsD.Rank, 'D');

            
            Assert.AreEqual(StatisticsE.Max, 20);
            Assert.AreEqual(StatisticsE.Min, 10);
            Assert.AreEqual(StatisticsE.Average, 15);
            Assert.AreEqual(StatisticsE.Rank, 'E');
            
            
            Assert.AreEqual(StatisticsF.Max, 10);
            Assert.AreEqual(StatisticsF.Min, 0);
            Assert.AreEqual(StatisticsF.Average, 5);
            Assert.AreEqual(StatisticsF.Rank, 'F');
            

        }


    }

    
}
