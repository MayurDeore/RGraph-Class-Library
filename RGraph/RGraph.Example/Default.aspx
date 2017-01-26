<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RGraph.Example.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.10.0.min.js"></script>
    <script src="Scripts/RGraph/RGraph.common.core.js"></script>
    <script src="Scripts/RGraph/RGraph.common.dynamic.js"></script>
    <script src="Scripts/RGraph/RGraph.common.tooltips.js"></script>
    <script src="Scripts/RGraph/RGraph.line.js"></script>
    <script src="Scripts/RGraph/RGraph.bar.js"></script>
    <script src="Scripts/RGraph/RGraph.pie.js"></script>
    <script src="Scripts/RGraph.custom.js"></script>
    <style>
    .RGraph_tooltip {
        font-size: 16pt !important;
        font-weight: bold;
        text-align: center;
        padding: 15px;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
        
        <hr />

        <center><h3>Line Chart</h3></center>
    <div>
    <canvas id="cvsLine" width="900" height="600"></canvas>
    </div>
         <hr />

        <center><h3>Bar Chart</h3></center>

        <div>
    <canvas id="cvsBar" width="900" height="600"></canvas>
    </div>
         <hr />

        <center><h3>3D Bar Chart</h3></center>
        <div>
    <canvas id="cvsBar3d" width="900" height="600"></canvas>
    </div>

         <hr />

        <center><h3>Pie Chart</h3></center>
        <div>
    <canvas id="cvsPie" width="900" height="600"></canvas>
    </div>

         <hr />

        <center><h3>3D Pie Chart</h3></center>
        <div>
    <canvas id="cvsPie3d" width="900" height="600"></canvas>
    </div>

         <hr />

        <center><h3>3D Donut Chart</h3></center>
        <div>
    <canvas id="cvsDonut3d" width="900" height="600"></canvas>
    </div>


        
        <script>
    

           
           
            $(function (){

                 //Line Chart
                new rgraphclass("Default.aspx/getChartData", "", 'Line', 'cvsLine', 'Programming Languages');       

                //2D Bar Chart
                new rgraphclass("Default.aspx/getChartData", "", 'Bar', 'cvsBar', 'Programming Languages', false);

                          
                //3D Bar Chart
                new rgraphclass("Default.aspx/getChartData", "", 'Bar', 'cvsBar3d', 'Programming Languages', true);

                         
                //2d Pie Chart
                new rgraphclass("Default.aspx/getChartData", "", 'Pie', 'cvsPie', 'Programming Languages', false);

                          
                //3d Pie Chart
                new rgraphclass("Default.aspx/getChartData", "", 'Pie', 'cvsPie3d', 'Programming Languages', true);

                         
                new rgraphclass("Default.aspx/getChartData", "", 'Donut', 'cvsDonut3d', 'Programming Languages', true);


           
            });
        
       
    </script>
    </form>

   
</body>
</html>
