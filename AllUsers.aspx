<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AllUsers.aspx.cs" Inherits="AllUsers" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent1" runat="Server">

                <div>
                <% foreach (var user in allUsers) { %>
                        <div class ="taskdiv">
                           <b>Name:</b>  <%= user.Username %>
                        </div>
                <%} %>
                </div>

</asp:Content>



<%-- Hey toekomstige paul, wat zie je er weer cool en sexy uit! 
    Oh trouwens wil je een object aanmaken heeft paul uit het verleden een geweldige site gevonden!
    De site is: https://stackoverflow.com/questions/32473200/taking-user-input-to-create-a-unique-object
    Hoop dat het je gaat lukken toekomstige paul! (verleden high-five)
    --%>

