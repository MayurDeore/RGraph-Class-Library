# RGraph-Class-Library
RGraph Class Library is Wrapper for [RGraph Javascript library](https://www.rgraph.net/) for ASP.NET. 

# How to use?

First install RGraph Class Library using Nuget Package Manager.
```
 Install-Package RGraph.classLibrary
```


# On Server Side

Sample Webmethod which returns ```Chart``` Object,with some data.

```C#
using RGraph;
using System;
using System.Data;
using System.Web.Services;

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
       [WebMethod]
        public static Chart getChartData()
        {      //Returns JSON data to client

                    var returnData = new Chart();

                    var dataset = new DataSet();

                    //create dummy dataset 
                    var datatable = new DataTable();
                    datatable.Columns.AddRange(new DataColumn[]{
                        new DataColumn("Label",typeof(string)),
                        new DataColumn("Value",typeof(double))}
                     );
                    var datarow = datatable.NewRow();

                    //add data to dummy dataset
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

                   //specify custom color using config, if not specified default color will be used
                    var config = new GraphConfig();
                    config.Colors = new string[] { "Red", "Green", "Blue" };

                    var graph = new Graph(config);

                   //get dataset data in JSON format to be used by RGraph javascript to draw specified graph.
                    returnData = graph.getGraphData(dataset);
                    return returnData;


        }
    }
```

# On Client Side

On Client side reference ```RGraph.custom.js``` from ```Script``` Folder,along with [RGraph library](https://www.rgraph.net/download) depending on the graph you want(e.g ```RGraph.Pie.js``` for Pie Char).

```javascript
<script src="Scripts/RGraph.custom.js"></script>
```

Add canvas element in HTML.

```HTML
<canvas id="cvs"></canvas>
```

Now finally initialize rgraphclass constructor with specified parameters, which ultimately draws graph.

```javascript
 <script>
 //catch some event here
  var g= new rgraphclass("url", "JSON data to send", "Type of chart", "Canvas HTML Id", "Title for graph", "True for 3d else false");
 <script>
```

That's it, above object creation will do all work, from ajax call to rendering graph.

