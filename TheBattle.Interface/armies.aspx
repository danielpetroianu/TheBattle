<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="armies.aspx.cs" Inherits="TheBattle.Interface.armies" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="spacer">
    </div>
    <div class="item">
        <div class="title">
            Creat an Army
        </div>
        <div class="body">

            <asp:ValidationSummary ID="validationSummary" runat="server" />

            <br />
            <br />
            <div class="item">
                <div class="title">
                    Army name:
                </div>
                <div class="body">
                    <asp:TextBox ID="armyName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requiredName" runat="server" 
                        ControlToValidate="armyName" ErrorMessage="Army name is required." 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </div>
            </div>
            <br />
            <div class="item">
                <div class="title">
                    Available Soldiers
                </div>
                <br />
                <div class="body">
                    <asp:Label Text="There are no soldiers available" runat="server" ID="noSoldiersMessage"
                        Visible="false" CssClass="title" />
                    <asp:CheckBoxList runat="server" ID="availableSoldiersList">
                    </asp:CheckBoxList>
                </div>
                <br />
                <div>
                    <a href="<%=Page.ResolveUrl("~/soldiers.aspx") %>">create new soldiers</a>
                </div>
            </div>
            <br />
            <div class="item">
                <div class="body">
                    <asp:Button ID="btnSave" runat="server" Text="Create" OnClick="btnSave_Click" />
                </div>
            </div>
        </div>
        <div class="divider">
        </div>
    </div>
</asp:Content>
