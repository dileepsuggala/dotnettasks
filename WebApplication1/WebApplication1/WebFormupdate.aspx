<%@ Page Language="C#" MasterPageFile ="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormupdate.aspx.cs" Inherits="WebApplication1.WebFormupdate" %>

<asp:Content ID ="myupdate" ContentPlaceHolderID="MainContent" runat ="server">
    <asp:Label ID ="label1" Text="sid" runat="server"></asp:Label>
    <asp:TextBox ID ="TextBox" runat="server" Text=""></asp:TextBox><br />
        <asp:Label ID ="label2" Text="startdate" runat="server"></asp:Label><br />
    <asp:TextBox ID ="TextBox1" runat="server" Text=""></asp:TextBox><br />
    <asp:Button ID ="button1" runat ="server" Text ="updatedata" OnClick="button1_Click"  />
         <asp:GridView ID="GridView1" runat="server"></asp:GridView>

</asp:Content>

