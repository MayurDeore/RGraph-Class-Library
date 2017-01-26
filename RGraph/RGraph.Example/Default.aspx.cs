using RGraph;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RGraph.Example
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static Chart getChartData()
        {
            var returnData = new Chart();

            var dataset = new DataSet();

            var datatable = new DataTable();
            datatable.Columns.AddRange(new DataColumn[]{
                new DataColumn("Label",typeof(string)),
                new DataColumn("Value",typeof(double))}
        );
            var datarow = datatable.NewRow();

            datarow[0] = "PHP";
            datarow[1] = 100;
            datatable.Rows.Add(datarow);
            datarow = datatable.NewRow();
            datarow[0] = "Ruby";
            datarow[1] = 50;
            datatable.Rows.Add(datarow);
            datarow = datatable.NewRow();
            datarow[0] = "CSharp";
            datarow[1] = 40;
            datatable.Rows.Add(datarow);
            dataset.Tables.Add(datatable);

            var config = new GraphConfig();
            config.Colors = new string[] { "Red", "Green", "Blue" };
            var graph = new Graph(config);
            returnData = graph.getGraphData(dataset);


            var script = new StringBuilder();
            return returnData;


        }
    }
}