<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="taskfeb24webapp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
                        <p>
                <a class="btn btn-default" href="WebForm.aspx">get student data</a>
            </p>
              <p>
                <a class="btn btn-default" href="insertform.aspx">insertstudent</a>
            </p>
             <p>
                <a class="btn btn-default" href="updateform.aspx">updatestudent</a>
            </p>
            <p>
                <a class="btn btn-default" href="stugetbyid.aspx">getstudent</a>
            </p>
             <p>
                <a class="btn btn-default" href="deletestudent.aspx">deletestudent</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
             <p>
                <a class="btn btn-default" href="getfacultyallform.aspx">get faculty data</a>
            </p>
           <p>
                <a class="btn btn-default" href="insertfacultyform.aspx">insert faculty data</a>
            </p>
             <p>
                <a class="btn btn-default" href="updatefacultyform.aspx">update faculty data</a>
            </p>
             <p>
                <a class="btn btn-default" href="getfacultybyidform.aspx">get faculty by id</a>
            </p>
            <p>
                <a class="btn btn-default" href="deletefaculty.aspx">delete faculty</a>
            </p>
                    
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
                        <p>
                <a class="btn btn-default" href="getallcourseform.aspx">getcourserecords</a>
            </p>
             <p>
                <a class="btn btn-default" href="insertcourse.aspx">insertcoursedata</a>
            </p>
             <p>
                <a class="btn btn-default" href="updatecourse.aspx">updatecoursedata</a>
            </p>
            <p>
                <a class="btn btn-default" href="getcoursebyid.aspx">getcoursebyid</a>
            </p>
                 <p>
                <a class="btn btn-default" href="deletefromcourse.aspx">delete course</a>
            </p>
        </div>
    </div>

</asp:Content>
