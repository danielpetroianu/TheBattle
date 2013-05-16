<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listarmies.aspx.cs" Inherits="TheBattle.Interface.listarmies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<br/><br/>
<a href="armies.aspx">Add army</a>
<br/><br/>

  <div class="item">
        <h3>
            Armies</h3><br />
        <div class="item">
            <div class="body">
    <asp:Repeater ID="armies" runat="server">
    <ItemTemplate><div>
        <div class=army><%# Eval("Name") %><br/><br/><br/><br/>
        <a href = "armies.aspx?id=<%# Eval("Id") %>" class = 'edit'> Edit this army </a></div>
    </ItemTemplate>
    
    </asp:Repeater>
    </div>
    </div>
    </div>
</asp:Content>
