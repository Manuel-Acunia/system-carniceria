using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase.BasedeDatos;

namespace Datos
{
    public partial class frmGastos : Form
    {
        public frmGastos()
        {
            InitializeComponent();
            //Cargar el ComboBox con el Tipo de Gasto
            using (CarniceriaEntities db = new CarniceriaEntities() )
            {
                var lst = db.TipodeGastos.ToList();
                if (lst.Count > 0)
                {
                    cboTipoG.DataSource = lst;
                    cboTipoG.DisplayMember = "NombreGasto";
                    cboTipoG.ValueMember = "ID_TG";

                }
            }
        }

        private void btnConfirmarGasto_Click(object sender, EventArgs e)
        {
            using ( CarniceriaEntities db = new CarniceriaEntities())
            {
                Gastos gasto = new Gastos();

                gasto.FechaGasto = dateGasto.Value;
                gasto.ID_TG = Convert.ToByte(cboTipoG.SelectedValue);
                gasto.Monto = Convert.ToDecimal(txtTotalG.Text);

                db.Gastos.Add(gasto);
                try
                {
                    if (db.SaveChanges() == 1)
                    {
                        MessageBox.Show("Gasto Agregado correctamente...");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //Validacion para que solo acepte números
        private void btnConfirmarGasto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
