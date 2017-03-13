<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" MasterPageFile="MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style1">
    
        <asp:Button ID="ButtonLogout" runat="server" OnClick="ButtonLogout_Click" Text="Log Out" />
        <div class="auto-style2">
            <asp:Label ID="LabelGreeter" runat="server" Text="Welcome, "></asp:Label>
        </div>
    
    </div>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
        .auto-style2 {
            text-align: left;
        }
    </style>
</asp:Content>

