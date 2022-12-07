<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>









<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Applying different styles to different items of ASPxComboBox using both server-side and client-side functionally</title>
</head>
<body>
    <style>
        .myCssClass {
            background-color: bisque;
        }
    </style>
    <script type="text/javascript">
        function OnInit(s, e) {
            var elements = document.getElementsByClassName('toFind')
            for (var i = 0; i < elements.length ; i++) {
                elements[i].parentNode.parentNode.className = 'myCssClass';
            }
        }
    </script>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxComboBox ID="CategoriesCombo" runat="server" ValueType="System.Int32" ValueField="CategoryID" DataSourceID="CategoriesSource" TextField="CategoryName"
                EncodeHtml="false" OnDataBound="CategoriesCombo_DataBound">
            </dx:ASPxComboBox>
            <dx:ASPxComboBox ID="ProductsCombo" runat="server" ValueType="System.Int32" ValueField="ProductID" DataSourceID="ProductsSource" OnDataBound="ProductsCombo_DataBound"
                EncodeHtml="false" CallbackPageSize="20" EnableCallbackMode="true">
                <Columns>
                    <dx:ListBoxColumn FieldName="ProductName" />
                    <dx:ListBoxColumn FieldName="UnitPrice" />
                </Columns>
            </dx:ASPxComboBox>
            <asp:SqlDataSource ID="CategoriesSource" runat="server"
                ConnectionString="<%$ ConnectionStrings:NwindConnectionString %>"
                SelectCommand="SELECT [CategoryName], [CategoryID] FROM [Categories]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="ProductsSource" runat="server"
                ConnectionString="<%$ ConnectionStrings:NwindConnectionString %>"
                SelectCommand="SELECT [ProductName], [ProductID], [UnitPrice] FROM [Products]"></asp:SqlDataSource>
            <dx:ASPxGlobalEvents ID="Global" runat="server">
                <ClientSideEvents ControlsInitialized="OnInit" />
            </dx:ASPxGlobalEvents>
        </div>
    </form>
</body>
</html>
