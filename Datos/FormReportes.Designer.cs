namespace Datos
{
    partial class FormReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportes));
            this.crvdtgvReportes = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dtgvReportes = new System.Windows.Forms.DataGridView();
            this.btnrVentas = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlrTop = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnrProvMes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnrProvSemana = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnrGastosMes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnrGastosSemana = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnrProv = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnrGastos = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnrComprasMes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnrComprasSemana = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnrCompras = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnrVentasMes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnrVentasSemana = new Bunifu.Framework.UI.BunifuThinButton2();
            this.crvrPanelTop = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReportes)).BeginInit();
            this.pnlrTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvdtgvReportes
            // 
            this.crvdtgvReportes.ElipseRadius = 11;
            this.crvdtgvReportes.TargetControl = this.dtgvReportes;
            // 
            // dtgvReportes
            // 
            this.dtgvReportes.BackgroundColor = System.Drawing.Color.White;
            this.dtgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReportes.Location = new System.Drawing.Point(12, 244);
            this.dtgvReportes.Name = "dtgvReportes";
            this.dtgvReportes.Size = new System.Drawing.Size(907, 308);
            this.dtgvReportes.TabIndex = 0;
            // 
            // btnrVentas
            // 
            this.btnrVentas.ActiveBorderThickness = 1;
            this.btnrVentas.ActiveCornerRadius = 20;
            this.btnrVentas.ActiveFillColor = System.Drawing.Color.CadetBlue;
            this.btnrVentas.ActiveForecolor = System.Drawing.Color.Black;
            this.btnrVentas.ActiveLineColor = System.Drawing.Color.MediumAquamarine;
            this.btnrVentas.BackColor = System.Drawing.Color.White;
            this.btnrVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrVentas.BackgroundImage")));
            this.btnrVentas.ButtonText = "Todas las Ventas";
            this.btnrVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrVentas.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrVentas.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnrVentas.IdleBorderThickness = 1;
            this.btnrVentas.IdleCornerRadius = 20;
            this.btnrVentas.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnrVentas.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnrVentas.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnrVentas.Location = new System.Drawing.Point(17, 22);
            this.btnrVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrVentas.Name = "btnrVentas";
            this.btnrVentas.Size = new System.Drawing.Size(198, 45);
            this.btnrVentas.TabIndex = 2;
            this.btnrVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnrVentas.Click += new System.EventHandler(this.btnrVentas_Click);
            // 
            // pnlrTop
            // 
            this.pnlrTop.BackColor = System.Drawing.Color.White;
            this.pnlrTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlrTop.BackgroundImage")));
            this.pnlrTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlrTop.Controls.Add(this.bunifuSeparator2);
            this.pnlrTop.Controls.Add(this.bunifuSeparator1);
            this.pnlrTop.Controls.Add(this.btnrProvMes);
            this.pnlrTop.Controls.Add(this.btnrProvSemana);
            this.pnlrTop.Controls.Add(this.btnrGastosMes);
            this.pnlrTop.Controls.Add(this.btnrGastosSemana);
            this.pnlrTop.Controls.Add(this.btnrProv);
            this.pnlrTop.Controls.Add(this.btnrGastos);
            this.pnlrTop.Controls.Add(this.btnrComprasMes);
            this.pnlrTop.Controls.Add(this.btnrComprasSemana);
            this.pnlrTop.Controls.Add(this.btnrCompras);
            this.pnlrTop.Controls.Add(this.btnrVentasMes);
            this.pnlrTop.Controls.Add(this.btnrVentasSemana);
            this.pnlrTop.Controls.Add(this.btnrVentas);
            this.pnlrTop.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlrTop.GradientBottomRight = System.Drawing.Color.White;
            this.pnlrTop.GradientTopLeft = System.Drawing.Color.White;
            this.pnlrTop.GradientTopRight = System.Drawing.Color.White;
            this.pnlrTop.Location = new System.Drawing.Point(12, 12);
            this.pnlrTop.Name = "pnlrTop";
            this.pnlrTop.Quality = 10;
            this.pnlrTop.Size = new System.Drawing.Size(907, 215);
            this.pnlrTop.TabIndex = 3;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(222)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(641, 15);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(14, 184);
            this.bunifuSeparator2.TabIndex = 15;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(222)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(249, 15);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(14, 184);
            this.bunifuSeparator1.TabIndex = 14;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // btnrProvMes
            // 
            this.btnrProvMes.ActiveBorderThickness = 1;
            this.btnrProvMes.ActiveCornerRadius = 20;
            this.btnrProvMes.ActiveFillColor = System.Drawing.Color.CadetBlue;
            this.btnrProvMes.ActiveForecolor = System.Drawing.Color.Black;
            this.btnrProvMes.ActiveLineColor = System.Drawing.Color.MediumAquamarine;
            this.btnrProvMes.BackColor = System.Drawing.Color.White;
            this.btnrProvMes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrProvMes.BackgroundImage")));
            this.btnrProvMes.ButtonText = "Por Proveedor";
            this.btnrProvMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrProvMes.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrProvMes.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnrProvMes.IdleBorderThickness = 1;
            this.btnrProvMes.IdleCornerRadius = 20;
            this.btnrProvMes.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnrProvMes.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnrProvMes.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnrProvMes.Location = new System.Drawing.Point(497, 77);
            this.btnrProvMes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrProvMes.Name = "btnrProvMes";
            this.btnrProvMes.Size = new System.Drawing.Size(115, 45);
            this.btnrProvMes.TabIndex = 13;
            this.btnrProvMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnrProvSemana
            // 
            this.btnrProvSemana.ActiveBorderThickness = 1;
            this.btnrProvSemana.ActiveCornerRadius = 20;
            this.btnrProvSemana.ActiveFillColor = System.Drawing.Color.CadetBlue;
            this.btnrProvSemana.ActiveForecolor = System.Drawing.Color.Black;
            this.btnrProvSemana.ActiveLineColor = System.Drawing.Color.MediumAquamarine;
            this.btnrProvSemana.BackColor = System.Drawing.Color.White;
            this.btnrProvSemana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrProvSemana.BackgroundImage")));
            this.btnrProvSemana.ButtonText = "Por Proveedor";
            this.btnrProvSemana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrProvSemana.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrProvSemana.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnrProvSemana.IdleBorderThickness = 1;
            this.btnrProvSemana.IdleCornerRadius = 20;
            this.btnrProvSemana.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnrProvSemana.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnrProvSemana.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnrProvSemana.Location = new System.Drawing.Point(497, 132);
            this.btnrProvSemana.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrProvSemana.Name = "btnrProvSemana";
            this.btnrProvSemana.Size = new System.Drawing.Size(115, 45);
            this.btnrProvSemana.TabIndex = 12;
            this.btnrProvSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnrGastosMes
            // 
            this.btnrGastosMes.ActiveBorderThickness = 1;
            this.btnrGastosMes.ActiveCornerRadius = 20;
            this.btnrGastosMes.ActiveFillColor = System.Drawing.Color.CadetBlue;
            this.btnrGastosMes.ActiveForecolor = System.Drawing.Color.Black;
            this.btnrGastosMes.ActiveLineColor = System.Drawing.Color.MediumAquamarine;
            this.btnrGastosMes.BackColor = System.Drawing.Color.White;
            this.btnrGastosMes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrGastosMes.BackgroundImage")));
            this.btnrGastosMes.ButtonText = "Gasto Mensual";
            this.btnrGastosMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrGastosMes.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrGastosMes.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnrGastosMes.IdleBorderThickness = 1;
            this.btnrGastosMes.IdleCornerRadius = 20;
            this.btnrGastosMes.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnrGastosMes.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnrGastosMes.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnrGastosMes.Location = new System.Drawing.Point(686, 77);
            this.btnrGastosMes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrGastosMes.Name = "btnrGastosMes";
            this.btnrGastosMes.Size = new System.Drawing.Size(198, 45);
            this.btnrGastosMes.TabIndex = 10;
            this.btnrGastosMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnrGastosSemana
            // 
            this.btnrGastosSemana.ActiveBorderThickness = 1;
            this.btnrGastosSemana.ActiveCornerRadius = 20;
            this.btnrGastosSemana.ActiveFillColor = System.Drawing.Color.CadetBlue;
            this.btnrGastosSemana.ActiveForecolor = System.Drawing.Color.Black;
            this.btnrGastosSemana.ActiveLineColor = System.Drawing.Color.MediumAquamarine;
            this.btnrGastosSemana.BackColor = System.Drawing.Color.White;
            this.btnrGastosSemana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrGastosSemana.BackgroundImage")));
            this.btnrGastosSemana.ButtonText = "Gasto Semanal";
            this.btnrGastosSemana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrGastosSemana.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrGastosSemana.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnrGastosSemana.IdleBorderThickness = 1;
            this.btnrGastosSemana.IdleCornerRadius = 20;
            this.btnrGastosSemana.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnrGastosSemana.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnrGastosSemana.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnrGastosSemana.Location = new System.Drawing.Point(686, 132);
            this.btnrGastosSemana.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrGastosSemana.Name = "btnrGastosSemana";
            this.btnrGastosSemana.Size = new System.Drawing.Size(198, 45);
            this.btnrGastosSemana.TabIndex = 9;
            this.btnrGastosSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnrProv
            // 
            this.btnrProv.ActiveBorderThickness = 1;
            this.btnrProv.ActiveCornerRadius = 20;
            this.btnrProv.ActiveFillColor = System.Drawing.Color.CadetBlue;
            this.btnrProv.ActiveForecolor = System.Drawing.Color.Black;
            this.btnrProv.ActiveLineColor = System.Drawing.Color.MediumAquamarine;
            this.btnrProv.BackColor = System.Drawing.Color.White;
            this.btnrProv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrProv.BackgroundImage")));
            this.btnrProv.ButtonText = "Por Proveedor";
            this.btnrProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrProv.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrProv.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnrProv.IdleBorderThickness = 1;
            this.btnrProv.IdleCornerRadius = 20;
            this.btnrProv.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnrProv.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnrProv.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnrProv.Location = new System.Drawing.Point(497, 22);
            this.btnrProv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrProv.Name = "btnrProv";
            this.btnrProv.Size = new System.Drawing.Size(115, 45);
            this.btnrProv.TabIndex = 11;
            this.btnrProv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnrGastos
            // 
            this.btnrGastos.ActiveBorderThickness = 1;
            this.btnrGastos.ActiveCornerRadius = 20;
            this.btnrGastos.ActiveFillColor = System.Drawing.Color.CadetBlue;
            this.btnrGastos.ActiveForecolor = System.Drawing.Color.Black;
            this.btnrGastos.ActiveLineColor = System.Drawing.Color.MediumAquamarine;
            this.btnrGastos.BackColor = System.Drawing.Color.White;
            this.btnrGastos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrGastos.BackgroundImage")));
            this.btnrGastos.ButtonText = "Todos los Gastos";
            this.btnrGastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrGastos.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrGastos.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnrGastos.IdleBorderThickness = 1;
            this.btnrGastos.IdleCornerRadius = 20;
            this.btnrGastos.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnrGastos.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnrGastos.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnrGastos.Location = new System.Drawing.Point(686, 22);
            this.btnrGastos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrGastos.Name = "btnrGastos";
            this.btnrGastos.Size = new System.Drawing.Size(198, 45);
            this.btnrGastos.TabIndex = 8;
            this.btnrGastos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnrGastos.Click += new System.EventHandler(this.btnrGastos_Click);
            // 
            // btnrComprasMes
            // 
            this.btnrComprasMes.ActiveBorderThickness = 1;
            this.btnrComprasMes.ActiveCornerRadius = 20;
            this.btnrComprasMes.ActiveFillColor = System.Drawing.Color.CadetBlue;
            this.btnrComprasMes.ActiveForecolor = System.Drawing.Color.Black;
            this.btnrComprasMes.ActiveLineColor = System.Drawing.Color.MediumAquamarine;
            this.btnrComprasMes.BackColor = System.Drawing.Color.White;
            this.btnrComprasMes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrComprasMes.BackgroundImage")));
            this.btnrComprasMes.ButtonText = "Compra Mensual";
            this.btnrComprasMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrComprasMes.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrComprasMes.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnrComprasMes.IdleBorderThickness = 1;
            this.btnrComprasMes.IdleCornerRadius = 20;
            this.btnrComprasMes.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnrComprasMes.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnrComprasMes.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnrComprasMes.Location = new System.Drawing.Point(291, 77);
            this.btnrComprasMes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrComprasMes.Name = "btnrComprasMes";
            this.btnrComprasMes.Size = new System.Drawing.Size(198, 45);
            this.btnrComprasMes.TabIndex = 7;
            this.btnrComprasMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnrComprasSemana
            // 
            this.btnrComprasSemana.ActiveBorderThickness = 1;
            this.btnrComprasSemana.ActiveCornerRadius = 20;
            this.btnrComprasSemana.ActiveFillColor = System.Drawing.Color.CadetBlue;
            this.btnrComprasSemana.ActiveForecolor = System.Drawing.Color.Black;
            this.btnrComprasSemana.ActiveLineColor = System.Drawing.Color.MediumAquamarine;
            this.btnrComprasSemana.BackColor = System.Drawing.Color.White;
            this.btnrComprasSemana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrComprasSemana.BackgroundImage")));
            this.btnrComprasSemana.ButtonText = "Compra Semanal";
            this.btnrComprasSemana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrComprasSemana.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrComprasSemana.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnrComprasSemana.IdleBorderThickness = 1;
            this.btnrComprasSemana.IdleCornerRadius = 20;
            this.btnrComprasSemana.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnrComprasSemana.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnrComprasSemana.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnrComprasSemana.Location = new System.Drawing.Point(291, 132);
            this.btnrComprasSemana.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrComprasSemana.Name = "btnrComprasSemana";
            this.btnrComprasSemana.Size = new System.Drawing.Size(198, 45);
            this.btnrComprasSemana.TabIndex = 6;
            this.btnrComprasSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnrCompras
            // 
            this.btnrCompras.ActiveBorderThickness = 1;
            this.btnrCompras.ActiveCornerRadius = 20;
            this.btnrCompras.ActiveFillColor = System.Drawing.Color.CadetBlue;
            this.btnrCompras.ActiveForecolor = System.Drawing.Color.Black;
            this.btnrCompras.ActiveLineColor = System.Drawing.Color.MediumAquamarine;
            this.btnrCompras.BackColor = System.Drawing.Color.White;
            this.btnrCompras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrCompras.BackgroundImage")));
            this.btnrCompras.ButtonText = "Todas las Compras";
            this.btnrCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrCompras.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrCompras.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnrCompras.IdleBorderThickness = 1;
            this.btnrCompras.IdleCornerRadius = 20;
            this.btnrCompras.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnrCompras.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnrCompras.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnrCompras.Location = new System.Drawing.Point(291, 22);
            this.btnrCompras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrCompras.Name = "btnrCompras";
            this.btnrCompras.Size = new System.Drawing.Size(198, 45);
            this.btnrCompras.TabIndex = 5;
            this.btnrCompras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnrCompras.Click += new System.EventHandler(this.btnrCompras_Click);
            // 
            // btnrVentasMes
            // 
            this.btnrVentasMes.ActiveBorderThickness = 1;
            this.btnrVentasMes.ActiveCornerRadius = 20;
            this.btnrVentasMes.ActiveFillColor = System.Drawing.Color.CadetBlue;
            this.btnrVentasMes.ActiveForecolor = System.Drawing.Color.Black;
            this.btnrVentasMes.ActiveLineColor = System.Drawing.Color.MediumAquamarine;
            this.btnrVentasMes.BackColor = System.Drawing.Color.White;
            this.btnrVentasMes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrVentasMes.BackgroundImage")));
            this.btnrVentasMes.ButtonText = "Venta Mensual";
            this.btnrVentasMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrVentasMes.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrVentasMes.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnrVentasMes.IdleBorderThickness = 1;
            this.btnrVentasMes.IdleCornerRadius = 20;
            this.btnrVentasMes.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnrVentasMes.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnrVentasMes.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnrVentasMes.Location = new System.Drawing.Point(17, 77);
            this.btnrVentasMes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrVentasMes.Name = "btnrVentasMes";
            this.btnrVentasMes.Size = new System.Drawing.Size(198, 45);
            this.btnrVentasMes.TabIndex = 4;
            this.btnrVentasMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnrVentasMes.Click += new System.EventHandler(this.btnrVentasMes_Click);
            // 
            // btnrVentasSemana
            // 
            this.btnrVentasSemana.ActiveBorderThickness = 1;
            this.btnrVentasSemana.ActiveCornerRadius = 20;
            this.btnrVentasSemana.ActiveFillColor = System.Drawing.Color.CadetBlue;
            this.btnrVentasSemana.ActiveForecolor = System.Drawing.Color.Black;
            this.btnrVentasSemana.ActiveLineColor = System.Drawing.Color.MediumAquamarine;
            this.btnrVentasSemana.BackColor = System.Drawing.Color.White;
            this.btnrVentasSemana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrVentasSemana.BackgroundImage")));
            this.btnrVentasSemana.ButtonText = "Seleccionar Ventas";
            this.btnrVentasSemana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrVentasSemana.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrVentasSemana.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnrVentasSemana.IdleBorderThickness = 1;
            this.btnrVentasSemana.IdleCornerRadius = 20;
            this.btnrVentasSemana.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnrVentasSemana.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnrVentasSemana.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnrVentasSemana.Location = new System.Drawing.Point(17, 132);
            this.btnrVentasSemana.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrVentasSemana.Name = "btnrVentasSemana";
            this.btnrVentasSemana.Size = new System.Drawing.Size(198, 45);
            this.btnrVentasSemana.TabIndex = 3;
            this.btnrVentasSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnrVentasSemana.Click += new System.EventHandler(this.btnrVentasSemana_Click);
            // 
            // crvrPanelTop
            // 
            this.crvrPanelTop.ElipseRadius = 12;
            this.crvrPanelTop.TargetControl = this.pnlrTop;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(931, 564);
            this.Controls.Add(this.dtgvReportes);
            this.Controls.Add(this.pnlrTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReportes)).EndInit();
            this.pnlrTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse crvdtgvReportes;
        private Bunifu.Framework.UI.BunifuThinButton2 btnrVentas;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlrTop;
        private System.Windows.Forms.DataGridView dtgvReportes;
        private Bunifu.Framework.UI.BunifuElipse crvrPanelTop;
        private Bunifu.Framework.UI.BunifuThinButton2 btnrGastosMes;
        private Bunifu.Framework.UI.BunifuThinButton2 btnrGastosSemana;
        private Bunifu.Framework.UI.BunifuThinButton2 btnrGastos;
        private Bunifu.Framework.UI.BunifuThinButton2 btnrComprasMes;
        private Bunifu.Framework.UI.BunifuThinButton2 btnrComprasSemana;
        private Bunifu.Framework.UI.BunifuThinButton2 btnrCompras;
        private Bunifu.Framework.UI.BunifuThinButton2 btnrVentasMes;
        private Bunifu.Framework.UI.BunifuThinButton2 btnrVentasSemana;
        private Bunifu.Framework.UI.BunifuThinButton2 btnrProvMes;
        private Bunifu.Framework.UI.BunifuThinButton2 btnrProvSemana;
        private Bunifu.Framework.UI.BunifuThinButton2 btnrProv;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}