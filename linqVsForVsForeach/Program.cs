using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqVsForVsForeach
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<TestObject> smallTestObjectList = Utils.RetrieveSmallTestList();
            List<TestObject> mediumTestObjectList = Utils.RetrieveMediumTestList();
            List<TestObject> bigTestObjectList = Utils.RetrieveBigTestList();
            List<TestObject> extraBigTestObjectList = Utils.RetrieveExtraBigTestList();


            Console.WriteLine("Small data test");
            TestLoopPerformance(smallTestObjectList);

            Console.WriteLine("---------------------------");
            Console.WriteLine("Medium data test");
            TestLoopPerformance(mediumTestObjectList);

            Console.WriteLine("---------------------------");
            Console.WriteLine("Big data test");
            TestLoopPerformance(bigTestObjectList);

            Console.WriteLine("---------------------------");
            Console.WriteLine("Extra big data test");
            TestLoopPerformance(extraBigTestObjectList);

            Console.ReadLine();
        }

        private static void TestLoopPerformance(List<TestObject> testList)
        {
            //For
            Console.Write("For loop: ");
            var watch = Stopwatch.StartNew();
            ForLoop(testList);
            watch.Stop();
            Console.WriteLine(" " + watch.ElapsedMilliseconds + " Miliseconds");

            //Foreach
            Console.Write("Foreach loop: ");
            watch = Stopwatch.StartNew();
            ForeachLoop(testList);
            watch.Stop();
            Console.WriteLine(" "+watch.ElapsedMilliseconds+ " Miliseconds");

            //Linq
            Console.Write("Linq statement: ");
            watch = Stopwatch.StartNew();
            LinqStatements(testList);
            watch.Stop();
            Console.WriteLine(" " + watch.ElapsedMilliseconds + " Miliseconds");
        }


        private static void ForLoop(List<TestObject> testList)
        {
            List<TestObject> processedTestObjects = new List<TestObject>();
            for (int index = 0; index < testList.Count; index++)
            {
                if (testList[index].Id > 50 && testList[index].Name.Length <= 5)
                {
                    processedTestObjects.Add(testList[index]);
                }
            }
        }

        private static void ForeachLoop(List<TestObject> testList)
        {
            List<TestObject> processedTestObjects = new List<TestObject>();
            foreach (var item in testList)
            {
                if (item.Id > 50 && item.Name.Length <= 5)
                {
                    processedTestObjects.Add(item);
                }
            }
        }

        private static void LinqStatements(List<TestObject> testList)
        {
            IEnumerable<TestObject> processedTestObjects = (from item in testList
                                                        where item.Id > 50
                                                        && item.Name.Length <= 5
                                                        select item);
        }
    }
}
