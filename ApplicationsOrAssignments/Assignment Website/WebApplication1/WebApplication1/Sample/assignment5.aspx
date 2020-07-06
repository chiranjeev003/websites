<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assignment5.aspx.cs" Inherits="WebApplication1.Sample.assignment5" MasterPageFile="~/Assignment6.master" %>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ID="page1">

    <form id="form1" runat="server">
        <div>

            <asp:Table ID="Table1" runat="server" Width="100%" Style="margin-top: 3vh; background-color: beige;">
                <asp:TableHeaderRow>
                    <asp:TableCell colspan="2" Style="text-align: center; font-weight: 500; font-size: 30px; padding-top: 30px;">Assignment 5</asp:TableCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell CssClass="cell-left" Style="text-align: right;">
                        <asp:Label ID="Label1" runat="server" Text="First Name <span style='color:red'>*</span> :- "></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell CssClass="cell-right" Style="text-align: left;">
                        <asp:TextBox CssClass="InputField" ID="TextBox1" runat="server" placeholder="Please enter your first name"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please fill in your first name." Font-Size="Medium" Display="Dynamic" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell CssClass="cell-left" Style="text-align: right;">
                        <asp:Label ID="Label2" runat="server" Text="Last Name :-"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell CssClass="cell-right" Style="text-align: left;">
                        <asp:TextBox CssClass="InputField" ID="TextBox2" runat="server" placeholder="Please enter your last name"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell CssClass="cell-left" Style="text-align: right;">
                        <asp:Label ID="Label3" runat="server" Text="Department :- "></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell CssClass="cell-right" Style="text-align: left;">
                        <asp:DropDownList CssClass="InputField" ID="DropDownList1" runat="server">
                            <asp:ListItem Value="Nothing Selected">--Select Department--</asp:ListItem>
                            <asp:ListItem Value="Computer Science">Computer Science</asp:ListItem>
                            <asp:ListItem Value="Chemical">Chemical</asp:ListItem>
                            <asp:ListItem Value="Electrical">Electrical</asp:ListItem>
                            <asp:ListItem Value="Automobile">Automobile</asp:ListItem>
                            <asp:ListItem Value="MCA">MCA</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell CssClass="cell-left" Style="text-align: right;">
                        <asp:Label ID="Label4" runat="server" Text="Email Id <span style='color:red'>*</span> :-"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell CssClass="cell-right" Style="text-align: left;">
                        <asp:TextBox CssClass="InputField" ID="TextBox4" runat="server" placeholder="Please enter email id"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Email Id" ViewStateMode="Inherit" ControlToValidate="TextBox4" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please Enter Correct Email Id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="TextBox4" ForeColor="Red"></asp:RegularExpressionValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell CssClass="cell-left" Style="text-align: right;">
                        <asp:Label ID="Label5" runat="server" Text="Password  <span style='color:red'>*</span> :-"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell CssClass="cell-right" Style="text-align: left;">
                        <asp:TextBox CssClass="InputField" ID="TextBox5" TextMode="Password" runat="server" placeholder="Choose a password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Enter a Password" Display="Dynamic" ForeColor="Red" ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell CssClass="cell-left" Style="text-align: right;">
                        <asp:Label ID="Label6" runat="server" Text="Confirm Password <span style='color:red'>*</span> :-"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell CssClass="cell-right" Style="text-align: left;">
                        <asp:TextBox CssClass="InputField" ID="TextBox6" runat="server" placeholder="Enter the password again" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please Enter The Password again" Display="Dynamic" ForeColor="Red" ControlToValidate="TextBox6"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords Do not match." Display="Dynamic" ControlToCompare="TextBox5" ControlToValidate="TextBox6" ForeColor="Red"></asp:CompareValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2" Style="text-align: center;">
                        <span style="color:red">Note</span>:- All fields marked in <span style="color:red">*</span>  are mandatory to fill.
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableFooterRow>
                    <asp:TableCell ColumnSpan="2" Style="text-align: center; padding-bottom: 30px; padding-top: 10px;">
                        <asp:Button ID="ButtonSubmit" runat="server" OnClick="ButtonSubmit_Click" Text="Submit" Font-Bold="true" Font-Size="Large" Style="padding: 5px; padding-left: 20px; padding-right: 20px; border: ridge 4px darkgrey; background-color: darkslategrey; color: white;" />
                    </asp:TableCell>
                </asp:TableFooterRow>
            </asp:Table>
        </div>
    </form>

</asp:Content>
