<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="news.aspx.cs" Inherits="WeAreAfrica.news" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ID="news">
    <style>
        a {
	        font-size:17px !important;
        }

        form {
            width:350px;
            margin-left:13%;
        }

        @media (max-width: 769px) {
            form {
	            width:350px;
                margin-left:0%;
                padding: 0;
            }
        }

    </style>

	<!-- Container BEGIN -->
	<div class="container-fluid">
        
    
    	<!-- Back Button BEGIN -->
        <div class="row">
        	<div class="col-md-12 toplinks">
            
            	<div class="col-xs-6 col-md-6">
                	
                	<a href="/home"><button type="button" class="btn btn-link" style="float:left"><span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>Back</button></a>
                </div>
                            	
            </div>
        </div>
        <!-- Back Button END -->
    
    	<!-- Logo -->
    	<a href="/home"><img class="logosmlright" src="img/WeAreAfrica_W1.png" alt="We Are Africa Logo" /></a>
        
        <!-- News BEGIN -->
        <div class="row">
        	<div class="col-md-12">
            	
                <div class="pagetitle">News</div>
                                
                <%--<div class="newsarticleheading">Article Heading</div>
                
                <div class="newsarticletext">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore...
                </div>
                <button type="button" id="newslinks" class="btn btn-default">
                	Read more
                    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                </button>--%>
                
                <div class="newsarticleheading">Article Heading</div>
                
                <div class="newsarticletext">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore...
                </div>
                
                <form id="form" runat="server">
                    <%--<asp:Button ID="newslinks" CssClass="btn btn-default" runat="server" Text="Download" OnClick="download_Click" ClientIDMode="Static" />--%>
                    <asp:LinkButton ID="newslinks" ClientIDMode="Static" CssClass="btn btn-default" runat="server" OnClick="newslinks_Click">Download <span class="glyphicon glyphicon-download-alt" aria-hidden="true"></span></asp:LinkButton>
                    
                </form>
<%--                <div class="newsarticleheading">Article Heading</div>
                
                <div class="newsarticletext">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore...
                </div>
                <button type="button" id="newslinks" class="btn btn-default">
                	Read more
                    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                </button>--%>
                

            </div>
         </div>   
        <!-- News END -->
       
        <div class="spacer"></div>

    </div>
    <!-- Container END -->

</asp:Content>