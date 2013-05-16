<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listsoldiers.aspx.cs" Inherits="TheBattle.Interface.listsoldiers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<br/><br/>
<a href="soldiers.aspx">Add soldier</a>
<br/><br/>
    <asp:Repeater ID="soldiers" runat="server">
    <ItemTemplate><div class=soldier><%# Eval("Name") %></div></ItemTemplate>
    </asp:Repeater>
</asp:Content>
