using RGraph.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGraph.PieChart
{
    public class Pie :StringServices,IGraph
    {
        private GraphConfig _config;
        /// <summary>
        /// Constructor Pie Chart
        /// </summary>
        public Pie()
        {
            this._config = new GraphConfig();
        }
        /// <summary>
        /// Constructor Sets custom Config to be used while generating Graph Data.
        /// e.g Custom Colors string Array can passed 
        /// </summary>
        /// <param name="conf">Config object with custom configuration.</param>
        public Pie(GraphConfig conf)
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
        private List<string> getGraphDataList(DataSet ds)
        {

            var PieString = new List<string>();
            //chartData:-  double values
            //labelData:-  string Label Values
            //colorData:-  string Color values

            var chartData = initializeString();
            var labelData = initializeString();
            var colorData = initializeString();

            var i = 0;
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow drow in ds.Tables[0].Rows)
                {
                    //drow[0]:- Label Name 
                    //drow[1]:- Double Value

                    try
                    {
                        chartData = appendValue<double>(chartData, Convert.ToDouble(drow[1].ToString()));
                    }
                    catch (Exception)
                    {
                        chartData = appendValue<double>(chartData, 0.00);

                    }
                    labelData = appendValue<string>(labelData, drow[0].ToString());
                    if (i==(this._config.Colors.Length))
                    {
                        i = 0;
                    }
                    colorData = appendValue<string>(colorData, this._config.Colors[i++]);
                }


                PieString.Add(finalizeString(chartData));
                PieString.Add(finalizeString(labelData));
                PieString.Add(finalizeString(colorData));
            }



            return PieString;
        }


        /// <summary>
        /// Returns Chart Object having data for graph creation
        /// </summary>
        /// <param name="ds">Dataset containing data for graph</param>
        /// <returns>Chart object</returns>

        public Chart getGraphData(DataSet ds)
        {
            var listChartData = this.getGraphDataList(ds);
            var chart = new Chart();
            chart.Data = listChartData[0];
            chart.Label = listChartData[1];

            chart.Color = listChartData[2];


            return chart;
        }
    }
}

