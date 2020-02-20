<%@ Page Language="C#" MasterPageFile ="~/Site.Master"  AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication3.WebForm2" %>


<asp:Content ID ="id111" ContentPlaceHolderID ="MainContent" runat ="server">
    <div class ="sadist">
        
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Must enter name" ControlToValidate="TextBox1" ValidationGroup="vg">Enter Name</asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age between 18 and 100" ControlToValidate="TextBox2" ForeColor="Black" MaximumValue="100" MinimumValue="18" ValidationGroup="vg" Type="Integer">Enter Age</asp:RangeValidator>
        <br />
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email must be in correct format" ControlToValidate="TextBox3" ForeColor="Black" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="vg">Enter Email id</asp:RegularExpressionValidator>
        <br />
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="must enter password" ControlToValidate="TextBox4" ForeColor="Red" ValidationGroup="vg">Enter password</asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="password must match" ControlToCompare="TextBox4" ControlToValidate="TextBox5" ForeColor="Red" ValidationGroup="vg">confirm password</asp:CompareValidator>
        <br />
        <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="vg" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="submit" ValidationGroup="vg" OnClick="Button1_Click" />
        <asp:Label ID ="Label1" runat ="server" Text =""></asp:Label>
    </div>
    
</asp:Content>