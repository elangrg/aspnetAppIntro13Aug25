<%@ Page Language="C#" UnobtrusiveValidationMode ="none"  AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="aspnetAppIntro13Aug25.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <p> Web Server Control</p>
            <asp:Label ID="lblMsg" runat="server" Text="..."></asp:Label>
            <asp:TextBox ID="txtWebSvrCtr" runat="server"></asp:TextBox>
            
        <p> HTML Control</p>
            <input type="text" name="txtHtmlControl" value="" />
            <p> HTML Server Control</p>
           <input type="text" name="txtHtmlSvrControl" id="txtHtmlSvrControl" runat="server" value="" />
            <asp:DropDownList ID="cmbNames" runat="server" ViewStateMode="Disabled"></asp:DropDownList>
            
        
            <asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Emp Name is Required" ControlToValidate="txtEmpName"></asp:RequiredFieldValidator>
            
            <asp:Button ID="btnSubmit" runat="server" Text="Click" OnClick="btnClick" />
        
        
        
        
        </div>
        <div>
            <asp:GridView runat="server" DataSourceID="SqlDataSource1" ID="dgdPhy" AutoGenerateColumns="False" DataKeyNames="physicianID">
                <Columns>
                    <asp:BoundField DataField="physicianID" HeaderText="physicianID" ReadOnly="True" InsertVisible="False" SortExpression="physicianID"></asp:BoundField>
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name"></asp:BoundField>
                    <asp:BoundField DataField="Specialisation" HeaderText="Specialisation" SortExpression="Specialisation"></asp:BoundField>
                    <asp:BoundField DataField="contact" HeaderText="contact" SortExpression="contact"></asp:BoundField>
                    <asp:BoundField DataField="email" HeaderText="email" SortExpression="email"></asp:BoundField>
                    <asp:BoundField DataField="address" HeaderText="address" SortExpression="address"></asp:BoundField>
                    <asp:BoundField DataField="regNO" HeaderText="regNO" SortExpression="regNO"></asp:BoundField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:ClinicDbConnectionString %>" ProviderName="<%$ ConnectionStrings:ClinicDbConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [physicians]"></asp:SqlDataSource>
            &nbsp;</div>
    </form>
</body>
</html>
