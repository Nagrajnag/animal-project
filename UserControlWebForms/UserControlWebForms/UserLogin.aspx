<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="UserControlWebForms.UserLogin" %>

<%@ Register Src="~/Login.ascx" TagPrefix="uc1" TagName="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  
    <asp:Label ID="Label1" runat="server" Text="Verification Code: "></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <uc1:Login runat="server" id="Login" />
    <br />
</asp:Content>
