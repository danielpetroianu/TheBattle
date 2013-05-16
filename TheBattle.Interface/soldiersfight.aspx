<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="soldiersfight.aspx.cs" Inherits="TheBattle.Interface.soldiersfight" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<br/><br/>
<div class="item">

			<div class="title">Choose 2 soldiers for the fight:</div>
			
			<div class="body">

<table>
<tr><td><div class=soldier>Soldier 1 </div></td><td><div class=soldier> soldier 2</div></td></tr>
<tr>
<td>
    <asp:CheckBoxList ID="soldier1" runat="server">
    </asp:CheckBoxList>
    </td>
    <td>
    <asp:CheckBoxList ID="soldier2" runat="server">
    </asp:CheckBoxList>
    </td>
    </tr>
    </table>
			</div>

            
      	    <asp:Button ID="Button1" runat="server" Text="Fight" />
    
		</div>
        
</asp:Content>
