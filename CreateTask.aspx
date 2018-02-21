<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateTask.aspx.cs" Inherits="CreateTask" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent1" Runat="Server">
        <div class="container" id="createtask" >
            <div class="FillInBox"><h2>Name: </h2><input runat="server"/></div>
            <div class="FillInBox"><h2>Subject: </h2><select>
            <option value="Programmeren">Programmeren</option>
            <option value="Management">Management</option>
            <option value="Registratie">Registratie</option></select>
            </div>
            <div class="FillInBox"><h2>Assignee: </h2><select>
            <option value="Paul">Paul</option>
            <option value="Brian">Brian</option>
            <option value="Patrick">Patrick</option></select>
            </div>
            <div class="FillInBox"><h2>Deadline: </h2><input type="date" runat="server"/></div>
            <div class="BigFillInBox"><h2>Description: </h2><textarea runat="server"/></div>
            <button class="AddButton">Add</button>
        </div>
</asp:Content>

