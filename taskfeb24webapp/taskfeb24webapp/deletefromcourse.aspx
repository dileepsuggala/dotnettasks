<%@ Page Language="C#" MasterPageFile ="~/Site.Master" AutoEventWireup="true" CodeBehind="deletefromcourse.aspx.cs" Inherits="taskfeb24webapp.deletefromcourse" %>

<asp:Content ID ="deletecourse" ContentPlaceHolderID ="MainContent" runat ="server">
    <asp:Label ID ="label1" Text ="cid" runat ="server"></asp:Label><br />
    <asp:TextBox ID ="Textbox1" Text ="" runat ="server"></asp:TextBox><br />
     
    <asp:Button ID ="button1" runat ="server" Text ="deletecourse" OnClick="button1_Click" />
    <asp:GridView ID ="GridView1" runat="server"></asp:GridView>
</asp:Content>