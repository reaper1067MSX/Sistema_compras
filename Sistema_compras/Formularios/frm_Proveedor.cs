using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_compras.Formularios
{
    public partial class frm_Proveedor : Form
    {
        public frm_Proveedor()
        {
            InitializeComponent();
        }

        private void frm_Proveedor_Load(object sender, EventArgs e)
        {
            tss_lbl_fecha.Text = DateTime.Now.ToString();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     

       
    }
}
