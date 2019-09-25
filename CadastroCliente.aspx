<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroCliente.aspx.cs" Inherits="WebCpfCnpj.CadastroCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 114px;
        }
    </style>
</head>
<body>
    <h2>Cadastro de Clientes</h2>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </p>
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblTelefone" runat="server" Text="Telefone"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblCidade" runat="server" Text="Cidade"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCidade" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblEndereco" runat="server" Text="Endereco"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblCpf" runat="server" Text="CPF"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            <br />
            <br />
            <br />
            <asp:GridView ID="GVClientes" runat="server">
            </asp:GridView>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
