using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleBar.Telas
{
    public partial class FrmFiado : Form
    {
        public FrmFiado()
        {
            InitializeComponent();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
            txtCpf.Text = String.Empty;
            txtCep.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            dtpData.Value = DateTime.Now;
        }
    }
}
