namespace Datos
{
    partial class formBase
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBase));
            this.dragpnlTop = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxSalir = new System.Windows.Forms.PictureBox();
            this.curvepnlMenu = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGastos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCompras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPedidos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlCMenu = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlCMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragpnlTop
            // 
            this.dragpnlTop.Fixed = true;
            this.dragpnlTop.Horizontal = true;
            this.dragpnlTop.TargetControl = this.pnlTop;
            this.dragpnlTop.Vertical = true;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.pbxSalir);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1150, 36);
            this.pnlTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1076, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbxSalir
            // 
            this.pbxSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbxSalir.Image")));
            this.pbxSalir.Location = new System.Drawing.Point(1110, 4);
            this.pbxSalir.Name = "pbxSalir";
            this.pbxSalir.Size = new System.Drawing.Size(25, 25);
            this.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalir.TabIndex = 0;
            this.pbxSalir.TabStop = false;
            this.pbxSalir.Click += new System.EventHandler(this.pbxSalir_Click);
            // 
            // curvepnlMenu
            // 
            this.curvepnlMenu.ElipseRadius = 15;
            this.curvepnlMenu.TargetControl = this.pnlMenu;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenu.BackgroundImage")));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.Controls.Add(this.lblLogo);
            this.pnlMenu.Controls.Add(this.pictureBox2);
            this.pnlMenu.Controls.Add(this.btnReportes);
            this.pnlMenu.Controls.Add(this.btnGastos);
            this.pnlMenu.Controls.Add(this.btnCompras);
            this.pnlMenu.Controls.Add(this.btnPedidos);
            this.pnlMenu.Controls.Add(this.btnVentas);
            this.pnlMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.pnlMenu.GradientBottomRight = System.Drawing.SystemColors.HotTrack;
            this.pnlMenu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.pnlMenu.GradientTopRight = System.Drawing.Color.DeepSkyBlue;
            this.pnlMenu.Location = new System.Drawing.Point(7, 6);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Quality = 10;
            this.pnlMenu.Size = new System.Drawing.Size(207, 550);
            this.pnlMenu.TabIndex = 2;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(63, 30);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(127, 16);
            this.lblLogo.TabIndex = 2;
            this.lblLogo.Text = "CARNICERIA JUAN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnReportes
            // 
            this.btnReportes.Activecolor = System.Drawing.Color.DarkGray;
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportes.BorderRadius = 0;
            this.btnReportes.ButtonText = "REPORTES";
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.DisabledColor = System.Drawing.Color.Gray;
            this.btnReportes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReportes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReportes.Iconimage")));
            this.btnReportes.Iconimage_right = null;
            this.btnReportes.Iconimage_right_Selected = null;
            this.btnReportes.Iconimage_Selected = null;
            this.btnReportes.IconMarginLeft = 0;
            this.btnReportes.IconMarginRight = 0;
            this.btnReportes.IconRightVisible = true;
            this.btnReportes.IconRightZoom = 0D;
            this.btnReportes.IconVisible = true;
            this.btnReportes.IconZoom = 55D;
            this.btnReportes.IsTab = false;
            this.btnReportes.Location = new System.Drawing.Point(-1, 304);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnReportes.OnHovercolor = System.Drawing.Color.Silver;
            this.btnReportes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReportes.selected = false;
            this.btnReportes.Size = new System.Drawing.Size(204, 48);
            this.btnReportes.TabIndex = 6;
            this.btnReportes.Text = "REPORTES";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReportes.Textcolor = System.Drawing.Color.White;
            this.btnReportes.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.Activecolor = System.Drawing.Color.DarkGray;
            this.btnGastos.BackColor = System.Drawing.Color.Transparent;
            this.btnGastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGastos.BorderRadius = 0;
            this.btnGastos.ButtonText = "GASTOS";
            this.btnGastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGastos.DisabledColor = System.Drawing.Color.Gray;
            this.btnGastos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGastos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGastos.Iconimage")));
            this.btnGastos.Iconimage_right = null;
            this.btnGastos.Iconimage_right_Selected = null;
            this.btnGastos.Iconimage_Selected = null;
            this.btnGastos.IconMarginLeft = 0;
            this.btnGastos.IconMarginRight = 0;
            this.btnGastos.IconRightVisible = true;
            this.btnGastos.IconRightZoom = 0D;
            this.btnGastos.IconVisible = true;
            this.btnGastos.IconZoom = 55D;
            this.btnGastos.IsTab = false;
            this.btnGastos.Location = new System.Drawing.Point(-1, 196);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnGastos.OnHovercolor = System.Drawing.Color.Silver;
            this.btnGastos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGastos.selected = false;
            this.btnGastos.Size = new System.Drawing.Size(204, 48);
            this.btnGastos.TabIndex = 5;
            this.btnGastos.Text = "GASTOS";
            this.btnGastos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGastos.Textcolor = System.Drawing.Color.White;
            this.btnGastos.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Activecolor = System.Drawing.Color.DarkGray;
            this.btnCompras.BackColor = System.Drawing.Color.Transparent;
            this.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompras.BorderRadius = 0;
            this.btnCompras.ButtonText = "COMPRAS";
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.DisabledColor = System.Drawing.Color.Gray;
            this.btnCompras.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCompras.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCompras.Iconimage")));
            this.btnCompras.Iconimage_right = null;
            this.btnCompras.Iconimage_right_Selected = null;
            this.btnCompras.Iconimage_Selected = null;
            this.btnCompras.IconMarginLeft = 0;
            this.btnCompras.IconMarginRight = 0;
            this.btnCompras.IconRightVisible = true;
            this.btnCompras.IconRightZoom = 0D;
            this.btnCompras.IconVisible = true;
            this.btnCompras.IconZoom = 55D;
            this.btnCompras.IsTab = false;
            this.btnCompras.Location = new System.Drawing.Point(-1, 142);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCompras.OnHovercolor = System.Drawing.Color.Silver;
            this.btnCompras.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCompras.selected = false;
            this.btnCompras.Size = new System.Drawing.Size(204, 48);
            this.btnCompras.TabIndex = 4;
            this.btnCompras.Text = "COMPRAS";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCompras.Textcolor = System.Drawing.Color.White;
            this.btnCompras.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Activecolor = System.Drawing.Color.DarkGray;
            this.btnPedidos.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedidos.BorderRadius = 0;
            this.btnPedidos.ButtonText = "PEDIDOS";
            this.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidos.DisabledColor = System.Drawing.Color.Gray;
            this.btnPedidos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPedidos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Iconimage")));
            this.btnPedidos.Iconimage_right = null;
            this.btnPedidos.Iconimage_right_Selected = null;
            this.btnPedidos.Iconimage_Selected = null;
            this.btnPedidos.IconMarginLeft = 0;
            this.btnPedidos.IconMarginRight = 0;
            this.btnPedidos.IconRightVisible = true;
            this.btnPedidos.IconRightZoom = 0D;
            this.btnPedidos.IconVisible = true;
            this.btnPedidos.IconZoom = 55D;
            this.btnPedidos.IsTab = false;
            this.btnPedidos.Location = new System.Drawing.Point(-1, 250);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPedidos.OnHovercolor = System.Drawing.Color.Silver;
            this.btnPedidos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPedidos.selected = false;
            this.btnPedidos.Size = new System.Drawing.Size(204, 48);
            this.btnPedidos.TabIndex = 3;
            this.btnPedidos.Text = "PEDIDOS";
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPedidos.Textcolor = System.Drawing.Color.White;
            this.btnPedidos.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnVentas
            // 
            this.btnVentas.Activecolor = System.Drawing.Color.DarkGray;
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.BorderRadius = 0;
            this.btnVentas.ButtonText = "VENTAS";
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVentas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVentas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVentas.Iconimage")));
            this.btnVentas.Iconimage_right = null;
            this.btnVentas.Iconimage_right_Selected = null;
            this.btnVentas.Iconimage_Selected = null;
            this.btnVentas.IconMarginLeft = 0;
            this.btnVentas.IconMarginRight = 0;
            this.btnVentas.IconRightVisible = true;
            this.btnVentas.IconRightZoom = 0D;
            this.btnVentas.IconVisible = true;
            this.btnVentas.IconZoom = 55D;
            this.btnVentas.IsTab = false;
            this.btnVentas.Location = new System.Drawing.Point(-1, 88);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVentas.OnHovercolor = System.Drawing.Color.Silver;
            this.btnVentas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVentas.selected = false;
            this.btnVentas.Size = new System.Drawing.Size(204, 48);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVentas.Textcolor = System.Drawing.Color.White;
            this.btnVentas.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this;
            // 
            // pnlCMenu
            // 
            this.pnlCMenu.Controls.Add(this.pnlMenu);
            this.pnlCMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCMenu.Location = new System.Drawing.Point(0, 36);
            this.pnlCMenu.Name = "pnlCMenu";
            this.pnlCMenu.Size = new System.Drawing.Size(219, 564);
            this.pnlCMenu.TabIndex = 1;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(219, 36);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(931, 564);
            this.pnlContenedor.TabIndex = 2;
            // 
            // formBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1150, 600);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlCMenu);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlCMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl dragpnlTop;
        private System.Windows.Forms.Panel pnlTop;
        private Bunifu.Framework.UI.BunifuElipse curvepnlMenu;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlMenu;
        private System.Windows.Forms.Panel pnlCMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxSalir;
        private Bunifu.Framework.UI.BunifuFlatButton btnVentas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnReportes;
        private Bunifu.Framework.UI.BunifuFlatButton btnGastos;
        private Bunifu.Framework.UI.BunifuFlatButton btnCompras;
        private Bunifu.Framework.UI.BunifuFlatButton btnPedidos;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}

