using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCpfCnpj
{
    public partial class CadastroTipo : System.Web.UI.Page
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

            Tipo tipo = new Tipo()
            {
                descricao = txtDescricao.Text
            };

            context.Tipo.Add(tipo);
            context.SaveChanges();
            loadGrid();
        }

        private void loadGrid()
        {
            CpfCnpjEntities1 context = new CpfCnpjEntities1();

            GVTipo.DataSource = context.Tipo.ToList<Tipo>();
            GVTipo.DataBind();
        }
    }
}