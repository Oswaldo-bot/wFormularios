using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wFormularios
//<suma
{
    public partial class MdiParent : Form
    {
        public MdiParent()
        {
            InitializeComponent();
        } 
        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHijo FrmHijo = new FormHijo(); 
            FrmHijo.MdiParent = this; 
            FrmHijo.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmHijo = this.ActiveMdiChild; 
            if (frmHijo != null)
            { frmHijo.Close(); }
        }
    }
}
