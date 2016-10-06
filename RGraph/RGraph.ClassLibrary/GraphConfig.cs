using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RGraph
{
    /// <summary>
    /// Custom Configuration for graph data
    /// </summary>
    public class GraphConfig
    {
        /// <summary>
        /// Array of colors for graphs
        /// </summary>
        public string[] Colors { get; set; }
        /// <summary>
        /// Constructor Config
        /// </summary>
        public GraphConfig()
        {

            this.Colors = new string[] { "Blue", "#00FF00", "Red", "Yellow", "#FF00FF", "Cyan", "Purple", "#F75D59", "Gold", "#CCFF00", "#FF6666", "#9999FF", "#99FF33", "Red", "Yellow", "#FF00FF", "Cyan", "Purple", "#F75D59", "#372101", "#FFB500", "#C2FFED", "#A079BF", "#CC0744", "#C0B9B2", "#C2FF99", "#001E09", "#00489C", "#6F0062", "#0CBD66", "#EEC3FF", "#456D75", "#B77B68", "#7A87A1", "#788D66", "#885578", "#FAD09F", "#FF8A9A", "#D157A0", "#BEC459", "#456648", "#0086ED", "#886F4C", "#34362D", "#B4A8BD", "Gold", "#CCFF00", "#FF6666", "#9999FF", "#00FF33", "#7B4F4B", "#A1C299", "#300018", "#0AA6D8", "#013349", "#00846F", "#00A6AA", "#452C2C", "#636375", "#A3C8C9", "#FF913F", "#938A81", "#575329", "#00FECF", "#B05B6F", "#8CD0FF", "#3B9700", "#04F757", "#C8A1A1", "#1E6E00", "#7900D7", "#A77500", "#6367A9", "#A05837", "#6B002C", "#772600", "#D790FF", "#9B9700", "#549E79", "#FFF69F", "#201625", "#72418F", "#BC23FF", "#99ADC0", "#3A2465", "#922329", "#5B4534", "#FDE8DC", "#404E55", "#0089A3", "#CB7E98", "#A4E804", "#324E72", "#6A3A4C" };
        }


    }
}
