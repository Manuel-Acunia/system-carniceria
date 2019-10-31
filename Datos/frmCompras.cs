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
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();

            cboProveedor.Focus();

            //Cargar Combobox (Averiguar una manera de hacerlo mejor)
            using (CarniceriaEntities con = new CarniceriaEntities())
            {
                var lst = con.Proveedores.ToList();
                if (lst.Count > 1)
                {
                    cboProveedor.DataSource = lst;
                    cboProveedor.DisplayMember = "Nombre";
                    cboProveedor.ValueMember = "ID_Prov";
                }
           
                var lista = con.Cortes.ToList();
                if (lista.Count > 1)
                {
                    cboTipoCorte.DataSource = lista;
                    cboTipoCorte.DisplayMember = "Corte";
                    cboTipoCorte.ValueMember = "ID_Corte";
                }
            }
        }

        

        //Agregar compra a la base de datos
        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {

            if (txtTotal.Text != "")
            {
                using (CarniceriaEntities com = new CarniceriaEntities())
                {

                    Compras compra = new Compras();

                    compra.FechaCompra = dateCompras.Value;
                    compra.ID_Prov = Convert.ToByte(cboProveedor.SelectedValue);
                    compra.ID_Corte = Convert.ToByte(cboTipoCorte.SelectedValue);
                    compra.Cantidad = Convert.ToByte(txtCantidad.Text);
                    compra.PrecioCompra = Convert.ToDecimal(txtcPrecio.Text);
                    compra.Peso = Convert.ToInt16(txtPeso.Text);
                    compra.PrecioCompra = Convert.ToInt16(txtcPrecio.Text);
                    compra.Total = Convert.ToDecimal(txtTotal.Text);



                    com.Compras.Add(compra);



                    //Si fue exitoso, muestro mensaje
                    try
                    {
                        if (com.SaveChanges() == 1)
                        {

                            MessageBox.Show("Compra Realizada correctamente...");
                            txtCantidad.Clear();
                            txtcPrecio.Clear();
                            txtPeso.Clear();
                            txtTotal.Clear();
                            txtCantidad.Focus();
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }


            }
            else
            {
                MessageBox.Show("Debe Ingresar Precio y Total", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Validacion para que solo acepte números

        private void Validador(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador(sender, e);
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador(sender, e);
        }

        private void txtcPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador(sender, e);
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador(sender, e);
        }
    }
}
