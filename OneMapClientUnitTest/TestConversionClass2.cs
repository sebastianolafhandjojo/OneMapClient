using System;
using OneMapClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SVY21;

namespace OneMapClientUnitTest
{

    /// <summary>
    /// This Class is to Test Conversion class provided by OneMap Vs NUS Hacker
    /// WGS84 to SVY21
    /// 
    /// </summary>
    ///     
    [TestClass]
    public class TestConversionClass2
    {
        private const double ToleranceLatLong = 0.0000000001;
        private const double ToleranceSvy21 = 0.0001;
        
        [TestMethod]
        public void Test1()
        {
            double longitude = 103.833333;
            double latitude = 1.366666;

            CoordinateConverter cc = new CoordinateConverter();
            Coordinate input = new Coordinate();
            input.longitude = longitude;
            input.latitude = latitude;
            Coordinate actualonemap = cc.Fr4326To3414Async(input).Result;

            LatLongCoordinate test = new LatLongCoordinate(latitude, longitude);
            Svy21Coordinate actualnus = Svy21.ComputeSvy21(test);

            Assert.AreEqual(actualonemap.Y, actualnus.Northing, ToleranceSvy21);
            Assert.AreEqual(actualonemap.X, actualnus.Easting, ToleranceSvy21);
        }

        [TestMethod]
        public void Test2()
        {
            double longitude = 103.856950349764668;
            double latitude = 1.3699278977737488;

            CoordinateConverter cc = new CoordinateConverter();
            Coordinate input = new Coordinate();
            input.longitude = longitude;
            input.latitude = latitude;
            Coordinate actualonemap = cc.Fr4326To3414Async(input).Result;

            LatLongCoordinate test = new LatLongCoordinate(latitude, longitude);
            Svy21Coordinate actualnus = Svy21.ComputeSvy21(test);

            Assert.AreEqual(actualonemap.Y, actualnus.Northing, ToleranceSvy21);
            Assert.AreEqual(actualonemap.X, actualnus.Easting, ToleranceSvy21);
        }

        [TestMethod]
        public void Test3()
        {
            double longitude = 103.72794378041792;
            double latitude = 1.3446255443241177;

            CoordinateConverter cc = new CoordinateConverter();
            Coordinate input = new Coordinate();
            input.longitude = longitude;
            input.latitude = latitude;
            Coordinate actualonemap = cc.Fr4326To3414Async(input).Result;

            LatLongCoordinate test = new LatLongCoordinate(latitude, longitude);
            Svy21Coordinate actualnus = Svy21.ComputeSvy21(test);

            Assert.AreEqual(actualonemap.Y, actualnus.Northing, ToleranceSvy21);
            Assert.AreEqual(actualonemap.X, actualnus.Easting, ToleranceSvy21);
        }

        [TestMethod]
        public void Test4()
        {
            double longitude = 103.83080332777138;
            double latitude = 1.4520670518379692;

            CoordinateConverter cc = new CoordinateConverter();
            Coordinate input = new Coordinate();
            input.longitude = longitude;
            input.latitude = latitude;
            Coordinate actualonemap = cc.Fr4326To3414Async(input).Result;

            LatLongCoordinate test = new LatLongCoordinate(latitude, longitude);
            Svy21Coordinate actualnus = Svy21.ComputeSvy21(test);

            Assert.AreEqual(actualonemap.Y, actualnus.Northing, ToleranceSvy21);
            Assert.AreEqual(actualonemap.X, actualnus.Easting, ToleranceSvy21);
        }
    }
}
