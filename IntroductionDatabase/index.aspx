<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="IntroductionDatabase.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="firstNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Middle Name"></asp:Label>
        <asp:TextBox ID="middleNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Phone"></asp:Label>
        <asp:TextBox ID="phoneTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="RegNo"></asp:Label>
        <asp:TextBox ID="regNoTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
        <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
        <br />
    
    </div>
        <asp:GridView ID="studentsGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="First Name">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("FirstName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
      
                
                <asp:TemplateField HeaderText="Middle Name">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("MiddleName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Phone">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Phone") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Registration">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("RegNo") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
