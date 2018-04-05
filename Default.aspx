<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent1" Runat="Server">
    <div class="container" id="taskoverview" >
<<<<<<< HEAD
        <div class="taskbar" style="overflow-y: scroll;">
 <div class ="taskbartitle" style="background-color:#88C178;"> Small tasks  </div>     
                <% foreach (var task in allTasks) { %>
                    <%if (task.taskType == "0"){%>
            <a href="EdditTask.aspx?currentTaskID=<%=task.taskID%>" >
                        <div class ="taskdiv">
                            <span style="visibility:hidden" id="<%= task.taskID %>"></span>
                           <b>Name:</b>  <%= task.name %> <br />
                           <b>Description:</b> <%= task.description %> <br />
                            <b>Subject:</b> <%= task.subject.Name %> <br />
=======
        <div class="taskbar">
             <div class ="taskbartitle" style="background-color:#88C178;"> Small tasks  </div>     
            <div class="scrollbar">
                <% foreach (var task in allTasks) { %>
                    <%if (task.taskType == "0"){%>
                        <div class ="taskdiv">
                           <b>Name:</b>  <%= task.name %> <br />
                           <b>Description:</b> <%= task.description %> <br />
                            <b>Subject: </b> <%= task.subject.Name %>
>>>>>>> 0e76954a1bead33234fa79f8b5c8b72285a07414
                            <%if (task.urgency == "0"){%>
                                <img style="width:8%; float:right; margin-right: 5px;" src="/images/Small.png" />
                            <%}else if (task.urgency == "1"){%>
                                <img style="width:8%; float:right; margin-right: 5px;" src="/images/Medium.png" />
                            <%}else { %>
                                <img style="width:8%; float:right; margin-right: 5px;" src="/images/Big.png" />
                            <% } %>
                        </div>
<<<<<<< HEAD
                </a>
                    <%} %>
                <%} %>
                </div>
                <div class="taskbar" style="border-left:1px;border-right:1px;">
                    <div class ="taskbartitle"  style="background-color:#DAFF38"> Medium tasks </div>
=======
                    <%} %>
                <%} %>
            </div>
                </div>
                <div class="taskbar" style="border-left:1px;border-right:1px;">
                    <div class ="taskbartitle"  style="background-color:#DAFF38"> Medium tasks </div>
                    <div class="scrollbar">
>>>>>>> 0e76954a1bead33234fa79f8b5c8b72285a07414
                <% foreach (var task in allTasks) { %>
                    <%if (task.taskType == "1"){%>
                        <div class ="taskdiv">
                           <b>Name:</b>  <%= task.name %> <br />
                           <b>Description:</b> <%= task.description %> <br />
<<<<<<< HEAD
=======
                            <b>Subject: </b> <%= task.subject.Name %>
>>>>>>> 0e76954a1bead33234fa79f8b5c8b72285a07414
                            <%if (task.urgency == "0"){%>
                                <img style="width:8%; float:right; margin-right: 5px;" src="/images/Small.png" />
                            <%}else if (task.urgency == "1"){%>
                                <img style="width:8%; float:right; margin-right: 5px;" src="/images/Medium.png" />
                            <%}else { %>
                                <img style="width:8%; float:right; margin-right: 5px;" src="/images/Big.png" />
                            <% } %>
                        </div>
                    <%} %>
                <%} %>
<<<<<<< HEAD
                </div>
                <div class="taskbar">
                    <div class ="taskbartitle"  style="background-color:#C93528"> Big tasks </div>
=======
                        </div>
                </div>
                <div class="taskbar">
                    <div class ="taskbartitle"  style="background-color:#C93528"> Big tasks </div>
                    <div class="scrollbar">
>>>>>>> 0e76954a1bead33234fa79f8b5c8b72285a07414
                <% foreach (var task in allTasks) { %>
                    <%if (task.taskType == "2"){%>
                        <div class ="taskdiv">
                           <b>Name:</b>  <%= task.name %> <br />
                           <b>Description:</b> <%= task.description %> <br />
<<<<<<< HEAD
=======
                            <b>Subject: </b> <%= task.subject.Name %>
>>>>>>> 0e76954a1bead33234fa79f8b5c8b72285a07414
                            <%if (task.urgency == "0"){%>
                                <img style="width:8%; float:right; margin-right: 5px;" src="/images/Small.png" />
                            <%}else if (task.urgency == "1"){%>
                                <img style="width:8%; float:right; margin-right: 5px;" src="/images/Medium.png" />
                            <%}else { %>
                                <img style="width:8%; float:right; margin-right: 5px;" src="/images/Big.png" />
                            <% } %>
<<<<<<< HEAD
                        </div>
                    <%} %>
                <%} %>
=======
                            
                        </div>
                    <%} %>
                <%} %>
                        </div>
>>>>>>> 0e76954a1bead33234fa79f8b5c8b72285a07414
                </div>
        </div>
    <div class="container" id="timeline"></div>
</asp:Content>
