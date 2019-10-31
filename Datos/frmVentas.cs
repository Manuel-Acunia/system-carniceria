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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            txtVenta.Focus();
        }

        private void labelMayorVenta_Click(object sender, EventArgs e)
        {

        }

        //Variables para el control de VentaTotalDia, Tarjeta y Cantidad de ventas
        private Int16 cant_venta = 0;
        private double ventaTarjeta=0;
        private double ventaTotalDia=0;

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtVenta.Text == "")
            {
                MessageBox.Show("Debe Ingresar un número");
            }
            else
            {
                //Aumento de las ventas del dia
                cant_venta++;

                //Agrego el monto al listbox
                lstbVentas.Items.Add(txtVenta.Text);

                //Convierto el valor ingresado en el txtVenta para luego utilizarlo
                double a = Convert.ToDouble(txtVenta.Text);
                
                //Asigno el valor de a, a la variable ventaTotalDia y luego lo muestro en el label
                ventaTotalDia += a;
                labelVentaDia.Text = ventaTotalDia.ToString();


                if (chckTarjeta.Checked == true)
                {
                    
                    ventaTarjeta += a;
                    labelVentaConTarjeta.Text = ventaTarjeta.ToString();
                    chckTarjeta.Checked = false;
                }

                txtVenta.Clear();
                txtVenta.Focus();
            }
        }

        //Validación para que no admita letras ni espacios y para que al presionar enter, se active el boton confirmar
        private void txtVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar== (char)Keys.Enter)
            {
                e.Handled = true;
                btnConfirmar_Click(sender, e);
            }
           
        }

        //Agregar La venta a base de datos
        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
           
                CarniceriaEntities db = new CarniceriaEntities();
                
                    Ventas venta = new Ventas();

                    venta.Cant_Ventas = Convert.ToByte(cant_venta);
                    venta.Fecha = DateTimeVenta.Value;
                    venta.Tot_Tarjeta = Convert.ToDecimal(ventaTarjeta);
                    venta.Tot_Venta = Convert.ToDecimal(ventaTotalDia);

                     db.Ventas.Add(venta);

            try
            {
                if (db.SaveChanges() == 1)
                {
                    MessageBox.Show("Datos agregados correctamente...");
                }
                
               
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido insertar correctamente");
                
            }
                
         
            
        }

       
    }
}
