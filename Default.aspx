<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <input id ="date_input" dateformat="d M y" type="date"/>
     <asp:Chart ID="Chart1" runat="server">
            <Series>
                <asp:Series XValueType="String" YValueType="String" YValueMembers="download_speed" XValueMember="time" Name="Series1" ChartArea="ChartArea1">
                </asp:Series>
                <asp:Series XValueType="String" YValueType="String" YValueMembers="upload_speed" XValueMember="time" Name="Series2" ChartArea="ChartArea1">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                <AxisX Title="TIME"></AxisX>
                <AxisY Title="SPEED"></AxisY>
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
    </div>
    </form>
</body>
</html>
