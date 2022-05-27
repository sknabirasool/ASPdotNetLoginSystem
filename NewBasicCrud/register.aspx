<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="NewBasicCrud.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <hr />
    <h1 class="text-center">Register Form</h1>
    <hr />


    <div class="container" style="width:50%">
     
            <div class="text-center">
                <div class="row">
                  <div class="form-group">
                    <div class="col-md-6">
                        <asp:Label ID="lbuser" runat="server" Text="UserName"></asp:Label> 
                    </div>  
                     <div class="col-md-6">
                         <asp:TextBox ID="txtUserName" runat="server"  class="form-control"></asp:TextBox>
                    </div>  
                   </div>
                    <br /><br />
                    <div class="form-group">
                    <div class="col-md-6">
                        <asp:Label ID="Label1" runat="server" Text="Email-id"></asp:Label> 
                    </div>  
                     <div class="col-md-6">
                         <asp:TextBox ID="txtEmail" runat="server"  class="form-control"></asp:TextBox>
                    </div>  
                   </div>
                    <br /><br />
                <div class="form-group">
                     <div class="col-md-6">
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label> 
                    </div>  
                     <div class="col-md-6">
                         <asp:TextBox ID="txtPassword" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                    </div>  
                </div>
               </div>
                <br />

                <div class="row">
                    <asp:Label ID="LabelMessage" runat="server" Text="" Style="color:red;text-align:center;"></asp:Label>
                    <div class="text-center">
                        <asp:Button ID="btnRegister" runat="server" Text="Register User"  class="btn btn-primary" OnClick="btnRegister_Click" />
                    </div>
                </div>
            </div>
        
    </div>


</asp:Content>
