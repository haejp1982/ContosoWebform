<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPerson.aspx.cs" Inherits="ContosoWeb.People.AddPerson" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
    <label for="txtFirstName">FirstName</label>
    <%--<input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email">--%>
        <asp:TextBox runat="server" ID ="txtFirstName" CssClass ="form-control"/>
  </div>
   

  <div class="form-group">
    <label for="exampleInputPassword1">Password</label>
    <input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">
  </div>
  <div class="form-group">
    <label for="">State</label>
      <asp:DropDownList runat="server" ID ="ddlStates">
      </asp:DropDownList>
      <%--<asp:TextBox runat="server" ID ="TextBox1" CssClass ="form-control"/>--%>
  </div>

    <asp:Button Text="SavePerson" runat="server" ID="btnSave" OnClick="btnSave_Click" />
</asp:Content>
