<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioGetyPost.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div>

            <div>
                 Name: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
           
              <br />
            <div>
                 Category:<asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Text="Beverages" Value="1" Selected="True" />
                <asp:ListItem Text="Condiments" Value="2" />
                <asp:ListItem Text="Confections" Value="3" />
                <asp:ListItem Text="Seafood" Value="4" />
                     </asp:DropDownList>
            </div>
           <br />
            <div>
                 Supplier: <asp:DropDownList ID="DropDownList3" runat="server">
                 <asp:ListItem Text="Exotic Liquids" Value="11" Selected="True" />
                <asp:ListItem Text="Tokyo Traders" Value="22" />
                <asp:ListItem Text="Mayumi's" Value="33" />
                <asp:ListItem Text="Pavlova, Ltd." Value="44" />
                      </asp:DropDownList>
            </div>
             <br />
            <div>
                 Unit Price <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </div>
             <br />
            <asp:Button ID="btnSave" runat="server" Text="AceptarPost" OnClick="btnSave_Click" />
            <div>
                <asp:Button ID="btnSave2" runat="server" Text="AceptarGet" OnClick="btnSave2_Click" />
            </div>

        </div>
    </form>
</body>
</html>
<%--//get: paso por response direct y recupero por reques query string

    //post: paso por server tranfer y recupero por request form--%>