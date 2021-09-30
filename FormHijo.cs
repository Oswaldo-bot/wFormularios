using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/// <summary>
/// Oswaldo Duran
/// Fecha 29/2020/09
/// </summary>


namespace wFormularios
{
    public partial class FormHijo : Form
    {
        public FormHijo()
        { 
            InitializeComponent();
        }

        private void FormHijo_Load(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog().Equals(DialogResult.OK))
                {
                    Stream strGuardar = saveFileDialog.OpenFile();
                    StreamWriter wrtGuardar = new StreamWriter(strGuardar);

                    foreach (string linea in txtContenido.Lines)
                    { wrtGuardar.WriteLine(linea); }
                    wrtGuardar.Close();
                }
            }
            catch (Exception ex) 
            { MessageBox.Show(ex.Message);
            }
        }
    }
}
