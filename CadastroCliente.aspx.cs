using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCpfCnpj
{
    public partial class CadastroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            CpfCnpjEntities1 context = new CpfCnpjEntities1();

            if (CpfCnpjValid(txtCpf.Text))
            {
                sendMessage("CPF Valido");
            }
            else
            {
                sendMessage("CPF Invalido");
                return;
            }

            Cliente cliente = new Cliente()
            {
                nome = txtNome.Text,
                telefone = txtTelefone.Text,
                cidade = txtCidade.Text,
                endereco = txtEndereco.Text,
                cpf = txtCpf.Text
            };

            context.Cliente.Add(cliente);
            context.SaveChanges();
            loadGrid();

        }
        private void loadGrid()
        {
            CpfCnpjEntities1 context = new CpfCnpjEntities1();
            
            GVClientes.DataSource = context.Cliente.ToList<Cliente>();
            GVClientes.DataBind();

        }

        private void sendMessage(string txt)
        {
            lblMsg.Text = txt;
        }

        private Boolean CpfCnpjValid(string cpf)
        {
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string tempCpf;
                string digito;
                int soma;
                int resto;
                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");
                if (cpf.Length != 11)
                    return false;
                tempCpf = cpf.Substring(0, 9);
                soma = 0;

                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = resto.ToString();
                tempCpf = tempCpf + digito;
                soma = 0;
                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = digito + resto.ToString();
                return cpf.EndsWith(digito);
        }
    }
}