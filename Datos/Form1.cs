using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public partial class formBase : Form
    {
        public formBase()
        {
            InitializeComponent();
        }
        //Sombra a la ventana
        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        } 

        
        //BOTON SALIR
        private void pbxSalir_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("Seguro que desea salir?...", "SALIR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (salir == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        //BOTON MINIMIZAR
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Metodo para llamar forms
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnlContenedor.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la coleccion el formulario
            //Si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                pnlContenedor.Controls.Add(formulario);
                pnlContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //Si existe el formulario o instancia
            else
            {
                formulario.BringToFront();
            }
        }

        //Apertura de formularios
        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmVentas>();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCompras>();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormReportes>();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmGastos>();
        }
    }
}
