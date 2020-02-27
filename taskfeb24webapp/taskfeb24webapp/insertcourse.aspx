<%@ Page Language="C#" MasterPageFile ="~/Site.Master" AutoEventWireup="true" CodeBehind="insertcourse.aspx.cs" Inherits="taskfeb24webapp.insertcourse" %>

<asp:Content ID ="courseinsert" ContentPlaceHolderID ="MainContent" runat="server">
    <asp:Label ID ="label1" Text ="cid" runat ="server"></asp:Label><br />
    <asp:TextBox ID ="TextBox1" runat ="server" Text =""></asp:TextBox><br />
        <asp:Label ID ="label2" Text ="cname" runat ="server"></asp:Label><br />
    <asp:TextBox ID ="TextBox2" runat ="server" Text =""></asp:TextBox><br />
            <asp:Label ID ="label3" Text ="startdate" runat ="server"></asp:Label><br />
    <asp:TextBox ID ="TextBox3" runat ="server" Text =""></asp:TextBox><br />

    <asp:Button ID ="button1" runat ="server" Text ="Insertcoursedata" OnClick="button1_Click"/>
    <asp:GridView ID ="GridView1" runat ="server"></asp:GridView>
</asp:Content>