<%@ Page Language="C#" MasterPageFile ="~/Site.Master" AutoEventWireup="true" CodeBehind="getfacultybyidform.aspx.cs" Inherits="taskfeb24webapp.getfacultybyidform" %>

<asp:Content ID ="getbyfacid" ContentPlaceHolderID ="MainContent" runat="server">
    <asp:Label ID ="label1" Text ="fid" runat ="server"></asp:Label><br />
    <asp:TextBox ID ="Textbox" runat="server" Text =""></asp:TextBox><br />
    <asp:Button ID ="button1" runat="server" Text ="Getfaculty" OnClick="button1_Click"/>
    <asp:GridView ID ="GridView2" runat="server"></asp:GridView>
</asp:Content>
