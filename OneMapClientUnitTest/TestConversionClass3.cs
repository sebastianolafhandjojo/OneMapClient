using System;
using OneMapClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OneMapClientUnitTest
{
    [TestClass]
    public class TestConversionClass3
    {
        private const double ToleranceLatLong = 0.0000000001;
        private const double ToleranceSvy21 = 0.001;

        /// <summary>
        /// WGS84 TO SVY21
        /// using OneMap Api
        /// using coordinate given by NUS HACKERS
        /// </summary>
        [TestMethod]
        public void OneMapVsNusHackers4326to3414Test1()
        {
            CoordinateConverter cc = new CoordinateConverter();
            Coordinate input = new Coordinate();
            input.longitude = 103.833333;
            input.latitude = 1.366666;
            Coordinate actual = cc.Fr4326To3414Async(input).Result;


            Coordinate expected = new Coordinate();
            expected.X = 28001.642;
            expected.Y = 38744.572 ;

            Assert.AreEqual(expected.X, actual.X, ToleranceSvy21);
            Assert.AreEqual(expected.Y, actual.Y, ToleranceSvy21);

        }
        [TestMethod]
        public void OneMapVsNusHackers4326to3414Test2()
        {
            CoordinateConverter cc = new CoordinateConverter();
            Coordinate input = new Coordinate();
            input.longitude = 103.856950349764668;
            input.latitude = 1.3699278977737488;
            Coordinate actual = cc.Fr4326To3414Async(input).Result;

            Coordinate expected = new Coordinate();
            expected.X = 30629.967;
            expected.Y = 39105.269;

            Assert.AreEqual(expected.latitude, actual.latitude, ToleranceSvy21);
            Assert.AreEqual(expected.longitude, actual.longitude, ToleranceSvy21);

        }
        [TestMethod]
        public void OneMapVsNusHackers4326to3414Test3()
        {
            CoordinateConverter cc = new CoordinateConverter();
            Coordinate input = new Coordinate();
            input.longitude = 103.72794378041792;
            input.latitude = 1.3446255443241177;
            Coordinate actual = cc.Fr4326To3414Async(input).Result;

            Coordinate expected = new Coordinate();
            expected.X = 16272.970;
            expected.Y = 36307.704;

            Assert.AreEqual(expected.X, actual.X, ToleranceSvy21);
            Assert.AreEqual(expected.Y, actual.Y, ToleranceSvy21);
        }
        [TestMethod]
        public void OneMapVsNusHackers4326to3414Test4()
        {

            CoordinateConverter cc = new CoordinateConverter();
            Coordinate input = new Coordinate();
            input.longitude = 103.83080332777138;
            input.latitude = 1.4520670518379692;
            Coordinate actual = cc.Fr4326To3414Async(input).Result;

            Coordinate expected = new Coordinate();
            expected.X = 27720.130;
            expected.Y = 48187.789;

            Assert.AreEqual(expected.X, actual.X, ToleranceSvy21);
            Assert.AreEqual(expected.Y, actual.Y, ToleranceSvy21);

        }
    }
}
