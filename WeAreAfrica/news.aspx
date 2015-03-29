<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="news.aspx.cs" Inherits="WeAreAfrica.news" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ID="news">

	<!-- Container BEGIN -->
	<div class="container-fluid">
    
    	<!-- Back Button BEGIN -->
        <div class="row">
        	<div class="col-md-12 toplinks">
            
            	<div class="col-xs-6 col-md-6">
                	
                	<a href="home.html"><button type="button" class="btn btn-link" style="float:left"><span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>Back</button></a>
                </div>
                            	
            </div>
        </div>
        <!-- Back Button END -->
    
    	<!-- Logo -->
    	<a href="home.html"><img class="logosmlright" src="img/WeAreAfrica_W1.png" alt="We Are Africa Logo" /></a>
        
        <!-- News BEGIN -->
        <div class="row">
        	<div class="col-md-12">
            	
                <div class="pagetitle">News</div>
                                
                <div class="newsarticleheading">Article Heading</div>
                
                <div class="newsarticletext">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore...
                </div>
                <button type="button" id="newslinks" class="btn btn-default">
                	Read more
                    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                </button>
                
                <div class="newsarticleheading">Article Heading</div>
                
                <div class="newsarticletext">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore...
                </div>
                <button type="button" id="newslinks" class="btn btn-default">
                	Download
                    <span class="glyphicon glyphicon-download-alt" aria-hidden="true"></span>
                </button>
                
                <div class="newsarticleheading">Article Heading</div>
                
                <div class="newsarticletext">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore...
                </div>
                <button type="button" id="newslinks" class="btn btn-default">
                	Read more
                    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                </button>
                

            </div>
         </div>   
        <!-- News END -->
       
        <div class="spacer"></div>
        
    </div>
    <!-- Container END -->

</asp:Content>