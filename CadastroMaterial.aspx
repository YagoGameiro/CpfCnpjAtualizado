<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroMaterial.aspx.cs" Inherits="WebCpfCnpj.CadastroMaterial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 242px;
        }
    </style>
</head>
<body>
    <h2>Cadastro de Material</h2>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </p>
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">
                        Descrição</td>
                    <td>
                        <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        Tipo</td>
                    <td>
                        <asp:DropDownList ID="txtTipo" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        Valor</td>
                    <td>
                        <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">
                        Fornecedor</td>
                    <td>
                        <asp:DropDownList ID="txtFornecedor" runat="server" >
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
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
            <asp:GridView ID="GVMaterial" runat="server">
            </asp:GridView>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
