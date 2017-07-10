<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WorkshopASPNet.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Paul's Contact Page</h3>
    <address>
        Level 8, 1 Castlereagh Street<br />
        Sydney, NSW 2000<br />
        <abbr title="Phone">P:</abbr>
        0800 Wrong Number
    </address>

    <address>
        <strong>Email:</strong>   <a href="mailto:Support@example.com">NotPaul@NotGmail.com</a><br />
    </address>
</asp:Content>
