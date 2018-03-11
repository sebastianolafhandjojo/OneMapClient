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
    public class TestConversionClass2A
    {
        private const double ToleranceLatLong = 0.0000000001;
        private const double ToleranceSvy21 = 0.0001;

        [TestMethod]
        public void Test1()
        {
            double easting = 28001.642 ;
            double northing = 38744.572;

            CoordinateConverter cc = new CoordinateConverter();
            Coordinate input = new Coordinate();
            input.X = easting;
            input.Y = northing;
            Coordinate actualonemap = cc.Fr3414To4326Async(input).Result;

            Svy21Coordinate test = new Svy21Coordinate(northing, easting);
            LatLongCoordinate actualnus = Svy21.ComputeLatitudeLongitude(test);

            Assert.AreEqual(actualonemap.longitude, actualnus.Longitude, ToleranceLatLong);
            Assert.AreEqual(actualonemap.latitude, actualnus.Latitude, ToleranceLatLong);
        }

        [TestMethod]
        public void Test2()
        {
            double easting = 30629.967;
            double northing = 39105.269;

            CoordinateConverter cc = new CoordinateConverter();
            Coordinate input = new Coordinate();
            input.X = easting;
            input.Y = northing;
            Coordinate actualonemap = cc.Fr3414To4326Async(input).Result;

            Svy21Coordinate test = new Svy21Coordinate(northing, easting);
            LatLongCoordinate actualnus = Svy21.ComputeLatitudeLongitude(test);

            Assert.AreEqual(actualonemap.longitude, actualnus.Longitude, ToleranceLatLong);
            Assert.AreEqual(actualonemap.latitude, actualnus.Latitude, ToleranceLatLong);
        }

        [TestMethod]
        public void Test3()
        {           
            double easting = 16272.970;
            double northing = 36307.704;

            CoordinateConverter cc = new CoordinateConverter();
            Coordinate input = new Coordinate();
            input.X = easting;
            input.Y = northing;
            Coordinate actualonemap = cc.Fr3414To4326Async(input).Result;

            Svy21Coordinate test = new Svy21Coordinate(northing, easting);
            LatLongCoordinate actualnus = Svy21.ComputeLatitudeLongitude(test);

            Assert.AreEqual(actualonemap.longitude, actualnus.Longitude, ToleranceLatLong);
            Assert.AreEqual(actualonemap.latitude, actualnus.Latitude, ToleranceLatLong);
        }

        [TestMethod]
        public void Test4()
        {
            double easting = 27720.130;
            double northing = 48187.789;            
            CoordinateConverter cc = new CoordinateConverter();
            Coordinate input = new Coordinate();
            input.X = easting;
            input.Y = northing;
            Coordinate actualonemap = cc.Fr3414To4326Async(input).Result;

            Svy21Coordinate test = new Svy21Coordinate(northing, easting);
            LatLongCoordinate actualnus = Svy21.ComputeLatitudeLongitude(test);

            Assert.AreEqual(actualonemap.longitude, actualnus.Longitude, ToleranceLatLong);
            Assert.AreEqual(actualonemap.latitude, actualnus.Latitude, ToleranceLatLong);
        }
    }
}
