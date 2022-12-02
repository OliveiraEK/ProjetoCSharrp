using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortariaApp
{
    public partial class frmGerenciarCadastros : Form
    {
        public frmGerenciarCadastros()
        {
            InitializeComponent();
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            dgvDadosCadastrais.Rows.Add(txtNome.Text, txtEmail.Text);
           
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            dgvDadosCadastrais.Rows.RemoveAt(dgvDadosCadastrais.CurrentRow.Cells[0].RowIndex);
        }
    }
}
