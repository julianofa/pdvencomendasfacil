using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdvencomendasfacil
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Configura o form principal como MdiContainer 
            this.IsMdiContainer = true;

            //Cria uma nova instância de um MDI template form.
            Form2 chForm = new Form2();

            //Configura o form como janela filha 
            chForm.MdiParent = this;

            //Mostra janela filha.
            chForm.Show();
        }
    }
}
