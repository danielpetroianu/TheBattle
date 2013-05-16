<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="soldiers.aspx.cs" Inherits="TheBattle.Interface.soldiers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">



            <div class="spacer">
               </div>
            
		<div class="item">

			<div class="title">Soldiers</div>
			
			<div class="body">

  <asp:DropDownList ID="ddl" runat="server">
                </asp:DropDownList>       

			</div>


		<div class="item">

			<div class="title">Please insert the soldier's name:</div>

			<div class="body">
				
			    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
				
		             </div>

		</div>
           
		<div class="item">

			<div class="title">Choose his weapons</div>
			
			<div class="body">

  <asp:DropDownList ID="weapons" runat="server">
                </asp:DropDownList>       

			</div>

           
		<div class="item">

			<div class="title">Is he a captain?</div>
			
			<div class="body">

      <asp:CheckBox runat="server">
      </asp:CheckBox>     

			</div>

            
      	    <asp:Button ID="Button1" runat="server" Text="Save" />
    
		</div>
        
		<div class="divider"><span></span></div>
		</div>
            
            
            
            
</asp:Content>
