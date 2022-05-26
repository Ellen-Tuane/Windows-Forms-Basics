using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_menus
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void cadastrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fmrUsuarioCadastro == null || frmUsuarioCadastro.ActiveControl == null)
            {
                fmrUsuarioCadastro = new FrmUsuarioCadastro();
                frmUsuarioCadastro.MdiParent = this;
                frmUsuarioCadastro.Show();
            }
            else
            {
                fmrUsuarioCadastro.show();
            }
        }
    }
}
