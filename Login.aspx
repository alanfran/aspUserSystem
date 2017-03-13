<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" MasterPageFile="MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style1">
    
        <div class="auto-style1">
    
        <strong><span class="auto-style3">Login Page</span><br class="auto-style3" />
        </strong>
        </div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style4"><strong>UserName</strong></td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBoxUserName" runat="server" CssClass="auto-style7" Width="180px" style="font-size: medium"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUserName" CssClass="auto-style8" ErrorMessage="Please enter a user name."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"><strong>Password</strong></td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBoxPassword" runat="server" CssClass="auto-style7" TextMode="Password" Width="180px" style="font-size: medium"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPassword" CssClass="auto-style8" ErrorMessage="Please enter a password."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr class="auto-style7">
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Button ID="Button_Login" runat="server" OnClick="Button1_Click" Text="Log In" Width="74px" CssClass="auto-style4" />
                </td>
                <td class="auto-style4">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Register.aspx">Register a new account.</asp:HyperLink>
                </td>
            </tr>
            <tr class="auto-style7">
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        </table>
    
    </div>
   </asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            font-size: large;
        }
        .auto-style3 {
            font-size: x-large;
        }
        .auto-style4 {
            font-size: medium;
        }
    </style>
</asp:Content>
