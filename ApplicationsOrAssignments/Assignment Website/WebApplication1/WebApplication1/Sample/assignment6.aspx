<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assignment6.aspx.cs" Inherits="WebApplication1.Sample.assignment6" MasterPageFile="~/Assignment6.master" %>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ID="page2">

    <form id="form2" runat="server">
        <asp:Table ID="Table1" runat="server" Style="background-color: beige; margin-top: 9vh; margin-bottom: 16vh;">
            <asp:TableHeaderRow>
                <asp:TableCell ColumnSpan="2" Style="text-align: center; font-size: 30px; font-weight: 600; padding-top: 30px;">User Details</asp:TableCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
                <asp:TableCell CssClass="cell-left">
                    <asp:Label ID="Label1" runat="server" Text="Your First Name is :- "></asp:Label>
                </asp:TableCell>
                <asp:TableCell CssClass="cell-right">
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell CssClass="cell-left">
                    <asp:Label ID="Label3" runat="server" Text="Your Last Name is :- "></asp:Label>
                </asp:TableCell>
                <asp:TableCell CssClass="cell-right">
                    <asp:Label ID="Label4" runat="server" Text="No input provided."></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell CssClass="cell-left">
                    <asp:Label ID="Label5" runat="server" Text="Your Department is :- "></asp:Label>
                </asp:TableCell>
                <asp:TableCell CssClass="cell-right">
                    <asp:Label ID="Label6" runat="server" Text="No input provided."></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell CssClass="cell-left">
                    <asp:Label ID="Label7" runat="server" Text="Your Email ID is :- "></asp:Label>
                </asp:TableCell>
                <asp:TableCell CssClass="cell-right">
                    <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell CssClass="cell-left">
                    <asp:Label ID="Label9" runat="server" Text="Your password is :- "></asp:Label>
                </asp:TableCell>
                <asp:TableCell CssClass="cell-right">
                    <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableFooterRow>
                <asp:TableCell ColumnSpan="2" Style="text-align: center; margin-top: 30px; padding-bottom: 30px;">
                    <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Go Back To Main Page" Font-Bold="true" Font-Size="Large" Style="padding: 5px; padding-left: 20px; padding-right: 20px; border: ridge 4px darkgrey; background-color: darkslategrey; color: white;" />
                </asp:TableCell>
            </asp:TableFooterRow>
        </asp:Table>
    </form>

</asp:Content>
