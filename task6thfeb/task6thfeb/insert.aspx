<%@ Page Language="C#" MasterPageFile ="~/Site.Master" AutoEventWireup="true" CodeBehind="insert.aspx.cs" Inherits="task6thfeb.insert" %>

<asp:Content ID ="sadist1" ContentPlaceHolderID ="MainContent" runat ="server">
    <div class="sarcastic">
 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="must enter id" ControlToValidate="TextBox" ValidationGroup="vg" ForeColor="Red">enter id</asp:RequiredFieldValidator>
 <br />
    <asp:Label ID ="label1" Text="Tid" runat="server"></asp:Label><br />
 <asp:TextBox ID ="TextBox" runat="server" Text=""></asp:TextBox><br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="must enter name" ControlToValidate="TextBox1" ValidationGroup="vg" ForeColor="Red">Enter name</asp:RequiredFieldValidator>
    <br />
    <asp:Label ID ="label2" Text="Tname" runat="server"></asp:Label><br />
    <asp:TextBox ID ="TextBox1" runat="server" Text=""></asp:TextBox><br />
  
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="must enter location" ControlToValidate="TextBox2" ValidationGroup="vg" ForeColor="Red">Enter location</asp:RequiredFieldValidator>
      <br />
    <asp:Label ID ="label3" Text="location" runat="server"></asp:Label><br />
    <asp:TextBox ID ="TextBox2" runat="server" Text=""></asp:TextBox><br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="must enter domain" ControlToValidate="TextBox3" ValidationGroup="vg" ForeColor="Red">enter techdomain</asp:RequiredFieldValidator>
     <br />
    <asp:Label ID ="label4" Text="techdomain" runat="server"></asp:Label><br />
    <asp:TextBox ID ="TextBox3" runat ="server" Text =""></asp:TextBox><br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="enter must date" ControlToValidate="TextBox4" ValidationGroup="vg" ForeColor="Red">enter date</asp:RequiredFieldValidator>
 <br />
    <asp:Label ID ="label5" Text="startdate" runat="server"></asp:Label><br />
    <asp:TextBox ID ="TextBox4" runat ="server" Text =""></asp:TextBox><br />
   <br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="vg" ForeColor="Red" />
    <asp:Button ID ="button1" runat ="server" Text ="insert data" OnClick="button1_Click" ValidationGroup="vg" />
         <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <asp:Label ID ="Label6" runat ="server" Text =""></asp:Label>
</div>
</asp:Content>