using Intersection.Intersection.Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Intersection.Intersection.Casting;

namespace Intersection.Test
{
    
    
    /// <summary>
    ///This is a test class for CastingListTest and is intended
    ///to contain all CastingListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CastingListTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetIntersection
        ///</summary>
        public void GetIntersectionTestHelper<T>()
            where T : ICasting
        {
            CastingList<T> target = new CastingList<T>(); // TODO: Initialize to an appropriate value
            CastingList<T> other = null; // TODO: Initialize to an appropriate value
            CastingList<T> expected = null; // TODO: Initialize to an appropriate value
            CastingList<T> actual;
            actual = target.GetIntersection(other);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetIntersectionTest()
        {
            ICasting a = new CentrifugalCasting();
            ICasting b = new CeramicMouldCasting();
            ICasting c = new CoInjection();
            ICasting d = new ColdDieCasting();
            ICasting e = new ElectrochemicalMachining();

            CastingList<ICasting> list1 = new CastingList<ICasting>();
            CastingList<ICasting> list2 = new CastingList<ICasting>();

            list1.Add(a);
            list1.Add(b);
            list1.Add(c);
            
            list2.Add(c);
            

            CastingList<ICasting> list3 = list1.GetIntersection(list2);

            Assert.AreEqual(list3[0].Name, c.Name);

            CastingList<ICasting> list4 = list2.GetIntersection(list1);

            Assert.AreEqual(list4[0].Name, c.Name);



        }
    }
}
