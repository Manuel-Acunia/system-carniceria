namespace Datos
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.pnlCompras = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnConfirmarCompra = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dateCompras = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtcPrecio = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboTipoCorte = new System.Windows.Forms.ComboBox();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.crvPanelCompras = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCompras
            // 
            this.pnlCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCompras.BackColor = System.Drawing.Color.White;
            this.pnlCompras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCompras.BackgroundImage")));
            this.pnlCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCompras.Controls.Add(this.lblTotal);
            this.pnlCompras.Controls.Add(this.txtTotal);
            this.pnlCompras.Controls.Add(this.pictureBox4);
            this.pnlCompras.Controls.Add(this.btnConfirmarCompra);
            this.pnlCompras.Controls.Add(this.lblFecha);
            this.pnlCompras.Controls.Add(this.dateCompras);
            this.pnlCompras.Controls.Add(this.txtCantidad);
            this.pnlCompras.Controls.Add(this.txtPeso);
            this.pnlCompras.Controls.Add(this.pictureBox3);
            this.pnlCompras.Controls.Add(this.pictureBox2);
            this.pnlCompras.Controls.Add(this.txtcPrecio);
            this.pnlCompras.Controls.Add(this.pictureBox1);
            this.pnlCompras.Controls.Add(this.cboTipoCorte);
            this.pnlCompras.Controls.Add(this.cboProveedor);
            this.pnlCompras.Controls.Add(this.lblPrecio);
            this.pnlCompras.Controls.Add(this.lblCantidad);
            this.pnlCompras.Controls.Add(this.lblPeso);
            this.pnlCompras.Controls.Add(this.lblTipo);
            this.pnlCompras.Controls.Add(this.lblProveedor);
            this.pnlCompras.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlCompras.GradientBottomRight = System.Drawing.Color.White;
            this.pnlCompras.GradientTopLeft = System.Drawing.Color.White;
            this.pnlCompras.GradientTopRight = System.Drawing.Color.White;
            this.pnlCompras.Location = new System.Drawing.Point(96, 12);
            this.pnlCompras.Name = "pnlCompras";
            this.pnlCompras.Quality = 10;
            this.pnlCompras.Size = new System.Drawing.Size(690, 527);
            this.pnlCompras.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotal.Location = new System.Drawing.Point(181, 337);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 18);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "TOTAL";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Impact", 11F);
            this.txtTotal.Location = new System.Drawing.Point(391, 336);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(113, 18);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(373, 321);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 55);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.ActiveBorderThickness = 1;
            this.btnConfirmarCompra.ActiveCornerRadius = 20;
            this.btnConfirmarCompra.ActiveFillColor = System.Drawing.Color.CadetBlue;
            this.btnConfirmarCompra.ActiveForecolor = System.Drawing.Color.Black;
            this.btnConfirmarCompra.ActiveLineColor = System.Drawing.Color.MediumAquamarine;
            this.btnConfirmarCompra.BackColor = System.Drawing.Color.White;
            this.btnConfirmarCompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmarCompra.BackgroundImage")));
            this.btnConfirmarCompra.ButtonText = "Confirmar";
            this.btnConfirmarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarCompra.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarCompra.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnConfirmarCompra.IdleBorderThickness = 1;
            this.btnConfirmarCompra.IdleCornerRadius = 20;
            this.btnConfirmarCompra.IdleFillColor = System.Drawing.Color.White;
            this.btnConfirmarCompra.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnConfirmarCompra.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnConfirmarCompra.Location = new System.Drawing.Point(183, 426);
            this.btnConfirmarCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(331, 45);
            this.btnConfirmarCompra.TabIndex = 6;
            this.btnConfirmarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFecha.Location = new System.Drawing.Point(180, 33);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 17);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha";
            // 
            // dateCompras
            // 
            this.dateCompras.BackColor = System.Drawing.Color.White;
            this.dateCompras.BorderRadius = 0;
            this.dateCompras.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCompras.ForeColor = System.Drawing.Color.Gray;
            this.dateCompras.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCompras.FormatCustom = null;
            this.dateCompras.Location = new System.Drawing.Point(370, 33);
            this.dateCompras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateCompras.Name = "dateCompras";
            this.dateCompras.Size = new System.Drawing.Size(144, 23);
            this.dateCompras.TabIndex = 0;
            this.dateCompras.Value = new System.DateTime(2019, 10, 16, 8, 22, 21, 140);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(395, 174);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(111, 15);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtPeso
            // 
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeso.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(395, 221);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(111, 15);
            this.txtPeso.TabIndex = 4;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(393, 215);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(118, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(393, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // txtcPrecio
            // 
            this.txtcPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcPrecio.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcPrecio.Location = new System.Drawing.Point(411, 267);
            this.txtcPrecio.Name = "txtcPrecio";
            this.txtcPrecio.Size = new System.Drawing.Size(93, 15);
            this.txtcPrecio.TabIndex = 5;
            this.txtcPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcPrecio_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(393, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cboTipoCorte
            // 
            this.cboTipoCorte.FormattingEnabled = true;
            this.cboTipoCorte.Location = new System.Drawing.Point(393, 121);
            this.cboTipoCorte.Name = "cboTipoCorte";
            this.cboTipoCorte.Size = new System.Drawing.Size(121, 21);
            this.cboTipoCorte.TabIndex = 2;
            // 
            // cboProveedor
            // 
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(393, 74);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(121, 21);
            this.cboProveedor.TabIndex = 1;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPrecio.Location = new System.Drawing.Point(180, 262);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(44, 17);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCantidad.Location = new System.Drawing.Point(180, 168);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(58, 17);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.Transparent;
            this.lblPeso.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPeso.Location = new System.Drawing.Point(180, 215);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(35, 17);
            this.lblPeso.TabIndex = 6;
            this.lblPeso.Text = "Peso";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTipo.Location = new System.Drawing.Point(180, 121);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(80, 17);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo de Corte";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.BackColor = System.Drawing.Color.Transparent;
            this.lblProveedor.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProveedor.Location = new System.Drawing.Point(180, 74);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(65, 17);
            this.lblProveedor.TabIndex = 1;
            this.lblProveedor.Text = "Proveedor";
            // 
            // crvPanelCompras
            // 
            this.crvPanelCompras.ElipseRadius = 11;
            this.crvPanelCompras.TargetControl = this.pnlCompras;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(931, 564);
            this.Controls.Add(this.pnlCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.pnlCompras.ResumeLayout(false);
            this.pnlCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlCompras;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblProveedor;
        private Bunifu.Framework.UI.BunifuElipse crvPanelCompras;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cboTipoCorte;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.TextBox txtcPrecio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblFecha;
        private Bunifu.Framework.UI.BunifuDatepicker dateCompras;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConfirmarCompra;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}