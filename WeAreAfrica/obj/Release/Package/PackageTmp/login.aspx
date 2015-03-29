<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WeAreAfrica.login" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ID="loginregister">

	<!-- Container BEGIN -->
	<div class="container-fluid">
    
    	<div class="spacer"></div>

    	<!-- Logo -->
    	<a href="javascript:void(0);"><img class="logo" src="img/WeAreAfrica_W1.png" alt="We Are Africa Logo" /></a>
        
        <!-- Forms BEGIN -->
        <div class="row">
        	<div class="col-md-12">
            	
                <div class="welcomebar">
                    Login
                </div>
                
                <form>
                  <div class="form-group">
                    <label for="exampleInputName"></label>
                    <input type="email" class="form-control" id="l_firstname" placeholder="Enter name">
                      <p class="text-danger validationMessages l_firstname redcolor">Name is required</p>
                  </div>
                  <div class="form-group">
                    <label for="exampleInputPassword1"></label>
                    <input type="password" class="form-control" id="l_password" placeholder="Password">
                      <p class="text-danger validationMessages l_password redcolor">Password is required</p>
                  </div>
                  <button type="button" class="btn btn-default submitLogin">Login</button>
                    <label class="text-danger invalidloginpasswordMessage redcolor">Invalid Credentials</label>
                    <label class="text-primary loginvalidation">Validating credentials ...</label>
                    <label class="text-primary validCredantials">Credentials valid<br />Login you in ...</label>

                </form>
                                
                <div class="heading h5" style="color:#fff;">OR</div>
                
                <div class="welcomebar">
                    REGISTER
                </div>
                
                <form>
                  <div class="form-group">
                    <label for="exampleInputName"></label>
                    <input type="name" class="form-control" id="firstname" placeholder="Enter name">
                      <p class="text-danger validationMessages firstname">Name is required</p>
                  </div>
                  <div class="form-group">
                    <label for="exampleInputEmail1"></label>
                    <input type="email" class="form-control" id="email" placeholder="Enter email">
                      <p class="text-danger validationMessages email">Name is required</p>
                  </div>
                  <div class="form-group">
                    <label for="eexampleInputMobile"></label>
                    <input type="mobile" class="form-control" id="telephone" placeholder="Number">
                       <p class="text-danger validationMessages telephone">Cellphone number is required</p>
                  </div>
                  <div class="form-group">
                    <label for="exampleInputPassword1"></label>
                    <input type="password" class="form-control" id="password" placeholder="Password">
                      <p class="text-danger validationMessages password">Password is required</p>
                  </div>
                  
                  <button type="button" class="btn btn-default submitRegistration">Register</button><label class="text-primary registeringMessage"> Registering ...</label>
                    <label class="text-primary successfullyregisteredMessage">Successfully registered!!<br />Loggin you in</label>
                    <label class="text-danger emailAlreadyExists">Email address already exists</label>

                </form>

            </div>
         </div>   
        <!-- Forms END -->
                
        <div class="spacer"></div>
        
    </div>
    <!-- Container END -->
</asp:Content>