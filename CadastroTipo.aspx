<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroTipo.aspx.cs" Inherits="WebCpfCnpj.CadastroTipo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Cadastro de Tipos<br />
            <br />
            Descrição:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" />
        <br />
        <asp:GridView ID="GVTipo" runat="server">
        </asp:GridView>
    </form>

</body>
</html>
