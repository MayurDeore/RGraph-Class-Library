using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGraph
{
    /// <summary>
    /// Graph Interface
    /// </summary>
    interface IGraph
    {
        /// <summary>
        /// Gets data for Chart.
        /// </summary>
        /// <param name="ds">Dataset</param>
        /// <returns>Chart Object with data</returns>
        Chart getGraphData(DataSet ds);
    }
}
