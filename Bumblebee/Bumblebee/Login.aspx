<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Bumblebee.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 <style>
        * {
            box-sizing: border-box;
            margin: 0;
            padding: 0;
        }
        
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
        }
        
        .container {
            max-width: 500px;
            margin: 0 auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        
        h2 {
            text-align: center;
            margin-bottom: 20px;
        }
        
        .input-group {
            margin-bottom: 15px;
        }
        
        .input-group label {
            display: block;
            margin-bottom: 5px;
        }
        
        .input-group input {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }
        
        .btn {
            display: inline-block;
            padding: 10px 20px;
            background-color: #4CAF50;
            color: #fff;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }
        
        .btn:hover {
            background-color: #3e8e41;
        }
        
        footer {
            text-align: center;
            padding: 20px;
            background-color: #ccc;
            margin-top: 20px;
        }
    </style> 
</head>
<body>
    <form id="form1" runat="server">
          <div class="container">
        <form method="post" action="Successlogin.jsp" id="login-form" onsubmit="return validateForm()">
            <h2>Login</h2>
            <div class="input-group">
                <label for="username">Username</label>
                <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
            </div>
            <div class="input-group">
                <label for="password">Password</label>
                <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
            </div>
            <div class="input-group">
                <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" />
                 <a href="Registration.aspx">Click here to go to Register Customer details</a>
	      </div>
        </form>
    </div>
    </form>
</body>
</html>