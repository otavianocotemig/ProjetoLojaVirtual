using ProjetoLojaVirtual.BLL;
using ProjetoLojaVirtual.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLojaVirtual
{
    public partial class FrmLogin : Form
    {
        tblClienteBLL bllcliente = new tblClienteBLL();
        tblClienteDTO dtoCliente = new tblClienteDTO();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                dtoCliente.Email_cliente = txtEmail.Text;
                dtoCliente.Senha_cliente = txtSenha.Text;

                if (bllcliente.Autenticar(dtoCliente.Email_cliente,dtoCliente.Senha_cliente) == false)
                {
                    MessageBox.Show("Erro: Cliente não Localizado.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Acesso Liberado.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
