<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Bumblebee.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 <style>
       form {
            max-width: 500px;
            margin: 0 auto;
        }
        label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }
        input[type=text], input[type=date], input[type=number] {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
            margin-bottom: 10px;
            font-size: 16px;
        }
        input[type=submit] {
            background-color: #4CAF50;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }
        input[type=submit]:hover {
            background-color: #45a049;
        }
        .error {
            color: red;
            font-size: 14px;
            margin-bottom: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <div class="container">
        <label for="customer_id">Customer ID:</label>
           <asp:TextBox ID="txtcustomerid" runat="server"></asp:TextBox>

        <label for="fullname">Full Name:</label>
           <asp:TextBox ID="txtfullname" runat="server"></asp:TextBox>

        <label for="dob">Date of Birth:</label>
           <asp:TextBox ID="txtdateofbirth" runat="server"></asp:TextBox>

        <label for="loan_balance">Loan Balance:</label>
           <asp:TextBox ID="txtloanbalance" runat="server"></asp:TextBox>

        <label for="used_amount">Used Amount:</label>
           <asp:TextBox ID="txtuseramount" runat="server"></asp:TextBox>

        <label for="installement_plan">Installement Plan:</label>
           <asp:TextBox ID="txtinstallementplan" runat="server"></asp:TextBox>

           <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />

    </div>
    </form>
</body>
</html>