<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="imcs_assignment4.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Name :"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Age :"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Email :"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
         <p>
            <asp:Label ID="conform" runat="server" Text="submitted!!!" Visible ="false"></asp:Label>
           
        </p>

        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
        </p>
        <p>
             <asp:Label ID="lblmessage" runat="server" >
            
            </asp:Label>
        </p>
    </form>
</body>
</html>
