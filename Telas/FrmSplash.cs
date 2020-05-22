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
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void Splash_Tick(object sender, EventArgs e)
        {           
            FrmLogin tela = new FrmLogin();
            tela.Show();

            Splash.Stop();
            Hide();
        }
    }
}
