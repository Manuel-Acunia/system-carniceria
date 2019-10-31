namespace Datos
{
    partial class frmGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGastos));
            this.pnlCompras = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblTotalG = new System.Windows.Forms.Label();
            this.txtTotalG = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnConfirmarGasto = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dateGasto = new Bunifu.Framework.UI.BunifuDatepicker();
            this.cboTipoG = new System.Windows.Forms.ComboBox();
            this.lblTipoG = new System.Windows.Forms.Label();
            this.pnlCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCompras
            // 
            this.pnlCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCompras.BackColor = System.Drawing.Color.White;
            this.pnlCompras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCompras.BackgroundImage")));
            this.pnlCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCompras.Controls.Add(this.lblTotalG);
            this.pnlCompras.Controls.Add(this.txtTotalG);
            this.pnlCompras.Controls.Add(this.pictureBox4);
            this.pnlCompras.Controls.Add(this.btnConfirmarGasto);
            this.pnlCompras.Controls.Add(this.lblFecha);
            this.pnlCompras.Controls.Add(this.dateGasto);
            this.pnlCompras.Controls.Add(this.cboTipoG);
            this.pnlCompras.Controls.Add(this.lblTipoG);
            this.pnlCompras.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlCompras.GradientBottomRight = System.Drawing.Color.White;
            this.pnlCompras.GradientTopLeft = System.Drawing.Color.White;
            this.pnlCompras.GradientTopRight = System.Drawing.Color.White;
            this.pnlCompras.Location = new System.Drawing.Point(12, 12);
            this.pnlCompras.Name = "pnlCompras";
            this.pnlCompras.Quality = 10;
            this.pnlCompras.Size = new System.Drawing.Size(432, 405);
            this.pnlCompras.TabIndex = 4;
            // 
            // lblTotalG
            // 
            this.lblTotalG.AutoSize = true;
            this.lblTotalG.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalG.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalG.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalG.Location = new System.Drawing.Point(14, 210);
            this.lblTotalG.Name = "lblTotalG";
            this.lblTotalG.Size = new System.Drawing.Size(62, 18);
            this.lblTotalG.TabIndex = 17;
            this.lblTotalG.Text = "TOTAL";
            // 
            // txtTotalG
            // 
            this.txtTotalG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalG.Font = new System.Drawing.Font("Impact", 11F);
            this.txtTotalG.Location = new System.Drawing.Point(224, 206);
            this.txtTotalG.Name = "txtTotalG";
            this.txtTotalG.Size = new System.Drawing.Size(113, 18);
            this.txtTotalG.TabIndex = 15;
            this.txtTotalG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(206, 194);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // btnConfirmarGasto
            // 
            this.btnConfirmarGasto.ActiveBorderThickness = 1;
            this.btnConfirmarGasto.ActiveCornerRadius = 20;
            this.btnConfirmarGasto.ActiveFillColor = System.Drawing.Color.CadetBlue;
            this.btnConfirmarGasto.ActiveForecolor = System.Drawing.Color.Black;
            this.btnConfirmarGasto.ActiveLineColor = System.Drawing.Color.MediumAquamarine;
            this.btnConfirmarGasto.BackColor = System.Drawing.Color.White;
            this.btnConfirmarGasto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmarGasto.BackgroundImage")));
            this.btnConfirmarGasto.ButtonText = "Confirmar";
            this.btnConfirmarGasto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarGasto.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarGasto.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnConfirmarGasto.IdleBorderThickness = 1;
            this.btnConfirmarGasto.IdleCornerRadius = 20;
            this.btnConfirmarGasto.IdleFillColor = System.Drawing.Color.White;
            this.btnConfirmarGasto.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnConfirmarGasto.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnConfirmarGasto.Location = new System.Drawing.Point(18, 308);
            this.btnConfirmarGasto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmarGasto.Name = "btnConfirmarGasto";
            this.btnConfirmarGasto.Size = new System.Drawing.Size(331, 45);
            this.btnConfirmarGasto.TabIndex = 5;
            this.btnConfirmarGasto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmarGasto.Click += new System.EventHandler(this.btnConfirmarGasto_Click);
            this.btnConfirmarGasto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnConfirmarGasto_KeyPress);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFecha.Location = new System.Drawing.Point(15, 45);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 17);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha";
            // 
            // dateGasto
            // 
            this.dateGasto.BackColor = System.Drawing.Color.White;
            this.dateGasto.BorderRadius = 0;
            this.dateGasto.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateGasto.ForeColor = System.Drawing.Color.Gray;
            this.dateGasto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGasto.FormatCustom = null;
            this.dateGasto.Location = new System.Drawing.Point(205, 45);
            this.dateGasto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateGasto.Name = "dateGasto";
            this.dateGasto.Size = new System.Drawing.Size(144, 23);
            this.dateGasto.TabIndex = 0;
            this.dateGasto.Value = new System.DateTime(2019, 10, 16, 8, 22, 21, 140);
            // 
            // cboTipoG
            // 
            this.cboTipoG.FormattingEnabled = true;
            this.cboTipoG.Location = new System.Drawing.Point(206, 114);
            this.cboTipoG.Name = "cboTipoG";
            this.cboTipoG.Size = new System.Drawing.Size(143, 21);
            this.cboTipoG.TabIndex = 1;
            // 
            // lblTipoG
            // 
            this.lblTipoG.AutoSize = true;
            this.lblTipoG.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoG.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoG.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTipoG.Location = new System.Drawing.Point(15, 114);
            this.lblTipoG.Name = "lblTipoG";
            this.lblTipoG.Size = new System.Drawing.Size(81, 17);
            this.lblTipoG.TabIndex = 1;
            this.lblTipoG.Text = "Tipo de Gasto";
            // 
            // frmGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(931, 564);
            this.Controls.Add(this.pnlCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGastos";
            this.Text = "frmGastos";
            this.pnlCompras.ResumeLayout(false);
            this.pnlCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlCompras;
        private System.Windows.Forms.Label lblTotalG;
        private System.Windows.Forms.TextBox txtTotalG;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConfirmarGasto;
        private System.Windows.Forms.Label lblFecha;
        private Bunifu.Framework.UI.BunifuDatepicker dateGasto;
        private System.Windows.Forms.ComboBox cboTipoG;
        private System.Windows.Forms.Label lblTipoG;
    }
}