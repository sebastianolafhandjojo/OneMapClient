using System;
using System.Collections.Generic;
using System.Text;

namespace OneMapClient
{
    public class Coordinate
    {
        public double X;
        public double Y;

        public double latitude;
        public double longitude;

        public override string ToString()
        {
            return string.Format("X = {0}\nY = {1}\nLongitude = {2}\nLatitude = {3}\n", X, Y, longitude, latitude);
        }

    }
}
