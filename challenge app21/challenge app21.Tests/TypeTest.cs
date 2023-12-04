

namespace challenge_app21.Tests
{

    public class TypeTest
    {

        [Test]
        public void ReferenceTypeTestForEmployee_WhencompareTwoInstances_Should_BeNotEqual()
        {

            // arrange
            var emp1 = GetEmployee("Marcin", "Winner", 38);
            var emp2 = GetEmployee("Marcin", "Lose", 33);

            //act


            //assert
            Assert.AreNotEqual(emp1, emp2);
        }

        [Test]
        public void ReferenceTypeTestForEmployee_WhencAssignOneRefTypetoSecond_ShouldBeEqual()
        {

            // arrange
            var emp1 = GetEmployee("Marcin", "Winner", 38);
            var emp2 = GetEmployee("Marcin", "Lose", 33);

            //act
            emp1 = emp2;

            //assert
            Assert.AreEqual(emp1, emp2);
        }


        private Employee GetEmployee (string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }


        [Test]
        public void ValueTypeTesrForInt_WhenCompareSameValue_ShouldBeEqual()
        {

            // arrange
            int age1 = 33;
            int age2 = 33; 

            //act


            //assert
            Assert.AreEqual(age1,age2);
        }

        [Test]
        public void ValueTypeTesrForFloat_WhenCompareSameValue_ShouldBeEqual()
        {

            // arrange
            float temp1 = 10/3;
            float temp2 = 20/6;

            //act


            //assert
            Assert.AreEqual(temp1, temp2) ;
        }

        [Test]
        public void ValueTypeTesrForString_WhenCompareSameValue_ShouldBeEqual()
        {

            // arrange
            string name1 = "Andrzej";
            string name2 = "Andrzej";
            //act


            //assert
            Assert.AreEqual(name1,name2);
        }

    }

    
}
