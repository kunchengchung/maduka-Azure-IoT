<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IoT_WebAppGateWay.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <script type="text/javascript" src="/assets/script/jquery.canvasjs.min.js"></script>
        <script type="text/javascript">
    window.onload = function () {
        // 建立溫度的圖表
        var dataSeries = { type: "line" };

        var data = [];
        var dataPoints = [<%=strTempData%>];
        dataSeries.dataPoints = dataPoints;
        data.push(dataSeries);
        funCreateChart("chartContainer", "溫度變化", data);

        var data = [];
        var dataPoints = [<%=strHumiData%>];
        dataSeries.dataPoints = dataPoints;
        data.push(dataSeries);
        funCreateChart("chartHumidity", "濕度變化", data);
    }

    function funCreateChart(chartobj, title, data) {
        var chart = new CanvasJS.Chart(chartobj,
        {
            zoomEnabled: true,
            title: {
                text: title
            },
            axisY: {
                includeZero: false
            },
            data: data,  // random generator below

        });

        chart.render();
    }
        </script>
        <div class="split style1">
            <section>
                <div class="field half first">
                    <asp:TextBox runat="server" ID="txtDate"></asp:TextBox>
                </div>
                <div class="field half">
                    <asp:Button runat="server" ID="btnQuery" Text="Query" OnClick="btnQuery_Click" />
                </div>
            </section>
        </div>
        <div id="chartContainer" style="height: 300px; width: 100%;"></div>
        <div id="chartHumidity" style="height: 300px; width: 100%;"></div>
    </form>
</body>
</html>
