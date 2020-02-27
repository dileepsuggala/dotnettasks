<%@ Page Language="C#" MasterPageFile ="~/Site.Master" AutoEventWireup="true" CodeBehind="insertfacultyform.aspx.cs" Inherits="taskfeb24webapp.insertfacultyform" %>
<asp:Content ID ="stuinsert" ContentPlaceHolderID ="MainContent" runat="server">
    <asp:Label ID ="label1" Text ="fid" runat ="server"></asp:Label><br />
    <asp:TextBox ID ="TextBox1" runat ="server" Text =""></asp:TextBox><br />
        <asp:Label ID ="label2" Text ="fname" runat ="server"></asp:Label><br />
    <asp:TextBox ID ="TextBox2" runat ="server" Text =""></asp:TextBox><br />
    <asp:Button ID ="button1" runat ="server" Text ="Insertfacultydata" OnClick="button1_Click" />
    <asp:GridView ID ="GridView1" runat ="server"></asp:GridView>
</asp:Content>

