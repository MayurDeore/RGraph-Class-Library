using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGraph.ClassLibrary
{
    /// <summary>
    /// Graph Interface
    /// </summary>
    public interface IGraph
    {
        /// <summary>
        /// Gets data for Chart.
        /// </summary>
        /// <param name="ds">Dataset</param>
        /// <returns>List of strings 

        ///  </returns>
        List<string> getGraphData(DataSet ds);
    }
}
