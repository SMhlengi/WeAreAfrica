<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WeAreAfrica.home" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" ID="homepage" runat="server">

	<!-- Container BEGIN -->
	<div class="container-fluid">
    
    	<div class="spacer"></div>

    	<!-- Logo -->
    	<a href="home.html"><img class="logo" src="img/WeAreAfrica_W1.png" alt="We Are Africa Logo" /></a>
        
        <div class="spacer"></div>
        
        <!-- Navigation BEGIN -->
        <div class="row">
        	<div class="col-md-12">
            	
                <div class="col-xs-6 col-md-6">
                    <button type="button" disabled class="btn btn-default btn-lg naviconsleft inactive">
                    	<span class="glyphicon glyphicon-globe" aria-hidden="true"></span>
                        <br />
                        <h5>Social Media</h5>
                    </button>
                    
                    <button type="button" disabled class="btn btn-default btn-lg naviconsleft inactive">
                    	<span class="glyphicon glyphicon-calendar" aria-hidden="true"></span>
                        <br />
                        <h5>Africa Day</h5>
                    </button>
                    
                    <button type="button" disabled class="btn btn-default btn-lg naviconsleft inactive">
                    	<span class="glyphicon glyphicon-bullhorn" aria-hidden="true"></span>
                        <br />
                        <h5>Talks</h5>
                    </button>
                    
                </div>
            	
                <div class="col-xs-6 col-md-6">
                	<button type="button" disabled class="btn btn-default btn-lg naviconsright inactive">
                      <span class="glyphicon glyphicon-music" aria-hidden="true"></span>
                      <br />
                      <h5>Africa Song</h5>
                    </button>
                    
                    <button type="button" disabled class="btn btn-default btn-lg naviconsright inactive">
                      <span class="glyphicon glyphicon-list-alt" aria-hidden="true"></span>
                      <br />
                          <h5>Programmes</h5>
                    </button>
                    
                    <a href="/news">
                    <button type="button" class="btn btn-default btn-lg naviconsright">
                      <span class="glyphicon glyphicon-th" aria-hidden="true"></span>
                      <br />
                          <h5>News</h5>
                    </button>
                    </a>
                </div>
                
                
                
            </div>
         </div>   
        <!-- Navigation END -->
                
        <div class="spacer"></div>
        
    </div>
    <!-- Container END -->



</asp:Content>