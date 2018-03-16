<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateSubject.aspx.cs" Inherits="CreateSubject" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent1" runat="Server">
    <div class="container purplebackground">
    <form id="form1" runat="server">

        <div class="FillInBox">
            <h2>Name: </h2>
            <asp:TextBox ID="subjectName" runat="server" />
        </div>

        <div class="FillInBox">
            <h2>Color: </h2>
            <select ID="subjectColor" name="subjectColor" class="subjectColor" runat="server">
                <option style="background-color:green;" runat="server" selected value="green"></option>
                <option style="background-color:yellow;" runat="server" value="yellow"></option>
                <option style="background-color:red;" runat="server" value="red"></option>
            </select>
        </div>

        <asp:Button ID="submitButton" Text="Add" runat="server" OnClick="addSubject"/>

     </form>
        </div>

    <script type="text/javascript" src="script.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
        <script>
            $(document).ready(function () {
                setColor();
                $('select.subjectColor').change(function () {
                    setColor();
                });
            });

            function setColor() {
                var color = $('select.subjectColor').find('option:selected').attr('value');
                $('select.subjectColor').css('background', color);
            }
    </script>

</asp:Content>


