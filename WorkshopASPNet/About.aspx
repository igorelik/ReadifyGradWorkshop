<%@ Page Title="About Kael" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WorkshopASPNet.About" %>

<%--  These things are server side elements. Essentially string replacements.--%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Kael Larkin</h3>
    <p>Graduate Mechatronic Engineer.</p>
    <p>Likes olives.</p>
</asp:Content>
