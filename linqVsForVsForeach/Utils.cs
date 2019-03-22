using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqVsForVsForeach
{
    public static class Utils
    {
        public static List<TestObject> RetrieveSmallTestList()
        {
            List<TestObject> smallList = new List<TestObject>();
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                int randomNumber = random.Next(0, 100);
                int randomNumberStr = random.Next(0, 10);
                smallList.Add(new TestObject() { Id = randomNumber
                                                , Name = new string('a', randomNumberStr)
                                                , Email = "test@test.com" });
            }
            return smallList;
        }

        public static List<TestObject> RetrieveMediumTestList()
        {
            List<TestObject> mediumList = new List<TestObject>();
            Random random = new Random();

            for (int i = 0; i < 2000; i++)
            {
                int randomNumber = random.Next(0, 100);
                int randomNumberStr = random.Next(0, 10);
                mediumList.Add(new TestObject() { Id = randomNumber
                                                 , Name = new string('a', randomNumberStr)
                                                 , Email = "test@test.com" });
            }
            return mediumList;
        }

        public static List<TestObject> RetrieveBigTestList()
        {
            List<TestObject> bigList = new List<TestObject>();
            Random random = new Random();

            for (int i = 0; i < 20000; i++)
            {
                int randomNumber = random.Next(0, 100);
                int randomNumberStr = random.Next(0, 10);
                bigList.Add(new TestObject() { Id = randomNumber
                                              , Name = new string('a', randomNumberStr)
                                              , Email = "test@test.com" });
            }
            return bigList;
        }

        public static List<TestObject> RetrieveExtraBigTestList()
        {
            List<TestObject> bigList = new List<TestObject>();
            Random random = new Random();

            for (int i = 0; i < 20000000; i++)
            {
                int randomNumber = random.Next(0, 100);
                int randomNumberStr = random.Next(0, 10);
                bigList.Add(new TestObject() { Id = randomNumber
                                              , Name = new string('a', randomNumberStr)
                                              , Email = "test@test.com" });
            }
            return bigList;
        }
    }
}
