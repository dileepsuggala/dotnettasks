﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="insertform.aspx.cs" Inherits="taskfeb24webapp.insertform" %>

<asp:Content ID ="stuinsert" ContentPlaceHolderID ="MainContent" runat="server">
    <asp:Label ID ="label1" Text ="sid" runat ="server"></asp:Label><br />
    <asp:TextBox ID ="TextBox1" runat ="server" Text =""></asp:TextBox><br />
        <asp:Label ID ="label2" Text ="sname" runat ="server"></asp:Label><br />
    <asp:TextBox ID ="TextBox2" runat ="server" Text =""></asp:TextBox><br />
    <asp:Button ID ="button1" runat ="server" Text ="Insertdata" OnClick="button1_Click" />
    <asp:GridView ID ="GridView1" runat ="server"></asp:GridView>
</asp:Content>