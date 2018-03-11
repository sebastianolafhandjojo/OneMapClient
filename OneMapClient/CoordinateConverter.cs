using System;
using System.Net.Http;
using System.Diagnostics;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OneMapClient
{
    public class CoordinateConverter : ICoordinateConverter
    {
        const string onemap = "https://developers.onemap.sg/commonapi/";

        public CoordinateConverter()
        {
        }
       
        /// <summary>
        /// Example : 
        /// https://developers.onemap.sg/commonapi/convert/4326to3857?latitude=1.319728905&longitude=103.8421581
        /// </summary>
        /// <param name="longitude"></param>
        /// <param name="latitude"></param>
        public async Task<Coordinate> Fr4326To3857Async(double longitude, double latitude)
        {
            
            Uri uri = new Uri(onemap + string.Format("convert/4326to3857?latitude={0}&longitude={1}", latitude, longitude));
            HttpClient client = new HttpClient();
            var result = await client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<Coordinate>(result);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns></returns>
        public async Task<Coordinate> Fr4326To3857Async(Coordinate coordinate)
        {
            if (coordinate == null)
                throw new NullReferenceException(nameof(coordinate));
            return await Fr4326To3857Async(coordinate.longitude, coordinate.latitude);
        }

        /// <summary>
        /// Example: 
        /// https://developers.onemap.sg/commonapi/convert/4326to3414?latitude=1.319728905&longitude=103.8421581
        /// </summary>
        /// <param name="longitude"></param>
        /// <param name="latitude"></param>
        /// /// <returns>Cooordinate</returns>
        public async Task<Coordinate> Fr4326To3414Async(double longitude, double latitude)
        {

            Uri uri = new Uri(onemap + string.Format("convert/4326to3414?latitude={0}&longitude={1}", latitude, longitude));
            HttpClient client = new HttpClient();
            var result = await client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<Coordinate>(result);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns>Cooordinate</returns>
        public async Task<Coordinate> Fr4326To3414Async(Coordinate coordinate)
        {
            if (coordinate == null)
                throw new NullReferenceException(nameof(coordinate));            
            return await Fr4326To3414Async(coordinate.longitude, coordinate.latitude);
        }

        /// <summary>
        /// Example 
        /// https://developers.onemap.sg/commonapi/convert/3414to3857?X=28983.788791079794&Y=33554.5098132845
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        ///  <returns>Coordinate</returns>
        public async Task<Coordinate> Fr3414To3857Async(double X, double Y)
        {
            Uri uri = new Uri(onemap + string.Format("convert/3414to3857?X={0}&Y={1}", X, Y));
            HttpClient client = new HttpClient();
            var result = await client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<Coordinate>(result);            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns></returns>
        ///  <returns>Coordinate</returns>
        public async Task<Coordinate> Fr3414To3857Async(Coordinate coordinate)
        {
            if (coordinate == null)
                throw new NullReferenceException(nameof(coordinate));
            return await Fr3414To3857Async(coordinate.X, coordinate.Y);
        }
        /// <summary>
        /// Example
        /// https://developers.onemap.sg/commonapi/convert/3414to4326?X=28983.788791079794&Y=33554.5098132845
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        ///  <returns>Coordinate</returns>
        public async Task<Coordinate> Fr3414To4326Async(double X, double Y)
        {
            Uri uri = new Uri(onemap + string.Format("convert/3414to4326?X={0}&Y={1}", X, Y));
            HttpClient client = new HttpClient();
            var result = await client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<Coordinate>(result);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns></returns>
        ///  <returns>Coordinate</returns>
        public async Task<Coordinate> Fr3414To4326Async(Coordinate coordinate)
        {
            if (coordinate == null)
                throw new NullReferenceException(nameof(coordinate));
            return await Fr3414To4326Async(coordinate.X, coordinate.Y);
        }


        /// <summary>
        ///  Example
        ///  https://developers.onemap.sg/commonapi/convert/3857to3414?Y=146924.54200324757&X=11559656.16256661
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns>Coordinate</returns>
        public async Task<Coordinate> Fr3857To3414Async(double X, double Y)
        {

            Uri uri = new Uri(onemap + string.Format("convert/3857to3414?Y={0}&X={1}", Y, X));
            HttpClient client = new HttpClient();
            var result = await client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<Coordinate>(result);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns></returns>
        public async Task<Coordinate> Fr3857To3414Async(Coordinate coordinate)
        {
            if (coordinate == null)
                throw new NullReferenceException(nameof(coordinate));
            return await Fr3857To3414Async(coordinate.X, coordinate.Y);
        }


        /// <summary>
        /// Example
        /// https://developers.onemap.sg/commonapi/convert/3857to4326?Y=146924.54200324757&X=11559656.16256661
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns>Coordinate</returns>
        public async Task<Coordinate> Fr3857To4326Async(double X, double Y)
        {
            Uri uri = new Uri(onemap + string.Format("convert/3857to4326?Y={0}&X={1}", Y, X));
            HttpClient client = new HttpClient();
            var result = await client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<Coordinate>(result);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns></returns>
        public async Task<Coordinate> Fr3857To4326Async(Coordinate coordinate)
        {
            if (coordinate == null)
                throw new NullReferenceException(nameof(coordinate));
            return await Fr3857To4326Async(coordinate.X, coordinate.Y);
        }

    }
}
