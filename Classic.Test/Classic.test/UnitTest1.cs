using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Classic;

namespace Classic.test
{
    [TestClass]
    public class UnitTest1
    {
        static Anacon AnaconClass = null;

        [ClassInitialize]
        static public void Init(TestContext tc)
        {
            AnaconClass = new Anacon();
        }

        
        [TestMethod]
        public void PopularMonths_Await3ItemsWithSortByDate()
        {
            List<DateTime> dates = new List<DateTime>() {
                new DateTime(2020, 12, 17),
                new DateTime(2020, 12, 15),
                new DateTime(2020, 11, 17),
                new DateTime(2020, 10, 1) };

            dates = AnaconClass.PopularMonths(dates);


            Assert.AreEqual(dates.Count, 3);


            Assert.AreEqual(dates[0], new DateTime(2020, 12, 1));
        }
    }
}
