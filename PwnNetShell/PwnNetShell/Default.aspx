<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PwnNetShell._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Vulnerable Upload Page</h1>

        <p>
            This page updloads a file to the web application without any checks and puts it in the root of
            the application folder. This location is directly browsable, so an uploaded ASPX page will execute.
        </p>

        <h3>Select file to upload:</h3>
        <asp:FileUpload runat="server" ID="fuVuln" />
        <br />
        <asp:Button runat="server" ID="btnUpload" OnClick="btnUpload_OnClick" Text="Upload File" />
        <br />
        <asp:Label runat="server" ID="lblMessage" />
    </div>
    </form>
</body>
</html>