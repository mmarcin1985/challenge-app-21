namespace challenge_app21.Tests
{
    public class Tests
    {
        [Test]
        public void whenempisAwarde_RateShouldBeIncrease()
            
        {
            // arrange
           var  emp1 = new Employee("Marcin", "Winner", 38);
            emp1.AddScoreAward(5);
            emp1.AddScoreAward(7);


            //act
            var result = emp1.Rating;

            //assert
            Assert.AreEqual(12, result);

        }

        [Test]
        public void whenempisPunish_RateShouldBeDedcreased()

        {
            // arrange
            var emp1 = new Employee("Marcin", "Winner", 38);
            emp1.AddScorePunish(7);
            emp1.AddScorePunish(5);


            //act
            var result = emp1.Rating;

            //assert
            Assert.AreEqual(-12, result);

        }

        [Test]
        public void whenempisAwardAndRewrad_sumShouldBeCorrect()

        {
            // arrange
            var emp1 = new Employee("Marcin", "Winner", 38);
            emp1.AddScoreAward(5);
            emp1.AddScoreAward(7);
            emp1.AddScorePunish(7);
            emp1.AddScorePunish(5);

            //act
            var result = emp1.Rating;

            //assert
            Assert.AreEqual(0, result);

        }

    }





  }