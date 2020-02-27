<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="updatecourse.aspx.cs" Inherits="taskfeb24webapp.updatecourse" %>
<asp:Content ID ="updatecourse" ContentPlaceHolderID ="MainContent" runat ="server">
    <asp:Label ID ="label1" Text ="cid" runat ="server"></asp:Label><br />
    <asp:TextBox ID ="Textbox1" Text ="" runat ="server"></asp:TextBox><br />
        <asp:Label ID ="label2" Text ="startdate" runat ="server"></asp:Label><br />
    <asp:TextBox ID ="Textbox2" Text ="" runat ="server"></asp:TextBox><br />

    <asp:Button ID ="button1" runat ="server" Text ="updatecourse" OnClick="button1_Click" />
    <asp:GridView ID ="GridView1" runat="server"></asp:GridView>
</asp:Content>