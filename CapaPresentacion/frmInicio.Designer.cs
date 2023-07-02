namespace CapaPresentacion
{
    partial class Inicio
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
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.imUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.imMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.imVentas = new FontAwesome.Sharp.IconMenuItem();
            this.imCompras = new FontAwesome.Sharp.IconMenuItem();
            this.imClientes = new FontAwesome.Sharp.IconMenuItem();
            this.imProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.imReportes = new FontAwesome.Sharp.IconMenuItem();
            this.imAcerca = new FontAwesome.Sharp.IconMenuItem();
            this.msTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.BackColor = System.Drawing.Color.White;
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imUsuarios,
            this.imMantenedor,
            this.imVentas,
            this.imCompras,
            this.imClientes,
            this.imProveedores,
            this.imReportes,
            this.imAcerca});
            this.msPrincipal.Location = new System.Drawing.Point(0, 58);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(800, 75);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // imUsuarios
            // 
            this.imUsuarios.AutoSize = false;
            this.imUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.imUsuarios.IconColor = System.Drawing.Color.Black;
            this.imUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imUsuarios.IconSize = 52;
            this.imUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imUsuarios.Name = "imUsuarios";
            this.imUsuarios.Size = new System.Drawing.Size(80, 71);
            this.imUsuarios.Text = "Usuarios";
            this.imUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // imMantenedor
            // 
            this.imMantenedor.AutoSize = false;
            this.imMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.imMantenedor.IconColor = System.Drawing.Color.Black;
            this.imMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imMantenedor.IconSize = 52;
            this.imMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imMantenedor.Name = "imMantenedor";
            this.imMantenedor.Size = new System.Drawing.Size(80, 71);
            this.imMantenedor.Text = "Mantenedor";
            this.imMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // imVentas
            // 
            this.imVentas.AutoSize = false;
            this.imVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.imVentas.IconColor = System.Drawing.Color.Black;
            this.imVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imVentas.IconSize = 52;
            this.imVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imVentas.Name = "imVentas";
            this.imVentas.Size = new System.Drawing.Size(80, 71);
            this.imVentas.Text = "Ventas";
            this.imVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // imCompras
            // 
            this.imCompras.AutoSize = false;
            this.imCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.imCompras.IconColor = System.Drawing.Color.Black;
            this.imCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imCompras.IconSize = 52;
            this.imCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imCompras.Name = "imCompras";
            this.imCompras.Size = new System.Drawing.Size(80, 71);
            this.imCompras.Text = "Compras";
            this.imCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // imClientes
            // 
            this.imClientes.AutoSize = false;
            this.imClientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.imClientes.IconColor = System.Drawing.Color.Black;
            this.imClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imClientes.IconSize = 52;
            this.imClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imClientes.Name = "imClientes";
            this.imClientes.Size = new System.Drawing.Size(80, 71);
            this.imClientes.Text = "Clientes";
            this.imClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // imProveedores
            // 
            this.imProveedores.AutoSize = false;
            this.imProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.imProveedores.IconColor = System.Drawing.Color.Black;
            this.imProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imProveedores.IconSize = 52;
            this.imProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imProveedores.Name = "imProveedores";
            this.imProveedores.Size = new System.Drawing.Size(80, 71);
            this.imProveedores.Text = "Proveedores";
            this.imProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // imReportes
            // 
            this.imReportes.AutoSize = false;
            this.imReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.imReportes.IconColor = System.Drawing.Color.Black;
            this.imReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imReportes.IconSize = 52;
            this.imReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imReportes.Name = "imReportes";
            this.imReportes.Size = new System.Drawing.Size(80, 71);
            this.imReportes.Text = "Reportes";
            this.imReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // imAcerca
            // 
            this.imAcerca.AutoSize = false;
            this.imAcerca.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.imAcerca.IconColor = System.Drawing.Color.Black;
            this.imAcerca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imAcerca.IconSize = 52;
            this.imAcerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imAcerca.Name = "imAcerca";
            this.imAcerca.Size = new System.Drawing.Size(80, 71);
            this.imAcerca.Text = "Acerca de";
            this.imAcerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // msTitulo
            // 
            this.msTitulo.AutoSize = false;
            this.msTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.msTitulo.Location = new System.Drawing.Point(0, 0);
            this.msTitulo.Name = "msTitulo";
            this.msTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.msTitulo.Size = new System.Drawing.Size(800, 58);
            this.msTitulo.TabIndex = 1;
            this.msTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Ventas";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 317);
            this.panel1.TabIndex = 3;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msPrincipal);
            this.Controls.Add(this.msTitulo);
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "Inicio";
            this.Text = "Sistema de ventas - Home";
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.MenuStrip msTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem imUsuarios;
        private FontAwesome.Sharp.IconMenuItem imMantenedor;
        private FontAwesome.Sharp.IconMenuItem imVentas;
        private FontAwesome.Sharp.IconMenuItem imCompras;
        private FontAwesome.Sharp.IconMenuItem imClientes;
        private FontAwesome.Sharp.IconMenuItem imProveedores;
        private FontAwesome.Sharp.IconMenuItem imReportes;
        private FontAwesome.Sharp.IconMenuItem imAcerca;
        private System.Windows.Forms.Panel panel1;
    }
}

