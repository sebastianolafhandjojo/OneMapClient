using System;
using OneMapClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OneMapClientUnitTest
{
    [TestClass]
    public class TestConversionClass4
    {
        private const double ToleranceLatLong = 0.0000000001;
        private const double ToleranceSvy21 = 0.001;

        /// <summary>
        /// SVY21 to LONGLAT
        /// using OneMap API
        /// using coordinate given by NUS HACKERS
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            CoordinateConverter cc = new CoordinateConverter();

            Coordinate expected = new Coordinate();
            expected.longitude =  103.833333;
            expected.latitude = 1.366666;
            Coordinate input = new Coordinate();
            input.X = 28001.642;
            input.Y = 38744.572;
            Coordinate actual = cc.Fr3414To4326Async(input).Result;
            Assert.AreEqual(expected.longitude, actual.longitude, ToleranceLatLong);
            Assert.AreEqual(expected.latitude, actual.latitude, ToleranceLatLong);

        }
        [TestMethod]
        public void Test2()
        {
            CoordinateConverter cc = new CoordinateConverter();
            Coordinate expected = new Coordinate();
            expected.longitude = 103.856950349764668;
            expected.latitude = 1.3699278977737488;
            Coordinate input = new Coordinate();
            input.X = 30629.967;
            input.Y = 39105.269;
            Coordinate actual = cc.Fr3414To4326Async(input).Result;
            Assert.AreEqual(expected.latitude, actual.latitude, ToleranceLatLong);
            Assert.AreEqual(expected.longitude, actual.longitude, ToleranceLatLong);

        }
        [TestMethod]
        public void Test3()
        {
            CoordinateConverter cc = new CoordinateConverter();
            Coordinate expected = new Coordinate();
            expected.longitude = 103.72794378041792;
            expected.latitude = 1.3446255443241177;
            Coordinate input = new Coordinate();
            input.X = 16272.970;
            input.Y = 36307.704;
            Coordinate actual = cc.Fr3414To4326Async(input).Result;        
            Assert.AreEqual(expected.latitude, actual.latitude, ToleranceLatLong);
            Assert.AreEqual(expected.longitude, actual.longitude, ToleranceLatLong);
        }
        [TestMethod]
        public void Test4()
        {
            CoordinateConverter cc = new CoordinateConverter();
            Coordinate expected = new Coordinate();
            expected.longitude = 103.83080332777138;
            expected.latitude = 1.4520670518379692;
            Coordinate input = new Coordinate();
            input.X = 27720.130;
            input.Y = 48187.789;
            Coordinate actual = cc.Fr3414To4326Async(input).Result;        
            Assert.AreEqual(expected.latitude, actual.latitude, ToleranceLatLong);
            Assert.AreEqual(expected.longitude, actual.longitude, ToleranceLatLong);

        }
    }
}
