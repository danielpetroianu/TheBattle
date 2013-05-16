<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="soldiers.aspx.cs" Inherits="TheBattle.Interface.soldiers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="spacer">
    </div>
    <div class="item">
        <h3>
            Soldiers</h3><br />
        <div class="item">
                Please insert the soldier's name:<br />
            <div class="body">
                <asp:TextBox ID="soldier_name" runat="server"></asp:TextBox>
                <br />
            </div>
        </div>
        <div class="item">
                Choose his weapons<br />
            <div class="body">
                <asp:DropDownList ID="weapon_ddl" runat="server">
                </asp:DropDownList>
            </div>
            <div class="item"><br />
                <asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Click" />
            </div>
            <div class="divider">
                <span></span>
            </div>
        </div>
</asp:Content>
