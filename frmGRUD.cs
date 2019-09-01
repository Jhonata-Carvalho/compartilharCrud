using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class frmGRUD : Form
    {
        public frmGRUD()
        {
            InitializeComponent();
        }

        private void frmGRUD_Load(object sender, EventArgs e)
        {
            dgv.DataSource = ClsGrud.Consultar();
        }
        private void Preencherdgv(List<ClsGrud> lista)
        {
            dgv.DataSource = new BindingList<ClsGrud>(lista);
        }
        private void LimpaTextBox()
        {
            txtid.Text = "";
            txtcliente.Text = "";
            txtpedido.Text = "";
            txtquantde.Text = "";
            txtvalor.Text = "";
            txttotal.Text = "";
        }
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            txtcliente.Focus();
            if (txtid.Text.Length == 0)
            {
                ClsGrud aux = new ClsGrud(
                    txtcliente.Text, txtpedido.Text, int.Parse(txtquantde.Text), float.Parse(txtvalor.Text),
                    float.Parse(txttotal.Text = Convert.ToString(int.Parse(txtquantde.Text) * float.Parse(txtvalor.Text))));
                aux.Inserir();
            }
            else
            {
                ClsGrud aux = new ClsGrud(int.Parse(txtid.Text),
                    txtcliente.Text, txtpedido.Text, int.Parse(txtquantde.Text), float.Parse(txtvalor.Text),
                    float.Parse(txttotal.Text = Convert.ToString(int.Parse(txtquantde.Text) * float.Parse(txtvalor.Text))));
                aux.Alterar();
            }
            Preencherdgv(ClsGrud.Consultar());
            LimpaTextBox();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            Preencherdgv(ClsGrud.Consultar(txtcliente_pesquisar.Text));
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = (int)dgv["ID", e.RowIndex].Value;
            ClsGrud aux = new ClsGrud(id);
            txtid.Text = aux.ID.ToString();
            txtcliente.Text = aux.CLIENTE;
            txtpedido.Text = aux.PEDIDO;
            txtquantde.Text = aux.QUANTIDADE.ToString();
            txtvalor.Text = aux.PREÇO.ToString();
            txttotal.Text = aux.TOTAL.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            LimpaTextBox();
        }
    }
}
