using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Grade.Test
{
    [TestClass]
    public class GradeBookTests
    {

        GradeBook book1 = new GradeBook();
        GradeBook book2 = new ThrowAwayGradeBook();

        private GradeStatistics Statistics(GradeBook book)
        {
            book.AddGrade(80f);
            book.AddGrade(100);
            book.AddGrade(90);
            return book.ComputerStatistics();
        }

        [TestMethod]
        public void HighestGrade()
        {
            GradeStatistics states = Statistics(book1);
            Assert.AreEqual(100, states.HighestGrade);
        }

        [TestMethod]
        public void LowerstGrade()
        {
            GradeStatistics states = Statistics(book1);
            Assert.AreEqual(80, states.LowerstGrade);
        }

        [TestMethod]
        public void AverageGradeGradeBook()
        {
            GradeStatistics states = Statistics(book1);
            Assert.AreEqual(90, states.AverageGrade);
        }

        [TestMethod]
        public void AverageGradeThrowAwayGB()
        {
            
            GradeStatistics states = Statistics(book2);
            Assert.AreEqual(95, states.AverageGrade);
        }
    }
}
