using Grade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Types
{
    [TestClass]
    public class TypeTests
    {
        
        [TestMethod]
        [DataRow(90, 90, 90, "A")]
        [DataRow(80, 80, 80, "B")]
        [DataRow(70, 70, 70, "C")]
        [DataRow(60, 60, 60, "D")]
        [DataRow(50, 50, 50, "F")] 
        public void TestLetter(int a, int b, int c, string d)
        {
            GradeBook book1 = new GradeBook();

            book1.AddGrade(a);
            book1.AddGrade(b);
            book1.AddGrade(c);

            GradeStatistics stats = book1.ComputerStatistics();
            Assert.AreEqual(stats.LetterGrade, d);
        }

        [TestMethod]
        [DataRow(90, 90, 90, "Excellent")]
        [DataRow(80, 80, 80, "Good")]
        [DataRow(70, 70, 70, "Average")]
        [DataRow(60, 60, 60, "Bellow Average")]
        [DataRow(50, 50, 50, "Failing")]
        public void TestDescription(int a, int b, int c, string d)
        {
            GradeBook book1 = new GradeBook();

            book1.AddGrade(a);
            book1.AddGrade(b);
            book1.AddGrade(c);

            GradeStatistics stats = book1.ComputerStatistics();
            Assert.AreEqual(stats.Descrition, d);
        }

        [TestMethod]
        public void UsingArrays()
        {
            float[] grades = new float[3];

            AddGrade(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrade(float[] grades)
        {
            // grades = new float[5];
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2018, 08, 19);
            date.AddDays(1); // Não altera date, cria uma nova instância.
            date = date.AddDays(1);

            Assert.AreEqual(20, date.Day);
        }

        [TestMethod]
        public void UpperCaseString()
        {
            string name = "pedro";
            name = name.ToUpper();

            Assert.AreEqual("PEDRO", name);
        }

        [TestMethod]
        public void ValueTypesPassByValueRef()
        {
            int x1 = 46;
            IncrementNumber(ref x1);

            Assert.AreEqual(x1, 47);

        }

        private void IncrementNumber(ref int number)
        {
            ++number;
        }

        //[TestMethod]
        //public void ReferenceTypesPassByValue()
        //{
        //    GradeBook book1 = new GradeBook();
        //    GradeBook book2 = book1;

        //    GiveABookName(book2);

        //    Assert.AreEqual(book1.Name, "Pedro's grade book".ToUpper());
        //}

        private void GiveABookName(GradeBook book)
        {
            // book = new GradeBook();
            book.Name = "Pedro's grade book";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name = "Pedro";
            string name2 = "pedro";

            Assert.IsTrue(name.Equals(name2, StringComparison.CurrentCultureIgnoreCase));
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;

            Assert.AreNotEqual(x1, x2);
        }

        //[TestMethod]
        //public void GradeBookVariablesHoldAReference()
        //{
        //    GradeBook g1 = new GradeBook();
        //    GradeBook g2 = g1;

        //    // g1 = new GradeBook();
        //    g1.Name = "Pedro's grade book";

        //    Assert.AreEqual(g1.Name, g2.Name);
        //}

    }
}
