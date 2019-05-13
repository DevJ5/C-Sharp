using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass] // Press Ctrl + . to open lightbulb for adding a reference.
    public class TypeTests
    {
        [TestMethod]
        public void UppercaseString()
        {
            string name = "scott";
            name.ToUpper();

            Assert.AreNotEqual("SCOTT", name); // String are reference types, but they are immutable, so they behave like a value type.
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
            date.AddDays(1); // This needs to be assigned to a variable for it to work.
            Assert.AreNotEqual(2, date.Day);

            date = date.AddDays(1); // Like so.
            Assert.AreEqual(2, date.Day);
        }
        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);
            Assert.AreNotEqual(47, x);
        }

        private void IncrementNumber(int number)
        {
            number++;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A gradebook", book1.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A gradebook";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Scott"; // Press f12 when cursor is on string keyword and it will show you the class.
            string name2 = "scott";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod] // testm + double tab for snippet.
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Scott's grade book";
            Assert.AreEqual(g1.Name, g2.Name);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;

            Assert.AreNotEqual(x1, x2);
        }
    }
}
