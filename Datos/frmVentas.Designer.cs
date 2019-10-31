namespace Datos
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.crvVTarjeta = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlVentasTarjeta = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.labelVentaConTarjeta = new System.Windows.Forms.Label();
            this.lblPTarjeta = new System.Windows.Forms.Label();
            this.lblVentaTarjeta = new System.Windows.Forms.Label();
            this.crvVMayor = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlFecha = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DateTimeVenta = new Bunifu.Framework.UI.BunifuDatepicker();
            this.crvVTotalDia = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlTotalDia = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.labelVentaDia = new System.Windows.Forms.Label();
            this.lblTotallDia = new System.Windows.Forms.Label();
            this.lblTotalDia = new System.Windows.Forms.Label();
            this.crvVenta = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlVentas = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.lblIngreseVenta = new System.Windows.Forms.Label();
            this.lblVTarjeta = new System.Windows.Forms.Label();
            this.chckTarjeta = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btnConfirmar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pbxVenta = new System.Windows.Forms.PictureBox();
            this.lstbVentas = new System.Windows.Forms.ListBox();
            this.crvlsbVentas = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnCerrarCaja = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlVentasTarjeta.SuspendLayout();
            this.pnlFecha.SuspendLayout();
            this.pnlTotalDia.SuspendLayout();
            this.pnlVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // crvVTarjeta
            // 
            this.crvVTarjeta.ElipseRadius = 20;
            this.crvVTarjeta.TargetControl = this.pnlVentasTarjeta;
            // 
            // pnlVentasTarjeta
            // 
            this.pnlVentasTarjeta.BackColor = System.Drawing.Color.White;
            this.pnlVentasTarjeta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlVentasTarjeta.BackgroundImage")));
            this.pnlVentasTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlVentasTarjeta.Controls.Add(this.labelVentaConTarjeta);
            this.pnlVentasTarjeta.Controls.Add(this.lblPTarjeta);
            this.pnlVentasTarjeta.Controls.Add(this.lblVentaTarjeta);
            this.pnlVentasTarjeta.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlVentasTarjeta.GradientBottomRight = System.Drawing.Color.White;
            this.pnlVentasTarjeta.GradientTopLeft = System.Drawing.Color.White;
            this.pnlVentasTarjeta.GradientTopRight = System.Drawing.Color.White;
            this.pnlVentasTarjeta.Location = new System.Drawing.Point(312, 22);
            this.pnlVentasTarjeta.Name = "pnlVentasTarjeta";
            this.pnlVentasTarjeta.Quality = 10;
            this.pnlVentasTarjeta.Size = new System.Drawing.Size(239, 141);
            this.pnlVentasTarjeta.TabIndex = 0;
            // 
            // labelVentaConTarjeta
            // 
            this.labelVentaConTarjeta.AutoSize = true;
            this.labelVentaConTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.labelVentaConTarjeta.Font = new System.Drawing.Font("Impact", 30F);
            this.labelVentaConTarjeta.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelVentaConTarjeta.Location = new System.Drawing.Point(69, 65);
            this.labelVentaConTarjeta.Name = "labelVentaConTarjeta";
            this.labelVentaConTarjeta.Size = new System.Drawing.Size(111, 48);
            this.labelVentaConTarjeta.TabIndex = 4;
            this.labelVentaConTarjeta.Text = "00.00";
            // 
            // lblPTarjeta
            // 
            this.lblPTarjeta.AutoSize = true;
            this.lblPTarjeta.Font = new System.Drawing.Font("Impact", 25F);
            this.lblPTarjeta.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblPTarjeta.Location = new System.Drawing.Point(26, 65);
            this.lblPTarjeta.Name = "lblPTarjeta";
            this.lblPTarjeta.Size = new System.Drawing.Size(37, 42);
            this.lblPTarjeta.TabIndex = 3;
            this.lblPTarjeta.Text = "$";
            // 
            // lblVentaTarjeta
            // 
            this.lblVentaTarjeta.AutoSize = true;
            this.lblVentaTarjeta.Font = new System.Drawing.Font("Impact", 14F);
            this.lblVentaTarjeta.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblVentaTarjeta.Location = new System.Drawing.Point(39, 17);
            this.lblVentaTarjeta.Name = "lblVentaTarjeta";
            this.lblVentaTarjeta.Size = new System.Drawing.Size(155, 23);
            this.lblVentaTarjeta.TabIndex = 0;
            this.lblVentaTarjeta.Text = "Ventas con Tarjeta";
            // 
            // crvVMayor
            // 
            this.crvVMayor.ElipseRadius = 20;
            this.crvVMayor.TargetControl = this.pnlFecha;
            // 
            // pnlFecha
            // 
            this.pnlFecha.BackColor = System.Drawing.Color.White;
            this.pnlFecha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFecha.BackgroundImage")));
            this.pnlFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFecha.Controls.Add(this.DateTimeVenta);
            this.pnlFecha.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlFecha.GradientBottomRight = System.Drawing.Color.White;
            this.pnlFecha.GradientTopLeft = System.Drawing.Color.White;
            this.pnlFecha.GradientTopRight = System.Drawing.Color.White;
            this.pnlFecha.Location = new System.Drawing.Point(21, 23);
            this.pnlFecha.Name = "pnlFecha";
            this.pnlFecha.Quality = 10;
            this.pnlFecha.Size = new System.Drawing.Size(285, 141);
            this.pnlFecha.TabIndex = 1;
            // 
            // DateTimeVenta
            // 
            this.DateTimeVenta.BackColor = System.Drawing.Color.Transparent;
            this.DateTimeVenta.BorderRadius = 0;
            this.DateTimeVenta.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeVenta.ForeColor = System.Drawing.Color.Black;
            this.DateTimeVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeVenta.FormatCustom = null;
            this.DateTimeVenta.Location = new System.Drawing.Point(11, 3);
            this.DateTimeVenta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DateTimeVenta.Name = "DateTimeVenta";
            this.DateTimeVenta.Size = new System.Drawing.Size(261, 121);
            this.DateTimeVenta.TabIndex = 0;
            this.DateTimeVenta.Value = new System.DateTime(2019, 10, 7, 2, 43, 21, 102);
            // 
            // crvVTotalDia
            // 
            this.crvVTotalDia.ElipseRadius = 20;
            this.crvVTotalDia.TargetControl = this.pnlTotalDia;
            // 
            // pnlTotalDia
            // 
            this.pnlTotalDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotalDia.BackColor = System.Drawing.Color.White;
            this.pnlTotalDia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTotalDia.BackgroundImage")));
            this.pnlTotalDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTotalDia.Controls.Add(this.labelVentaDia);
            this.pnlTotalDia.Controls.Add(this.lblTotallDia);
            this.pnlTotalDia.Controls.Add(this.lblTotalDia);
            this.pnlTotalDia.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlTotalDia.GradientBottomRight = System.Drawing.Color.White;
            this.pnlTotalDia.GradientTopLeft = System.Drawing.Color.White;
            this.pnlTotalDia.GradientTopRight = System.Drawing.Color.White;
            this.pnlTotalDia.Location = new System.Drawing.Point(557, 22);
            this.pnlTotalDia.Name = "pnlTotalDia";
            this.pnlTotalDia.Quality = 10;
            this.pnlTotalDia.Size = new System.Drawing.Size(362, 141);
            this.pnlTotalDia.TabIndex = 2;
            // 
            // labelVentaDia
            // 
            this.labelVentaDia.AutoSize = true;
            this.labelVentaDia.BackColor = System.Drawing.Color.Transparent;
            this.labelVentaDia.Font = new System.Drawing.Font("Impact", 30F);
            this.labelVentaDia.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelVentaDia.Location = new System.Drawing.Point(146, 65);
            this.labelVentaDia.Name = "labelVentaDia";
            this.labelVentaDia.Size = new System.Drawing.Size(111, 48);
            this.labelVentaDia.TabIndex = 4;
            this.labelVentaDia.Text = "00.00";
            // 
            // lblTotallDia
            // 
            this.lblTotallDia.AutoSize = true;
            this.lblTotallDia.BackColor = System.Drawing.Color.Transparent;
            this.lblTotallDia.Font = new System.Drawing.Font("Impact", 25F);
            this.lblTotallDia.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTotallDia.Location = new System.Drawing.Point(103, 65);
            this.lblTotallDia.Name = "lblTotallDia";
            this.lblTotallDia.Size = new System.Drawing.Size(37, 42);
            this.lblTotallDia.TabIndex = 3;
            this.lblTotallDia.Text = "$";
            // 
            // lblTotalDia
            // 
            this.lblTotalDia.AutoSize = true;
            this.lblTotalDia.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDia.Font = new System.Drawing.Font("Impact", 14F);
            this.lblTotalDia.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTotalDia.Location = new System.Drawing.Point(110, 17);
            this.lblTotalDia.Name = "lblTotalDia";
            this.lblTotalDia.Size = new System.Drawing.Size(166, 23);
            this.lblTotalDia.TabIndex = 1;
            this.lblTotalDia.Text = "Total parcial del Dia";
            // 
            // crvVenta
            // 
            this.crvVenta.ElipseRadius = 20;
            this.crvVenta.TargetControl = this.pnlVentas;
            // 
            // pnlVentas
            // 
            this.pnlVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVentas.BackColor = System.Drawing.Color.White;
            this.pnlVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlVentas.BackgroundImage")));
            this.pnlVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlVentas.Controls.Add(this.txtVenta);
            this.pnlVentas.Controls.Add(this.lblIngreseVenta);
            this.pnlVentas.Controls.Add(this.lblVTarjeta);
            this.pnlVentas.Controls.Add(this.chckTarjeta);
            this.pnlVentas.Controls.Add(this.btnConfirmar);
            this.pnlVentas.Controls.Add(this.pbxVenta);
            this.pnlVentas.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlVentas.GradientBottomRight = System.Drawing.Color.White;
            this.pnlVentas.GradientTopLeft = System.Drawing.Color.White;
            this.pnlVentas.GradientTopRight = System.Drawing.Color.White;
            this.pnlVentas.Location = new System.Drawing.Point(557, 170);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Quality = 10;
            this.pnlVentas.Size = new System.Drawing.Size(362, 382);
            this.pnlVentas.TabIndex = 3;
            // 
            // txtVenta
            // 
            this.txtVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVenta.Font = new System.Drawing.Font("Century Gothic", 13.25F, System.Drawing.FontStyle.Bold);
            this.txtVenta.Location = new System.Drawing.Point(203, 38);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(132, 22);
            this.txtVenta.TabIndex = 0;
            this.txtVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVenta_KeyPress);
            // 
            // lblIngreseVenta
            // 
            this.lblIngreseVenta.AutoSize = true;
            this.lblIngreseVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblIngreseVenta.Font = new System.Drawing.Font("Impact", 14F);
            this.lblIngreseVenta.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblIngreseVenta.Location = new System.Drawing.Point(28, 37);
            this.lblIngreseVenta.Name = "lblIngreseVenta";
            this.lblIngreseVenta.Size = new System.Drawing.Size(55, 23);
            this.lblIngreseVenta.TabIndex = 6;
            this.lblIngreseVenta.Text = "Venta";
            this.lblIngreseVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVTarjeta
            // 
            this.lblVTarjeta.AutoSize = true;
            this.lblVTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.lblVTarjeta.Font = new System.Drawing.Font("Impact", 10F);
            this.lblVTarjeta.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblVTarjeta.Location = new System.Drawing.Point(296, 124);
            this.lblVTarjeta.Name = "lblVTarjeta";
            this.lblVTarjeta.Size = new System.Drawing.Size(47, 18);
            this.lblVTarjeta.TabIndex = 5;
            this.lblVTarjeta.Text = "Tarjeta";
            // 
            // chckTarjeta
            // 
            this.chckTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chckTarjeta.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chckTarjeta.Checked = false;
            this.chckTarjeta.CheckedOnColor = System.Drawing.SystemColors.MenuHighlight;
            this.chckTarjeta.ForeColor = System.Drawing.Color.White;
            this.chckTarjeta.Location = new System.Drawing.Point(309, 97);
            this.chckTarjeta.Name = "chckTarjeta";
            this.chckTarjeta.Size = new System.Drawing.Size(20, 20);
            this.chckTarjeta.TabIndex = 2;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.ActiveBorderThickness = 1;
            this.btnConfirmar.ActiveCornerRadius = 20;
            this.btnConfirmar.ActiveFillColor = System.Drawing.Color.CadetBlue;
            this.btnConfirmar.ActiveForecolor = System.Drawing.Color.Black;
            this.btnConfirmar.ActiveLineColor = System.Drawing.Color.MediumAquamarine;
            this.btnConfirmar.BackColor = System.Drawing.Color.White;
            this.btnConfirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.BackgroundImage")));
            this.btnConfirmar.ButtonText = "Confirmar";
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnConfirmar.IdleBorderThickness = 1;
            this.btnConfirmar.IdleCornerRadius = 20;
            this.btnConfirmar.IdleFillColor = System.Drawing.Color.White;
            this.btnConfirmar.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnConfirmar.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnConfirmar.Location = new System.Drawing.Point(54, 279);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(296, 45);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // pbxVenta
            // 
            this.pbxVenta.Image = ((System.Drawing.Image)(resources.GetObject("pbxVenta.Image")));
            this.pbxVenta.Location = new System.Drawing.Point(169, 26);
            this.pbxVenta.Name = "pbxVenta";
            this.pbxVenta.Size = new System.Drawing.Size(181, 52);
            this.pbxVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVenta.TabIndex = 0;
            this.pbxVenta.TabStop = false;
            // 
            // lstbVentas
            // 
            this.lstbVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lstbVentas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbVentas.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lstbVentas.FormattingEnabled = true;
            this.lstbVentas.ItemHeight = 18;
            this.lstbVentas.Location = new System.Drawing.Point(21, 170);
            this.lstbVentas.MultiColumn = true;
            this.lstbVentas.Name = "lstbVentas";
            this.lstbVentas.Size = new System.Drawing.Size(530, 310);
            this.lstbVentas.TabIndex = 4;
            this.lstbVentas.TabStop = false;
            // 
            // crvlsbVentas
            // 
            this.crvlsbVentas.ElipseRadius = 25;
            this.crvlsbVentas.TargetControl = this.lstbVentas;
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.ActiveBorderThickness = 1;
            this.btnCerrarCaja.ActiveCornerRadius = 20;
            this.btnCerrarCaja.ActiveFillColor = System.Drawing.Color.CadetBlue;
            this.btnCerrarCaja.ActiveForecolor = System.Drawing.Color.Black;
            this.btnCerrarCaja.ActiveLineColor = System.Drawing.Color.MediumAquamarine;
            this.btnCerrarCaja.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCerrarCaja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarCaja.BackgroundImage")));
            this.btnCerrarCaja.ButtonText = "Cerrar Caja";
            this.btnCerrarCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarCaja.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarCaja.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCerrarCaja.IdleBorderThickness = 1;
            this.btnCerrarCaja.IdleCornerRadius = 20;
            this.btnCerrarCaja.IdleFillColor = System.Drawing.Color.White;
            this.btnCerrarCaja.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnCerrarCaja.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnCerrarCaja.Location = new System.Drawing.Point(62, 501);
            this.btnCerrarCaja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(437, 45);
            this.btnCerrarCaja.TabIndex = 3;
            this.btnCerrarCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(931, 564);
            this.Controls.Add(this.btnCerrarCaja);
            this.Controls.Add(this.lstbVentas);
            this.Controls.Add(this.pnlVentas);
            this.Controls.Add(this.pnlTotalDia);
            this.Controls.Add(this.pnlFecha);
            this.Controls.Add(this.pnlVentasTarjeta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.pnlVentasTarjeta.ResumeLayout(false);
            this.pnlVentasTarjeta.PerformLayout();
            this.pnlFecha.ResumeLayout(false);
            this.pnlTotalDia.ResumeLayout(false);
            this.pnlTotalDia.PerformLayout();
            this.pnlVentas.ResumeLayout(false);
            this.pnlVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse crvVTarjeta;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlVentasTarjeta;
        private Bunifu.Framework.UI.BunifuElipse crvVMayor;
        private Bunifu.Framework.UI.BunifuElipse crvVTotalDia;
        private Bunifu.Framework.UI.BunifuElipse crvVenta;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlFecha;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlTotalDia;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlVentas;
        private System.Windows.Forms.Label lblVentaTarjeta;
        private System.Windows.Forms.ListBox lstbVentas;
        private System.Windows.Forms.Label lblPTarjeta;
        private System.Windows.Forms.Label lblTotallDia;
        private System.Windows.Forms.Label lblTotalDia;
        private Bunifu.Framework.UI.BunifuElipse crvlsbVentas;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCerrarCaja;
        private System.Windows.Forms.PictureBox pbxVenta;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConfirmar;
        private Bunifu.Framework.UI.BunifuCheckbox chckTarjeta;
        private System.Windows.Forms.Label lblVTarjeta;
        private System.Windows.Forms.Label labelVentaConTarjeta;
        private System.Windows.Forms.Label labelVentaDia;
        private System.Windows.Forms.Label lblIngreseVenta;
        private System.Windows.Forms.TextBox txtVenta;
        private Bunifu.Framework.UI.BunifuDatepicker DateTimeVenta;
    }
}