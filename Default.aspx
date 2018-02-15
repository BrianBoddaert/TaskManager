<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent1" Runat="Server">
    <div class="container" id="taskoverview" >
        <div class="taskbar">
        <div class ="taskbartitle" style="background-color:#88C178">Small tasks  </div>
        </div>
        <div class="taskbar" style="border-left:1px;border-right:1px;">
            <div class ="taskbartitle"  style="background-color:#DAFF38"> Medium tasks </div>
        </div>
        <div class="taskbar">
            <div class ="taskbartitle"  style="background-color:#C93528"> Big tasks </div>
        </div>
    </div>
    <div class="container" id="timeline"></div>
</asp:Content>

