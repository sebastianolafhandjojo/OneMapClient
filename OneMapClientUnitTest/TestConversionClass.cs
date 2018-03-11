using System;
using OneMapClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OneMapClientUnitTest
{
    /// <summary>
    /// This Class is to Test Conversion class provided by OneMap Vs manual entry
    /// </summary>
    [TestClass]
    public class TestConversionClass
    {
        #region Fields
        private const double ToleranceLatLong = 0.0000000001;
        private const double ToleranceSvy21 = 0.0001;
        #endregion
        #region Test Conversion From 4326 
        [TestMethod]
        public void TestConvert4326to3857Async()
        {
            /*
             * https://developers.onemap.sg/commonapi/convert/4326to3857?latitude=1.319728905&longitude=103.8421581

            Example Response:{
               "Y":146924.54200324757,
               "X":11559656.16256661
            }*/
            CoordinateConverter cc = new CoordinateConverter();
            Coordinate input = new Coordinate();
            input.longitude = 103.8421581;
            input.latitude = 1.319728905;
            Coordinate actual = cc.Fr4326To3857Async(input).Result;
            //https://developers.onemap.sg/commonapi/convert/4326to3857?latitude=1.319728905&longitude=103.8421581

            Coordinate expected = new Coordinate();
            expected.X = 11559656.16256661;
            expected.Y = 146924.54200324757;

            Assert.AreEqual(expected.X, actual.X, ToleranceSvy21);
            Assert.AreEqual(expected.Y, actual.Y, ToleranceSvy21);
        }
        [TestMethod]
        public void TestConvert4326to3414Async()
        {
            /*
             * https://developers.onemap.sg/commonapi/convert/4326to3414?latitude=1.319728905&longitude=103.8421581

            Example Response:{
               "X":28983.788791079794,
               "Y":33554.5098132845
            }
            */

            CoordinateConverter cc = new CoordinateConverter();
            Coordinate input = new Coordinate();
            input.longitude = 103.8421581;
            input.latitude = 1.319728905;
            Coordinate actual = cc.Fr4326To3414Async(input).Result;

            Coordinate expected = new Coordinate();
            expected.X = 28983.788791079794;
            expected.Y = 33554.5098132845;
            
            Assert.AreEqual(expected.X, actual.X, ToleranceSvy21);
            Assert.AreEqual(expected.Y, actual.Y, ToleranceSvy21);
        }
        #endregion

        #region Test Conversion From 3414 
        [TestMethod]
        public void TestConvert3414to3857Async()
        {
            /*
             https://developers.onemap.sg/commonapi/convert/3414to3857?X=28983.788791079794&Y=33554.5098132845            
            Example Response:{
               "Y":146924.61623592745,
               "X":11559655.939078204
            }*/

            CoordinateConverter cc = new CoordinateConverter();
            Coordinate input = new Coordinate();
            input.X = 28983.788791079794;
            input.Y = 33554.5098132845;
            Coordinate actual = cc.Fr3414To3857Async(input).Result;

            Coordinate expected = new Coordinate();
            expected.X = 11559655.939078204;
            expected.Y = 146924.61623592745;


            Assert.AreEqual(expected.X, actual.X, ToleranceSvy21);
            Assert.AreEqual(expected.Y, actual.Y, ToleranceSvy21);
        }
        [TestMethod]
        public void TestConvert3414to4326Async()
        {
            
            /* https://developers.onemap.sg/commonapi/convert/3414to4326?X=28983.788791079794&Y=33554.5098132845

            Example Response:{
               "latitude":1.319729571666614,
               "longitude":103.84215609236949
            }*/

            CoordinateConverter cc = new CoordinateConverter();
            Coordinate input = new Coordinate();
            input.X = 28983.788791079794;
            input.Y = 33554.5098132845;
            Coordinate actual = cc.Fr3414To4326Async(input).Result;

            Coordinate expected = new Coordinate();
            expected.latitude = 1.319729571666614;
            expected.longitude = 103.84215609236949;

            Assert.AreEqual(expected.latitude, actual.latitude, ToleranceLatLong);
            Assert.AreEqual(expected.longitude, actual.longitude, ToleranceLatLong);
        }
        #endregion

        #region Test Conversion From 3857
        [TestMethod]
        public void TestConvert3857to3414Async()
        {
            /*
             https://developers.onemap.sg/commonapi/convert/3857to3414?Y=146924.54200324757&X=11559656.16256661

            Example Response:{
                "X":28983.788791079794,
                "Y":33554.50981328348            
            }
            */
            CoordinateConverter cc = new CoordinateConverter();
            Coordinate input = new Coordinate();
            input.Y = 146924.54200324757;
            input.X = 11559656.16256661;
            Coordinate actual = cc.Fr3857To3414Async(input).Result;

            Coordinate expected = new Coordinate();
            expected.X = 28983.788791079794;
            expected.Y = 33554.50981328348;
            
            Assert.AreEqual(expected.X, actual.X, ToleranceSvy21);
            Assert.AreEqual(expected.Y, actual.Y, ToleranceSvy21);
        }
        [TestMethod]
        public void TestConvert3857to4326Async()
        {
            /*
             https://developers.onemap.sg/commonapi/convert/3857to4326?Y=146924.54200324757&X=11559656.16256661

            Example Response:{
                "latitude":1.319728904999991,
                "longitude":103.8421581
            }
            */
            CoordinateConverter cc = new CoordinateConverter();
            Coordinate input = new Coordinate();
            input.Y = 146924.54200324757;
            input.X = 11559656.16256661;
            Coordinate actual = cc.Fr3857To4326Async(input).Result;

            Coordinate expected = new Coordinate();
            expected.latitude= 1.319728904999991;
            expected.longitude = 103.8421581;

            //X = 28983.7887910798, Y = 33554.5098132845 
            Assert.AreEqual(expected.longitude, actual.longitude, ToleranceLatLong);
            Assert.AreEqual(expected.longitude, actual.longitude, ToleranceLatLong);
        }
        #endregion
    }
}
