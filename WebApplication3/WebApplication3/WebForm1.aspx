<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>


<asp:Content ID="id122" ContentPlaceHolderID ="MainContent" runat="server">
    <div class ="sarcastic">
        <asp:Label ID="Label1" runat="server" Text="Enter name"></asp:Label>
        <br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
                <asp:Label ID="Label2" runat="server" Text="Enter DOB"></asp:Label>
        <br />
                        <asp:Calendar ID="calender1" runat="server"></asp:Calendar>
        <br />
                        <asp:Label ID="Label3" runat="server" Text="Gender" Font-Names="Arial"></asp:Label>
        <br />  
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        <br />
                                <asp:Label ID="Label4" runat="server" Text="mark hobbies"></asp:Label>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>badminton</asp:ListItem>
            <asp:ListItem>reading</asp:ListItem>
            <asp:ListItem>travelling</asp:ListItem>
            <asp:ListItem>singing</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Label ID ="label5" runat ="server" Text ="Education"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>high school</asp:ListItem>
            <asp:ListItem>pre university</asp:ListItem>
            <asp:ListItem>graduation</asp:ListItem>
            <asp:ListItem>PG</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID ="btn1" Text ="submit" runat ="server" OnClick="btn1_Click" />


        </div>
    <div class ="sarcastic">
        <asp:Label ID="lb1Display" runat="server" Text =""></asp:Label>
    </div>
    
</asp:Content>