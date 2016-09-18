using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGraph.ClassLibrary.Pie
{
    public class PieChart :IGraph
    {
        private GraphConfig _config;
        /// <summary>
        /// Constructor Pie Chart
        /// </summary>
        public PieChart()
        {
            this._config = new GraphConfig();
        }
        /// <summary>
        /// Constructor Sets custom Config to be used while generating Graph Data.
        /// e.g Custom Colors string Array can passed 
        /// </summary>
        /// <param name="conf">Config object with custom configuration.</param>
        public PieChart(GraphConfig conf)
        {
            this._config = conf;
        }

        /// <summary>
        /// Gets data for Pie Chart.
        /// e.g Data Returned is
        /// [[10,20,30],['PHP','JAVA','CSharp'],['Red','Blue','Black']]
        /// </summary>
        /// <param name="ds">Dataset having two columns. First contain label(string) and second contain value(int)</param>
        /// <returns>List of strings 
        ///            [0]=>chartData
        ///            [1]=>labelData and 
        ///            [2]=>colorData
        ///  </returns>
        public List<string> getGraphData(DataSet ds)
        {

            var PieString = new List<string>();
            //chartData:-  double values
            //labelData:-  string Label Values
            //colorData:-  string Color values

            var chartData = initializeStringBuilder();
            var labelData = initializeStringBuilder();
            var colorData = initializeStringBuilder();

            var i = 0;
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow drow in ds.Tables[0].Rows)
                {
                    //drow[0]:- Label Name 
                    //drow[1]:- Double Value

                    try
                    {
                        chartData = appendStringBuilderString<double>(chartData, Convert.ToDouble(drow[1].ToString()));
                    }
                    catch (Exception)
                    {
                        chartData = appendStringBuilderString<double>(chartData, 0.00);

                    }
                    labelData = appendStringBuilderString<string>(labelData, drow[0].ToString());
                    if (i==(this._config.Colors.Length))
                    {
                        i = 0;
                    }
                    colorData = appendStringBuilderString<string>(colorData, this._config.Colors[i++]);
                }


                PieString.Add(finalizeStringBuilder(chartData));
                PieString.Add(finalizeStringBuilder(labelData));
                PieString.Add(finalizeStringBuilder(colorData));
            }



            return PieString;
        }
        /// <summary>
        /// Returns StringBuilder initialized with "[" 
        /// </summary>
        /// <returns>StringBuilder appended with "["</returns>
        private StringBuilder initializeStringBuilder()
        {
            var initialString = new StringBuilder();
            return initialString.Append("[");
        }
        /// <summary>
        /// Returns finalized StringBuilder by appending "]" for JSON data
        /// </summary>
        /// <param name="_string">Finalized JSON string</param>
        /// <returns>Finalized JSON String</returns>
        private string finalizeStringBuilder(StringBuilder _string)
        {
            if (!string.IsNullOrEmpty(_string.ToString()))
            {
                _string = _string.Remove(_string.Length - 1, 1);
                _string.Append("]");

                return _string.ToString();
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Returns StringBuilder by appending value (as per Type) and ","
        /// </summary>
        /// <typeparam name="T">Type of value (int or string)</typeparam>
        /// <param name="_string">JSON stringbuilder to be appended with value</param>
        /// <param name="value">This value will be appended</param>
        /// <returns>StringBuilder appended with value and then ","</returns>
        private StringBuilder appendStringBuilderString<T>(StringBuilder _string, T value)
        {
            var formatString = "{0},";
            if (typeof(T) == typeof(string))
            {
                formatString = "'{0}',";
            }

            return _string.Append(string.Format(formatString, value));
        }
    }
    }
}
