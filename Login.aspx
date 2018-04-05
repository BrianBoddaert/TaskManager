<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="CreateTask" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent1" runat="Server">

<<<<<<< HEAD
     <form id="loginform" runat="server">
         <asp:Label ID="loginwarning" runat="server" style="color:red;"></asp:Label>
        <h1>Log in</h1>
=======
    <div class="container purplebackground">
     <form id="loginform" runat="server">
         <asp:Label ID="loginwarning" runat="server" style="color:red;"></asp:Label>
         <%if (!LoggedInUser.currentUser.isLoggedIn) { %>
            <h1>Log in</h1>
>>>>>>> 0e76954a1bead33234fa79f8b5c8b72285a07414
          <h2>Username: </h2>
          <asp:TextBox ID="username" runat="server" />
          <h2>Password: </h2>
          <asp:TextBox ID="password" runat="server" />

<<<<<<< HEAD
=======
         <%} else { %>
            <h1>Log out</h1>
         <%}%>

>>>>>>> 0e76954a1bead33234fa79f8b5c8b72285a07414
         <%if (!LoggedInUser.currentUser.isLoggedIn) { %>
            <asp:Button ID="loginButton" Text="Login" runat="server" OnClick="login"/>
         <%} else { %>
            <asp:Button ID="logoutButton" Text="Logout" runat="server" OnClick="logout"/>
         <%}%>
        <h1>Register</h1>
          <h2>Username: </h2>
          <asp:TextBox ID="username_register" runat="server" />
          <h2>Password: </h2>
          <asp:TextBox ID="password_register" runat="server" />

         <asp:Button ID="registerButton" Text="Register" runat="server" OnClick="register"/>
    </form>
<<<<<<< HEAD
=======
        </div>
>>>>>>> 0e76954a1bead33234fa79f8b5c8b72285a07414


</asp:Content>

