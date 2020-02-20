<%@ Page Language="C#" MasterPageFile ="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="WebApplication2.WebForm" %>
<asp:Content ID ="id123" ContentPlaceHolderID ="MainContent" runat ="server">
    <div class = "jumbotran">
        <asp:FileUpload ID ="FileUpload" runat ="server" /><br />
        <br />
        <asp:Button ID ="Button1" runat="server" Text ="upload" OnClick="Button1_Click1" /></asp:Button>
        <br />
        <br />
        <asp:DataList ID ="Datalist1" runat ="server" RepeatColumns="2" >
            <ItemTemplate>
                <asp:Image ID ="Image1"
                    ImageUrl ='<%#Eval("Name","~/newfolder/{0}") %>'
                    width="350px" Height="350px" runat ="server" /><br />
                <%#Eval("Name") %>
            </ItemTemplate>
        </asp:DataList> 
    </div>
</asp:Content>