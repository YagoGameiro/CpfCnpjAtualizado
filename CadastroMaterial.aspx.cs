using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCpfCnpj
{
    public partial class CadastroMaterial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CpfCnpjEntities1 context = new CpfCnpjEntities1();
                txtTipo.DataSource = context.Tipo.ToList<Tipo>();
                txtTipo.DataTextField = "Descricao";
                txtTipo.DataValueField = "Id";
                txtTipo.DataBind();
                txtFornecedor.DataSource = context.Fornecedor.ToList<Fornecedor>();
                txtFornecedor.DataTextField = "Nome";
                txtFornecedor.DataValueField = "Id";
                txtFornecedor.DataBind();
                loadGrid();
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            CpfCnpjEntities1 context = new CpfCnpjEntities1();

            Material material = new Material()
            {
                descricao = txtDescricao.Text,
                dataEntrada = DateTime.UtcNow,
                tipo = int.Parse(txtTipo.SelectedValue.ToString()),
                valor = int.Parse(txtValor.Text),
                fornecedor = int.Parse(txtFornecedor.SelectedValue.ToString())
            };

            context.Material.Add(material);
            context.SaveChanges();
            loadGrid();
            sendMessage("Registro Inserido");
        }

        private void sendMessage(string txt)
        {
            lblMsg.Text = txt;
        }

        private void loadGrid()
        {
            CpfCnpjEntities1 context = new CpfCnpjEntities1();

            GVMaterial.DataSource = context.Material.ToList<Material>();
            GVMaterial.DataBind();
        }
    }
}