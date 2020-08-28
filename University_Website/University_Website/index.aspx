<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Website.Master"
    CodeBehind="index.aspx.vb" Inherits="University_Website.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--SLIDER -->
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
            <li data-target="#myCarousel" data-slide-to="3"></li>
            <li data-target="#myCarousel" data-slide-to="4"></li>
        </ol>
        <!-- Wrapper for slides -->
        <div class="carousel-inner">
            <div class="item active">
                <img src="Images/1.jpg" width="100%">
            </div>
            <div class="item">
                <img src="Images/2.jpg" width="100%">
            </div>
            <div class="item">
                <img src="Images/3.jpg" width="100%">
            </div>
            <div class="item">
                <img src="Images/4.jpg" width="100%">
            </div>
            <div class="item">
                <img src="Images/5.jpg" width="100%">
            </div>
        </div>
        <!-- Left and right controls -->
        <a class="left carousel-control" href="#myCarousel" data-slide="prev"><span class="glyphicon glyphicon-chevron-left">
        </span><span class="sr-only">Previous</span> </a><a class="right carousel-control"
            href="#myCarousel" data-slide="next"><span class="glyphicon glyphicon-chevron-right">
            </span><span class="sr-only">Next</span> </a>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-10">
            <p>
                Palampur College is one of the best College in Himachal Pradesh, providing the highest
                quality and truly international standards of education. AAC holds firm in its belief
                that students do their best and teaching becomes productive when research is underlined
                as a criteria for scholarship, systematically guided by dedicated and quality teaching.
                <br />
                <br />
                Palampur College is one of the best College in Himachal Pradesh, providing the highest
                quality and truly international standards of education. AAC holds firm in its belief
                that students do their best and teaching becomes productive when research is underlined
                as a criteria for scholarship, systematically guided by dedicated and quality teaching.
            </p>
        </div>
    <%--<div class="col-lg-2 text-center" style="border: 1px solid #ddd; height: 150px;">
        <h4 style="color: crimson; text-decoration: underline">
            News & Notification</h4>
        <marquee direction="up" scrollamount="1" onmouseover="this.stop();" onmouseout="this.start();">
<ul>
<li>Admisson open for the session 2018-2019</li></ul>
<li>Admisson close for the session 2017-2018</li></ul>
</marquee>
    </div>--%>
    </div>
    <br />
    <br />
    <hr />
    <div class="row" style="margin-top: 20px;">
        <div class="col-lg-4">
            <h3 class="h3">
                Director's Message</h3>
            <img src="Images/Award1.jpg" class="img-thumbnail img-rounded img-responsive" height="200px"
                width="200px" />
            <br />
            <br />
            <p>
                Each student is endowed with potentials and capabilities beyond one's imagination.
                Education is a mere tool to encourage students to discover the "treasure within".
                The all round development and the quality education they receive should enable them
                to become great men</p>
        </div>
        <div class="col-lg-4">
            <h3 class="h3">
                Our Vision</h3>
            <img src="Images/our-vision.jpg" class="img-thumbnail img-rounded img-responsive"
                height="200px" width="200px" />
            <br />
            <br />
            <p>
                Palampur university aims to unlock the talent and enterprise of all our young people.
                We promote high achievement and learning for life by working with every individual
                to value, trust and respect everybody and work together co-operatively. ratively.
            </p>
        </div>
        <div class="col-lg-4">
            <h3 class="h3">
                Principal's Message</h3>
            <img src="Images/Screenshot_20180328-081124.png" class="img-thumbnail img-rounded img-responsive"
                height="200px" width="200px" />
            <br />
            <br />
            <p>
                Palampur university is undoubtedly premier institute of the region which is providing
                quality education resulting in all round development of the child. All the ingredients
                required for imparting quality education is the backbone of RIS. We believe in the
                vision - education is a continuous and creative process
            </p>
        </div>
    </div>
    <br />
    <br />
    <hr />
    <div class="row" style="margin-top: 20px;">
        <div class="col-lg-12">
            <h3 class="h3">
                Awards & Honors
            </h3>
            <marquee behavior="alternate" direction="left" scrollamount="2" onmousemove="stop();"
                onmouseout="start();">
<img src="Images/award12.jpg"  width="200px" height="200px" />
<img src="Images/award13.jpg"  width="200px" height="200px"/>
<img src="Images/award15.jpg"  width="200px" height="200px"/>
<img src="Images/award16.jpg"  width="200px" height="200px"/>
<img src="Images/award17.jpg"  width="200px" height="200px"/>
<img src="Images/award18.jpg"  width="200px" height="200px"/>
        </marquee>
        </div>
    </div>
    <br />
    <br />
   
</asp:Content>
