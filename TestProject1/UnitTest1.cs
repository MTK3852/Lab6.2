using Lab5.Models;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Lecture lecture=new Lecture("Department of Defense","DOD","DD-21","15.06.20",75);
            int wordsCount = lecture.AmountOfWordsInDepartmentName(lecture);
            Assert.AreEqual(3,wordsCount);
        }
    }
}