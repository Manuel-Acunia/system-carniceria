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
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
            //Habilito el Multiselect para poder seleccionar las celdas del DataGridView
            dtgvReportes.MultiSelect = true;
        }
        //Mostrar todas las ventas
        private void btnrVentas_Click(object sender, EventArgs e)
        {
            using (DataBase.BasedeDatos.CarniceriaEntities dbc = new DataBase.BasedeDatos.CarniceriaEntities())
            {
                var vgral = from vg in dbc.Ventas.AsNoTracking()
                            select new { vg.Fecha, CantidadVentas = vg.Cant_Ventas, Tarjeta = vg.Tot_Tarjeta, TotalDia = vg.Tot_Venta };

                dtgvReportes.DataSource = vgral.ToList();
                
            }
            
            
        }
        //Ordenar Ventas por mes
        private void btnrVentasMes_Click(object sender, EventArgs e)
        {
            using (DataBase.BasedeDatos.CarniceriaEntities db = new DataBase.BasedeDatos.CarniceriaEntities())
            {
                var vm = from vta in db.Ventas.AsNoTracking()
                         .GroupBy(venta => new { Mes = venta.Fecha.Month, Año = venta.Fecha.Year })
                         .Select(grupo => new { fecha = grupo.Key, Total = grupo.Sum(venta => venta.Tot_Venta) })
                         .OrderBy(result => result.fecha.Año)
                         .ThenBy(result => result.fecha.Mes)
                         select vta;


                dtgvReportes.DataSource = vm.ToList();
            }
        }

        //Seleccionar Ventas en DataGridView
        private void btnrVentasSemana_Click(object sender, EventArgs e)
        {
            int cellSelected;
            double tot = 0;
            double value;
            //Obtenemos la cantidad de celdas seleccionadas por el usuario.
            cellSelected = dtgvReportes.GetCellCount(DataGridViewElementStates.Selected);
            for (int i = 0; i != cellSelected; ++i)
            {
                //Detectamos si la celda seleccionada pertenece a la columna Total.
                if (dtgvReportes.SelectedCells[i].ColumnIndex != 3)
                {
                    MessageBox.Show("Solo puedes seleccionar celdas de la columna Total.");
                    return;
                }
                //Obtenemos el valor actual de esa celda y la convertimos en tipo double. 
                value = Convert.ToDouble(dtgvReportes.SelectedCells[i].FormattedValue);
                //Realizamos la suma respectiva.
                tot += value;
            }
            //Mostramos el total.
            MessageBox.Show("Total: " + tot);
        }

        //Ordenar Todas las compras
        private void btnrCompras_Click(object sender, EventArgs e)
        {
            using ( DataBase.BasedeDatos.CarniceriaEntities dbv = new DataBase.BasedeDatos.CarniceriaEntities())
            {
                var cgral = from cg in dbv.Compras.AsNoTracking()
                                                
                            select new { Fecha = cg.FechaCompra, Proveedor = cg.ID_Prov, Corte = cg.ID_Corte, cg.Cantidad, KG = cg.Peso, cg.Total };



                dtgvReportes.DataSource = cgral.ToList();
            }
        }
        //Mostrar todos los gastos
        private void btnrGastos_Click(object sender, EventArgs e)
        {
            using(DataBase.BasedeDatos.CarniceriaEntities dbg = new DataBase.BasedeDatos.CarniceriaEntities())
            {
                var gGral = from g in dbg.Gastos.AsNoTracking()
                            select new { Fecha = g.FechaGasto, Categoria = g.ID_TG, Total = g.Monto };

                dtgvReportes.DataSource = gGral.ToList();
            }
        }
        
    }
}
