using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathEditor
{
    /// <summary>
    /// This class enables users to adapt coordinates according to map scale 
    /// and reverse coordinates to get real game coordinates
    /// </summary>
    public class CoordinateAdaptor
    {
        /// <summary>
        /// Adapts real game coordinates to get coordinates on Map picturebox according to map scale
        /// </summary>
        /// <param name="x">X coordinate, out parameter that will store result of adapting</param>
        /// <param name="y">Y coordinate, out parameter that will store result of adapting</param>
        /// <param name="masScale">Map scale according to which coordinates will be adapted</param>
        public void AdaptCoordinates(ref int x, ref int y, int mapScale)
        {
            x = x / mapScale;
            y = y / mapScale;
        }

        /// <summary>
        /// Revers adapted coordinates to get real game coordinates using map scale
        /// </summary>
        /// <param name="x">X coordinate, out parameter that will store result of reversing</param>
        /// <param name="y">Y coordinate, out parameter that will store result of reversing</param>
        /// <param name="mapScale">Map scale</param>
        public void ReverseCoordinates(ref int x, ref int y, int mapScale)
        {
            x = x * mapScale;
            y = y * mapScale;
        }
    }
}
