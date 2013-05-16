<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="armies.aspx.cs" Inherits="TheBattle.Interface.armies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">



            <div class="spacer">
               </div>
            
		<div class="item">

			<div class="title">Armies</div>
			
			<div class="body">

  <asp:DropDownList ID="ddl" runat="server">
                </asp:DropDownList>       

			</div>

            
		<div class="item">

			<div class="title">Please insert the army name:</div>

			<div class="body">
				
			    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
				</div>

		</div>

		<div class="item">

			<div class="title">Choose the captain:</div>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            </asp:RadioButtonList>
			<div class="body">
				
                <br />
				
			    <asp:Button ID="Button2" runat="server" Text="Save" />
             </div>

		</div>

		<div class="divider"><span></span></div>
        
    
		</div>
		</div>
            
            
            
            
</asp:Content>
