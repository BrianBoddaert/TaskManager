<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateTask.aspx.cs" Inherits="CreateTask" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent1" runat="Server">

    <form id="form1" runat="server">
        <div class="container purplebackground" >
            <div class="FillInBox">
                <h2>Name: </h2>
                <asp:TextBox ID="nameTextBox" runat="server" />
            </div>
            <div class="FillInBox">
                <h2>Subject: </h2>
                <asp:DropDownList ID="subjectDropList" runat="server">
                </asp:DropDownList>
            </div>
            <div class="FillInBox">
                <h2>Assignee: </h2>
                <asp:DropDownList ID="assigneeDropList" runat="server">
                </asp:DropDownList>
            </div>
            <div class="FillInBox">
                <h2>Deadline: </h2>
                <input ID="deadlineDate" type="date" runat="server"/>
            </div>
            <div class="BigFillInBox">
                <h2>Description: </h2>
                <asp:TextBox ID="desTestBox" runat="server" />
            </div>
            <div class="FillInBox">
                <h2>Urgency: </h2>
                <select ID="urgencyList" name="urgency" class="urgency" runat="server">
                    <option style="background-color:green;" runat="server" selected value="green"></option>
                    <option style="background-color:yellow;" runat="server" value="yellow"></option>
                    <option style="background-color:red;" runat="server" value="red"></option>
                </select>
            </div>

            <div class="FillInBox">
                <h2>Type: </h2>
                <select ID="typeList" runat="server">
                    <option  runat="server" selected value="small"></option>
                    <option  runat="server" value="medium"></option>
                    <option  runat="server" value="big"></option>
                </select>
            </div>

            <asp:Button ID="submitButton" Text="Add" runat="server" OnClick="addTask"/>
        </div>
    </form>
    <script type="text/javascript" src="script.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
        <script>
            $(document).ready(function () {
                console.log("oke");
                setColor();
                $('select.urgency').change(function () {
                    setColor();
                });
            });

            function setColor() {
                var color = $('select.urgency').find('option:selected').attr('value');
                $('select.urgency').css('background', color);
            }
    </script>

</asp:Content>



<%-- Hey toekomstige paul, wat zie je er weer cool en sexy uit! 
    Oh trouwens wil je een object aanmaken heeft paul uit het verleden een geweldige site gevonden!
    De site is: https://stackoverflow.com/questions/32473200/taking-user-input-to-create-a-unique-object
    Hoop dat het je gaat lukken toekomstige paul! (verleden high-five)
    --%>

