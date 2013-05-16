<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listsoldiers.aspx.cs" Inherits="TheBattle.Interface.listsoldiers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<br/><br/>
<a href="soldiers.aspx">Add soldier</a>
<br/><br/>

  <div class="item">
        <h3>
            Soldiers</h3><br />
        <div class="item">
            <div class="body">
    <asp:Repeater ID="soldiers" runat="server">
    <ItemTemplate><div>
        <div class=soldier><%# Eval("Name") %><br/><br/><br/><br/><br/><br/>
        <a href = "soldiers.aspx?id=<%# Eval("Id") %>" class = 'edit'> Edit this soldier </a></div>
    </ItemTemplate>
    
    </asp:Repeater>
    </div>
    </div>
    </div>
</asp:Content>
