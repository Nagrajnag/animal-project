<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="displaydetails.aspx.cs" Inherits="imcs_assignment4.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script type="text/javascript">
    function validate()  {
        var x = document.forms["form1"]["TextBox1"].value;
        var y = document.forms["form1"]["TextBox2"].value;
        var z = document.forms["form1"]["TextBox3"].value;
        if (x == "")
            {
                alert("Name must be filled out");
                return false;
        }
        if (y == "") {
            alert("age must be filled out");
            return false;
        }
        if (z == "") {
            alert("email must be filled out");
            return false;
        }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Name :"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Age :"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Email :"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Country"></asp:Label>
            <asp:DropDownList ID="ddl_country" autopostback="true" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" DataTextField="itemname" DataSourceID="XmlDataSource1">
            </asp:DropDownList>
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/xmlfiles/countries.xml"></asp:XmlDataSource>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="City"></asp:Label>
            <asp:DropDownList ID="ddl_city" DataTextField="name" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" DataSourceID="XmlDataSource2">
            </asp:DropDownList>
            <asp:XmlDataSource ID="XmlDataSource2" runat="server" DataFile="~/xmlfiles/Empty.xml"></asp:XmlDataSource>
        </p>
        <p>
            <asp:Label ID="conform" runat="server" Text="submitted!!!" Visible="false"></asp:Label>

        </p>

        <p>
            <asp:Button ID="Button1" runat="server"  OnClick="Button1_Click" Text="submit" OnClientClick="validate();" />
        </p>
        <p>
            <asp:Label ID="lblmessage" runat="server">
            
            </asp:Label>
        </p>
    </form>
</body>
</html>
