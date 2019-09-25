using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCpfCnpj
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadGrid();
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            CpfCnpjEntities1 context = new CpfCnpjEntities1();

            if (CpfCnpjValid(txtCnpj.Text))
            {
                sendMessage("CNPJ Valido");
            }
            else
            {
                sendMessage("CNPJ Invalido");
                return;
            }

            Fornecedor fornecedor = new Fornecedor()
            {
                nome = txtNome.Text,
                telefone = txtTelefone.Text,
                cidade = txtCidade.Text,
                endereco = txtEndereco.Text,
                cnpj = txtCnpj.Text
            };

            context.Fornecedor.Add(fornecedor);
            context.SaveChanges();
            loadGrid();
        }
        private void loadGrid()
        {
            CpfCnpjEntities1 context = new CpfCnpjEntities1();

            GVFornecedor.DataSource = context.Fornecedor.ToList<Fornecedor>();
            GVFornecedor.DataBind();
        }

        private void sendMessage(string txt)
        {
            lblMsg.Text = txt;
        }

        private Boolean CpfCnpjValid(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
    }
}