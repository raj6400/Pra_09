<%@ Page Title="Company Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CompanyDetails.aspx.cs" Inherits="Prac_9.CompanyDetails" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Company Placement Statistics</h2>
    <hr />

    <p>
        <asp:HyperLink ID="lnkBack" runat="server" NavigateUrl="~/Default.aspx">&larr; Back to Dashboard</asp:HyperLink>
    </p>

    <h3>Hiring Summary by Company</h3>
    <asp:GridView ID="gvCompanySummary" runat="server" AutoGenerateColumns="true" CellPadding="6" GridLines="Both">
    </asp:GridView>

    <br />

    <h3>All Placed Students List</h3>
    <asp:GridView ID="gvPlacedStudents" runat="server" AutoGenerateColumns="true" CellPadding="6" GridLines="Both">
    </asp:GridView>
</asp:Content>