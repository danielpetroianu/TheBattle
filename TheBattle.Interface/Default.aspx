<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="TheBattle.Interface._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   
            <div class="spacer">
               </div>
            
		<div class="item">

			<div class="title">Armies</div>
			
			<div class="body">

  <asp:DropDownList ID="ddl" runat="server">
                </asp:DropDownList>       

			</div>


		<div class="item">

			<div class="title">Soldiers</div>

			<div class="body">
				
			
                <asp:CheckBoxList ID="soldiers" runat="server">
                </asp:CheckBoxList>
                <asp:Button ID="Button1" runat="server" Text="Save" />
             </div>

		</div>

		<div class="divider"><span></span></div>
        
    
		</div>
		</div>
            
            
            
            
</asp:Content>
