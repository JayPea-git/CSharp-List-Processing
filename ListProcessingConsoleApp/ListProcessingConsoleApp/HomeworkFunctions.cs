using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProcessingConsoleApp
{
    public static class HomeworkFunctions
    {
        //Find the first element that matches a condition
        public static int FindFirstEven(List<int> list)
        {
            return list
                .Find(i => i % 2 == 0);
        }

        //Do all match a condition?
        public static bool AreAllEven(List<int> list)
        {
            return list
                .All(i => i % 2 == 0);
        }

        //Count how many match a condition
        public static int NumberOfEven(List<int> list)
        {
            return list
                .Where(i => i % 2 == 0)
                .Count();
        }

        //Given a list of integers, make a list of integers where each integer is doubled.
        //for loop
        public static List<int> MultiplyListOfInts(List<int> list, int factor = 2)
        {
            List<int> outputList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                outputList.Add(list[i] * factor);
            }
            return outputList;
        }
        //select/map
        public static List<int> FunctionalMultiplyListOfInts(List<int> list, int factor = 2)
        {
            return list
                .Select(i => i * factor)
                .ToList();
        }

        //Given a list of Objects make a list where a property is set to the same value on each.
        //for loop
        public static List<Person> SetSameAge(List<Person> list, int age)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Age = age;
            }
            return list;
        }
        //select/map
        public static List<Person> FunctionalSetSameAge(List<Person> list, int age)
        {
            return (List<Person>)list.Select(p => p.Age = age);
        }

        //Given a list of strings, make a list of objects that are initialised with that string.
        //for loop
        public static List<Person> InitializePeopleFromStrings(List<string> strings)
        {
            List<Person> outputList = new List<Person>();
            foreach (string s in strings)
            {
                outputList.Add(new Person { Name = s });
            }
            return outputList;
        }
        //select/map
        public static List<Person> FunctionalInitializePeopleFromStrings(List<string> strings)
        {
            return (List<Person>)strings.Select(s => new Person { Name = s });
        }

        //Given a list of integers, make a list that is the same but only includes the even integers.
        //for loop
        public static List<int> ReturnEvenOnly(List<int> list)
        {
            List<int> returnList = new List<int>();
            foreach (int i in list)
            {
                if (i % 2 == 0)
                {
                    returnList.Add(i);
                }
            }
            return returnList;
        }
        //where/filter
        public static List<int> FunctionalReturnEvenOnly(List<int> list)
        {
            return list.Where(i => i % 2 == 0).ToList();
        }

        //Given a list of objects, strip out any where a property is true
        //for loop
        public static List<Person> RemoveAllTrue(List<Person> list)
        {
            List<Person> outputList = new List<Person>();
            foreach (Person p in list)
            {
                if (!p.IsTheBest)
                {
                    outputList.Add(p);
                }
            }
            return outputList;
        }
        //where/filter
        public static List<Person> FunctionalRemoveAllTrue(List<Person> list)
        {
            return list.Where(p => !p.IsTheBest).ToList();
        }

        //Add three to each number, now return all that were divisible by 5.
        public static List<int> PlusThreeDivisibleByFive(List<int> list)
        {
            return list
                .Select(i => i + 3)
                .Where(i => i % 5 == 0)
                .ToList();
        }
        //Now do the same but returning the original numbers.
        public static List<int> OriginalPlusThreeDivisibleByFive(List<int> list)
        {
            return list
                .Select(i => i + 3)
                .Where(i => i % 5 == 0)
                .Select(i => i - 3)
                .ToList();
        }

        //Given a list of objects, strip out any where 5 things are true
        //for loop
        //where/filter

    }
}
