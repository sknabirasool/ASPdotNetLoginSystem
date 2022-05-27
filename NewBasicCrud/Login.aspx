<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NewBasicCrud.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <hr />
    <h1 class="text-center">Login Form</h1>
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
                        <asp:Button ID="btnLogin" runat="server" Text="LoginUser"  class="btn btn-primary"   OnClick="btnLogin_Click"/>
                    </div>


                    <div class="text-center">
                      <a runat="server" href="~/register.aspx">Register</a>
                    </div>
                </div>
            </div>
        
    </div>

</asp:Content>
