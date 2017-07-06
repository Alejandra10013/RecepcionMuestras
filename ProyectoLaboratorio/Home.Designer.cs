namespace ProyectoLaboratorio
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Identificacion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarRecepcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarRecepcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identificarMuestrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarInformeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.iToolStripMenuItem,
            this.Identificacion,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarRecepcionToolStripMenuItem,
            this.eliminarRecepcionToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.toolStripMenuItem1.Text = "Recepcion";
            // 
            // iToolStripMenuItem
            // 
            this.iToolStripMenuItem.Name = "iToolStripMenuItem";
            this.iToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // Identificacion
            // 
            this.Identificacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identificarMuestrasToolStripMenuItem});
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Size = new System.Drawing.Size(91, 20);
            this.Identificacion.Text = "Identificacion";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(83, 20);
            this.toolStripMenuItem2.Text = "Mantencion";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarInformeToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(76, 20);
            this.toolStripMenuItem3.Text = "Resultados";
            // 
            // ingresarRecepcionToolStripMenuItem
            // 
            this.ingresarRecepcionToolStripMenuItem.Name = "ingresarRecepcionToolStripMenuItem";
            this.ingresarRecepcionToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ingresarRecepcionToolStripMenuItem.Text = "Ingresar Recepcion";
            // 
            // eliminarRecepcionToolStripMenuItem
            // 
            this.eliminarRecepcionToolStripMenuItem.Name = "eliminarRecepcionToolStripMenuItem";
            this.eliminarRecepcionToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.eliminarRecepcionToolStripMenuItem.Text = "Eliminar Recepcion";
            // 
            // identificarMuestrasToolStripMenuItem
            // 
            this.identificarMuestrasToolStripMenuItem.Name = "identificarMuestrasToolStripMenuItem";
            this.identificarMuestrasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.identificarMuestrasToolStripMenuItem.Text = "Identificar Muestras";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // generarInformeToolStripMenuItem
            // 
            this.generarInformeToolStripMenuItem.Name = "generarInformeToolStripMenuItem";
            this.generarInformeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.generarInformeToolStripMenuItem.Text = "Generar Informe";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 456);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Laboratorio Calidad de Leche";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ingresarRecepcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarRecepcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Identificacion;
        private System.Windows.Forms.ToolStripMenuItem identificarMuestrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem generarInformeToolStripMenuItem;
    }
}

