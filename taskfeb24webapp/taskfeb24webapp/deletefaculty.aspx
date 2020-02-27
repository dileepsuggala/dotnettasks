<%@ Page Language="C#" MasterPageFile ="~/Site.Master" AutoEventWireup="true" CodeBehind="deletefaculty.aspx.cs" Inherits="taskfeb24webapp.deletefaculty" %>
<asp:Content ID ="deletefaculty" ContentPlaceHolderID ="MainContent" runat ="server">
    <asp:Label ID ="label1" Text ="fid" runat ="server"></asp:Label><br />
    <asp:TextBox ID ="Textbox1" Text ="" runat ="server"></asp:TextBox><br />
     
    <asp:Button ID ="button1" runat ="server" Text ="deletefaculty" OnClick="button1_Click"  />
    <asp:GridView ID ="GridView1" runat="server"></asp:GridView>
</asp:Content>