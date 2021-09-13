using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListProcessingConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProcessingConsoleApp.Tests
{

    [TestClass()]
    public class HomeworkFunctionsTests
    {
        List<Person> people = new List<Person>
        {
            new Person
            {
                Name = "John",
                Age = 32,
                IsTheBest = true
            },
            new Person
            {
                Name = "George",
                Age = 29,
                IsTheBest = false
            },
            new Person
            {
                Name = "Rach",
                Age = 29,
                IsTheBest = true
            },
            new Person
            {
                Name = "Chris",
                Age = 30,
                IsTheBest = false
            },
            new Person
            {
                Name = "Andy",
                Age = 61,
                IsTheBest = false
            },
            new Person
            {
                Name = "Frances",
                Age = 60,
                IsTheBest = false
            },
        };

        List<string> teds = new List<string> { "Ted", "Ted", "Ted", "Ted", "Ted", "Ted" };

        List<int> list1 = new List<int> { 1, 3, 5, 2, 3, 4, 6 }; //aggregate i+j = 24
        List<int> evenOnlyList1 = new List<int> { 2, 4, 6 };

        List<int> listNoEvens = new List<int> { 1, 3, 5, 7, 3, 5, 11 };

        List<int> listAllEvens = new List<int> { 2, 4, 2, 14, 26, 54, 8, 10 };


        [TestMethod()]
        public void FindFirstEvenTest()
        {
            Assert.AreEqual(2, HomeworkFunctions.FindFirstEven(list1));
            Assert.AreEqual(0, HomeworkFunctions.FindFirstEven(listNoEvens));
        }

        [TestMethod()]
        public void AreAllEvenTest()
        {
            Assert.AreEqual(false, HomeworkFunctions.AreAllEven(list1));
            Assert.AreEqual(false, HomeworkFunctions.AreAllEven(listNoEvens));
            Assert.AreEqual(true, HomeworkFunctions.AreAllEven(listAllEvens));
        }

        [TestMethod()]
        public void NumberOfEvenTest()
        {
            Assert.AreEqual(3, HomeworkFunctions.NumberOfEven(list1));
            Assert.AreEqual(0, HomeworkFunctions.NumberOfEven(listNoEvens));
            Assert.AreEqual(listAllEvens.Count, HomeworkFunctions.NumberOfEven(listAllEvens));
        }

        [TestMethod()]
        public void MultiplyListOfIntsTest()
        {
            Assert.AreEqual(48, HomeworkFunctions.MultiplyListOfInts(list1).Aggregate((i, j) => i + j));
            Assert.AreEqual(48, HomeworkFunctions.MultiplyListOfInts(list1, 2).Aggregate((i, j) => i + j));
            Assert.AreEqual(240, HomeworkFunctions.MultiplyListOfInts(list1, 10).Aggregate((i, j) => i + j));
        }

        [TestMethod()]
        public void FunctionalMultiplyListOfIntsTest()
        {
            Assert.AreEqual(48, HomeworkFunctions.FunctionalMultiplyListOfInts(list1).Aggregate((i, j) => i + j));
            Assert.AreEqual(48, HomeworkFunctions.FunctionalMultiplyListOfInts(list1, 2).Aggregate((i, j) => i + j));
            Assert.AreEqual(240, HomeworkFunctions.FunctionalMultiplyListOfInts(list1, 10).Aggregate((i, j) => i + j));
        }

        [TestMethod()]
        public void SetSameAgeTest()
        {
            List<Person> testPeopleAge20 = HomeworkFunctions.SetSameAge(people, 20);
            for (int i = 0; i < people.Count; i++)
            {
                Assert.AreEqual(20, testPeopleAge20[i].Age);
            }
        }

        [TestMethod()]
        public void FunctionalSetSameAgeTest()
        {
            List<Person> testPeopleAge20 = HomeworkFunctions.FunctionalSetSameAge(people, 20);
            for (int i = 0; i < people.Count; i++)
            {
                Assert.AreEqual(20, testPeopleAge20[i].Age);
            }
        }

        [TestMethod()]
        public void InitializePeopleFromStringsTest()
        {
            List<Person> actualPeople = HomeworkFunctions.InitializePeopleFromStrings(teds);

            for (int i = 0; i < actualPeople.Count(); i++)
            {
                Assert.AreEqual("Ted", actualPeople[i].Name);
            }
        }

        [TestMethod()]
        public void FunctionalInitializePeopleFromStringsTest()
        {

            List<Person> actualPeople = HomeworkFunctions.FunctionalInitializePeopleFromStrings(teds);

            for (int i = 0; i < actualPeople.Count(); i++)
            {
                Assert.AreEqual("Ted", actualPeople[i].Name);
            }
        }

        [TestMethod()]
        public void ReturnEvenOnlyTest()
        {
            Assert.AreEqual(evenOnlyList1.Count(), HomeworkFunctions.ReturnEvenOnly(list1).Count());
            Assert.AreEqual(evenOnlyList1.Aggregate((i, j) => i + j), HomeworkFunctions.ReturnEvenOnly(list1).Aggregate((i, j) => i + j));
        }

        [TestMethod()]
        public void FunctionalReturnEvenOnlyTest()
        {
            Assert.AreEqual(evenOnlyList1.Count(), HomeworkFunctions.FunctionalReturnEvenOnly(list1).Count());
            Assert.AreEqual(evenOnlyList1.Aggregate((i, j) => i + j), HomeworkFunctions.FunctionalReturnEvenOnly(list1).Aggregate((i, j) => i + j));
        }

        [TestMethod()]
        public void RemoveAllTrueTest()
        {
            Assert.AreEqual(4, HomeworkFunctions.RemoveAllTrue(people).Count());
        }

        [TestMethod()]
        public void FunctionalRemoveAllTrueTest()
        {
            Assert.AreEqual(4, HomeworkFunctions.RemoveAllTrue(people).Count());
        }

        [TestMethod()]
        public void PlusThreeDivisibleByFiveTest()
        {
            Assert.AreEqual(1, HomeworkFunctions.PlusThreeDivisibleByFive(list1).Count());
            Assert.AreEqual(5, HomeworkFunctions.PlusThreeDivisibleByFive(list1)[0]);
        }

        [TestMethod()]
        public void OriginalPlusThreeDivisibleByFiveTest()
        {
            Assert.AreEqual(1, HomeworkFunctions.OriginalPlusThreeDivisibleByFive(list1).Count());
            Assert.AreEqual(2, HomeworkFunctions.OriginalPlusThreeDivisibleByFive(list1)[0]);
        }
    }
}