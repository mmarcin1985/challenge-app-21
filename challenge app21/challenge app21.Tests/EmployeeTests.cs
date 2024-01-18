namespace challenge_app21.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void whenStatisticMaxCalled_ShouldReturnCorrectMax()
            
        {
            // arrange
           var  emp1 = new Employee("Marcin", "Winner", 38);
            emp1.AddScoreAward(2);
            emp1.AddScoreAward(6);
            emp1.AddScoreAward(2);

            //act
            var statistics = emp1.GetStatistics() ;

            //assert
            Assert.AreEqual(6, statistics.Max);

        }

        [Test]
        public void whenStatisticMinCalled_ShouldReturnCorrectMin()

        {
            // arrange
            var emp1 = new Employee("Marcin", "Winner", 38);
            emp1.AddScoreAward(2);
            emp1.AddScoreAward(6);
            emp1.AddScoreAward(2);

            //act
            var statistics = emp1.GetStatistics();

            //assert
            Assert.AreEqual(2, statistics.Min);

        }

        [Test]
        public void whenStatisticAverageCalled_ShouldReturnCorrectAverage()

        {
            // arrange
            var emp1 = new Employee("Marcin", "Winner", 38);
            emp1.AddScoreAward(2);
            emp1.AddScoreAward(6);
            emp1.AddScoreAward(2);

            //act
            var statistics = emp1.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average,2));

        }
    }
  }