namespace WindowsFormsApp2
{
    partial class Form1
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.npestaña = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegar = new System.Windows.Forms.ToolStripMenuItem();
            this.buscar = new System.Windows.Forms.ToolStripMenuItem();
            this.copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.cortar = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.desacerCtrlZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adelanteCtrlYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTodoCtrlAltXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 70);
            this.contextMenuStrip1.Text = "Archivo";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como..";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem1,
            this.editarToolStripMenuItem,
            this.fuenteToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.nuevo,
            this.toolStripSeparator2,
            this.npestaña,
            this.toolStripSeparator3,
            this.abrir,
            this.toolStripSeparator4,
            this.guardar,
            this.toolStripSeparator5,
            this.cerrar});
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem1.Text = "Archivo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(227, 6);
            // 
            // nuevo
            // 
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(230, 22);
            this.nuevo.Text = "Nuevo (Ctrl N)";
            this.nuevo.Click += new System.EventHandler(this.nuevoCtrlNToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(227, 6);
            // 
            // npestaña
            // 
            this.npestaña.Name = "npestaña";
            this.npestaña.Size = new System.Drawing.Size(230, 22);
            this.npestaña.Text = "Nueva pestaña (Ctrl + shit+n)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(227, 6);
            // 
            // abrir
            // 
            this.abrir.Name = "abrir";
            this.abrir.Size = new System.Drawing.Size(230, 22);
            this.abrir.Text = "Abril (Ctrl A)";
            this.abrir.Click += new System.EventHandler(this.abrilCtrlAToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(227, 6);
            // 
            // guardar
            // 
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(230, 22);
            this.guardar.Text = "Guardar (Ctrl S)";
            this.guardar.Click += new System.EventHandler(this.guardarCtrlSToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(227, 6);
            // 
            // cerrar
            // 
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(230, 22);
            this.cerrar.Text = "Cerrar";
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pegar,
            this.buscar,
            this.copiar,
            this.cortar,
            this.desacerCtrlZToolStripMenuItem,
            this.adelanteCtrlYToolStripMenuItem,
            this.eliminarTodoCtrlAltXToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // pegar
            // 
            this.pegar.Name = "pegar";
            this.pegar.Size = new System.Drawing.Size(180, 22);
            this.pegar.Text = "Pegar (Ctrl V)";
            this.pegar.Click += new System.EventHandler(this.pegar_Click);
            // 
            // buscar
            // 
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(213, 22);
            this.buscar.Text = "Seleccionar (Ctrl E)";
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // copiar
            // 
            this.copiar.Name = "copiar";
            this.copiar.Size = new System.Drawing.Size(180, 22);
            this.copiar.Text = "Copiar (Ctrl C)";
            this.copiar.Click += new System.EventHandler(this.copiar_Click);
            // 
            // cortar
            // 
            this.cortar.Name = "cortar";
            this.cortar.Size = new System.Drawing.Size(180, 22);
            this.cortar.Text = "Cortar ( Ctrl X)";
            this.cortar.Click += new System.EventHandler(this.cortar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(566, 325);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // desacerCtrlZToolStripMenuItem
            // 
            this.desacerCtrlZToolStripMenuItem.Name = "desacerCtrlZToolStripMenuItem";
            this.desacerCtrlZToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desacerCtrlZToolStripMenuItem.Text = "Desacer (Ctrl Z)";
            this.desacerCtrlZToolStripMenuItem.Click += new System.EventHandler(this.desacerCtrlZToolStripMenuItem_Click);
            // 
            // adelanteCtrlYToolStripMenuItem
            // 
            this.adelanteCtrlYToolStripMenuItem.Name = "adelanteCtrlYToolStripMenuItem";
            this.adelanteCtrlYToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adelanteCtrlYToolStripMenuItem.Text = "Adelante (Ctrl Y)";
            this.adelanteCtrlYToolStripMenuItem.Click += new System.EventHandler(this.adelanteCtrlYToolStripMenuItem_Click);
            // 
            // eliminarTodoCtrlAltXToolStripMenuItem
            // 
            this.eliminarTodoCtrlAltXToolStripMenuItem.Name = "eliminarTodoCtrlAltXToolStripMenuItem";
            this.eliminarTodoCtrlAltXToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.eliminarTodoCtrlAltXToolStripMenuItem.Text = "Eliminar todo (Ctrl+Alt+X)";
            this.eliminarTodoCtrlAltXToolStripMenuItem.Click += new System.EventHandler(this.eliminarTodoCtrlAltXToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(568, 364);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "EDITOR DE TEXTO ";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegar;
        private System.Windows.Forms.ToolStripMenuItem buscar;
        private System.Windows.Forms.ToolStripMenuItem copiar;
        private System.Windows.Forms.ToolStripMenuItem cortar;
        private System.Windows.Forms.ToolStripMenuItem nuevo;
        private System.Windows.Forms.ToolStripMenuItem npestaña;
        private System.Windows.Forms.ToolStripMenuItem abrir;
        private System.Windows.Forms.ToolStripMenuItem guardar;
        private System.Windows.Forms.ToolStripMenuItem cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem desacerCtrlZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adelanteCtrlYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTodoCtrlAltXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

