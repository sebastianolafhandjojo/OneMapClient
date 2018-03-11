using System.Threading.Tasks;

namespace OneMapClient
{
    public interface ICoordinateConverter
    {
        #region 4326 to 3857
        Task<Coordinate> Fr4326To3857Async(double longitude, double latitude);
        Task<Coordinate> Fr4326To3857Async(Coordinate coordinate);
        #endregion

        #region 4326 to 3414
        Task<Coordinate> Fr4326To3414Async(double longitude, double latitude);
        Task<Coordinate> Fr4326To3414Async(Coordinate coordinate);
        #endregion

        #region 3414 to 3857
        Task<Coordinate> Fr3414To3857Async(double X, double Y);
        Task<Coordinate> Fr3414To3857Async(Coordinate coordinate);
        #endregion

        #region 3414 to 4326
        Task<Coordinate> Fr3414To4326Async(double X, double Y);
        Task<Coordinate> Fr3414To4326Async(Coordinate coordinate);
        #endregion  

        #region 3857 to 3414
        Task<Coordinate> Fr3857To3414Async(double X, double Y);
        Task<Coordinate> Fr3857To3414Async(Coordinate coordinate);
        #endregion

        #region 3857 to 4326
        Task<Coordinate> Fr3857To4326Async(double X, double Y);
        Task<Coordinate> Fr3857To4326Async(Coordinate coordinate);
        #endregion
    }
}