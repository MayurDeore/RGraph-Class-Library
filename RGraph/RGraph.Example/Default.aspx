<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RGraph.Example.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.10.0.min.js"></script>
    <script src="Scripts/RGraph/RGraph.common.core.js"></script>
    <script src="Scripts/RGraph/RGraph.common.dynamic.js"></script>
    <script src="Scripts/RGraph/RGraph.common.tooltips.js"></script>
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
    <div>
    <canvas id="cvs" width="900" height="600"></canvas>
    </div>

         <div>
    <canvas id="cvs1" width="900" height="600"></canvas>
    </div>
     <script>
        $(function () {

            $.ajax({

                url: "Default.aspx/getChartData",
                type:"post",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (result) {
                    draw3dPieChart(result, 'cvs', 'Programming Languages');
                }
            });

        });

       
    </script>
    </form>

   
</body>
</html>
