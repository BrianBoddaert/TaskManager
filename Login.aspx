<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="CreateTask" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent1" runat="Server">

    <div class="container purplebackground">
     <form id="loginform" runat="server">
         <asp:Label ID="loginwarning" runat="server" style="color:red;"></asp:Label>
         <%if (!LoggedInUser.currentUser.isLoggedIn) { %>
            <h1>Log in</h1>
          <h2>Username: </h2>
          <asp:TextBox ID="username" runat="server" />
          <h2>Password: </h2>
          <asp:TextBox ID="password" runat="server" />

         <%} else { %>
            <h1>Log out</h1>
         <%}%>

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
        </div>


</asp:Content>

