<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WeAreAfrica._default" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" ID="welcomepage" runat="server">


	<!-- Container BEGIN -->
	<div class="container-fluid">
    
    	<!-- 2 Top Buttons BEGIN -->
        <div class="row">
        	<div class="col-md-12 toplinks">
            
            	<div class="col-xs-6 col-md-6">
                	<a href="/login"><button type="button" class="btn btn-link" style="float:left">Get Started</button></a>
                </div>
                
<%--                <div class="col-xs-6 col-md-6">
                	<a href="home.html"><button type="button" class="btn btn-link" style="float:right">Skip</button></a>
                </div>--%>
            	
            </div>
        </div>
        <!-- 2 Top Buttons END -->
    
    	<!-- Logo -->
    	<a href="javascript:void(0);"><img class="logo" src="img/WeAreAfrica_W1.png" alt="We Are Africa Logo" /></a>
        
        <!-- Welcome Message BEGIN -->
        <div class="row">
        	<div class="col-md-12">
            	
                <div class="welcomebar">
                    Welcome to Africa Month
                </div>
                
                <p>Connect your networks to use our social features</p>
                <div class="heading">#WEAREAFRICA</div>

            </div>
         </div>   
        <!-- Welcome Message END -->
        
        <!-- Social BEGIN -->
        <div class="row">
        
        	<div class="socialarea">
                <a class="socialicons" href="#"><i class="fa fa-facebook-square"></i></a>
            	<a class="socialicons" href="#"><i class="fa fa-twitter-square"></i></a>
            	<a class="socialicons" href="#"><i class="fa fa-instagram"></i></a>
            </div>
        
        </div>
        <!-- Social BEGIN -->
        
        <div class="spacer"></div>
        
    </div>
    <!-- Container END -->


</asp:Content>