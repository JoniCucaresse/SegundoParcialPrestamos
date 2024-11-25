namespace SegundoParcialPrestamos.Windows
{
    partial class frmPrestamos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsDetalles = new ToolStripButton();
            tsbFiltrar = new ToolStripDropDownButton();
            bordeToolStripMenuItem = new ToolStripMenuItem();
            tsCboTipos = new ToolStripComboBox();
            tsbOrdenar = new ToolStripDropDownButton();
            lado09ToolStripMenuItem = new ToolStripMenuItem();
            lado90ToolStripMenuItem = new ToolStripMenuItem();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            panelCantidad = new Panel();
            txtCantidad = new TextBox();
            label1 = new Label();
            dgvDatos = new DataGridView();
            colNro = new DataGridViewTextBoxColumn();
            colPrestatario = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            colPlazo = new DataGridViewTextBoxColumn();
            colTasa = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            panelCantidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, toolStripSeparator1, tsDetalles, tsbFiltrar, tsbOrdenar, tsbActualizar, toolStripSeparator2, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1148, 70);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = Properties.Resources.add_file_48px;
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(52, 67);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 70);
            // 
            // tsDetalles
            // 
            tsDetalles.Image = Properties.Resources.content_48px;
            tsDetalles.ImageScaling = ToolStripItemImageScaling.None;
            tsDetalles.ImageTransparentColor = Color.Magenta;
            tsDetalles.Name = "tsDetalles";
            tsDetalles.Size = new Size(52, 67);
            tsDetalles.Text = "Detalle";
            tsDetalles.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.DropDownItems.AddRange(new ToolStripItem[] { bordeToolStripMenuItem });
            tsbFiltrar.Image = Properties.Resources.filled_filter_48px;
            tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(61, 67);
            tsbFiltrar.Text = "Filtar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // bordeToolStripMenuItem
            // 
            bordeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsCboTipos });
            bordeToolStripMenuItem.Image = Properties.Resources.filled_filter_48px;
            bordeToolStripMenuItem.Name = "bordeToolStripMenuItem";
            bordeToolStripMenuItem.Size = new Size(166, 22);
            bordeToolStripMenuItem.Text = "Tipo de Préstamo";
            // 
            // tsCboTipos
            // 
            tsCboTipos.DropDownStyle = ComboBoxStyle.DropDownList;
            tsCboTipos.Name = "tsCboTipos";
            tsCboTipos.Size = new Size(121, 23);
            // 
            // tsbOrdenar
            // 
            tsbOrdenar.DropDownItems.AddRange(new ToolStripItem[] { lado09ToolStripMenuItem, lado90ToolStripMenuItem });
            tsbOrdenar.Image = Properties.Resources.sorting_answers_48px;
            tsbOrdenar.ImageScaling = ToolStripItemImageScaling.None;
            tsbOrdenar.ImageTransparentColor = Color.Magenta;
            tsbOrdenar.Name = "tsbOrdenar";
            tsbOrdenar.Size = new Size(63, 67);
            tsbOrdenar.Text = "Ordenar";
            tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // lado09ToolStripMenuItem
            // 
            lado09ToolStripMenuItem.Name = "lado09ToolStripMenuItem";
            lado09ToolStripMenuItem.Size = new Size(138, 22);
            lado09ToolStripMenuItem.Text = "Monto (0-9)";
            // 
            // lado90ToolStripMenuItem
            // 
            lado90ToolStripMenuItem.Name = "lado90ToolStripMenuItem";
            lado90ToolStripMenuItem.Size = new Size(138, 22);
            lado90ToolStripMenuItem.Text = "Monto (9-0)";
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = Properties.Resources.restart_48px;
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 67);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 70);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = Properties.Resources.exit_48px;
            tsbSalir.ImageScaling = ToolStripItemImageScaling.None;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(52, 67);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // panelCantidad
            // 
            panelCantidad.Controls.Add(txtCantidad);
            panelCantidad.Controls.Add(label1);
            panelCantidad.Dock = DockStyle.Bottom;
            panelCantidad.Location = new Point(0, 507);
            panelCantidad.Name = "panelCantidad";
            panelCantidad.Size = new Size(1148, 73);
            panelCantidad.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(128, 25);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 28);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad";
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colNro, colPrestatario, colFecha, colTipo, colMonto, colPlazo, colTasa });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 70);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(1148, 437);
            dgvDatos.TabIndex = 2;
            // 
            // colNro
            // 
            colNro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNro.HeaderText = "Prest. Nro.";
            colNro.Name = "colNro";
            colNro.ReadOnly = true;
            // 
            // colPrestatario
            // 
            colPrestatario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPrestatario.HeaderText = "Prestatario";
            colPrestatario.Name = "colPrestatario";
            colPrestatario.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colMonto
            // 
            colMonto.HeaderText = "Monto";
            colMonto.Name = "colMonto";
            colMonto.ReadOnly = true;
            // 
            // colPlazo
            // 
            colPlazo.HeaderText = "Plazo";
            colPlazo.Name = "colPlazo";
            colPlazo.ReadOnly = true;
            // 
            // colTasa
            // 
            colTasa.HeaderText = "Tasa";
            colTasa.Name = "colTasa";
            colTasa.ReadOnly = true;
            // 
            // frmPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 580);
            Controls.Add(dgvDatos);
            Controls.Add(panelCantidad);
            Controls.Add(toolStrip1);
            Name = "frmPrestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de Rombos";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panelCantidad.ResumeLayout(false);
            panelCantidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbSalir;
        private Panel panelCantidad;
        private TextBox txtCantidad;
        private Label label1;
        private DataGridView dgvDatos;
        private ToolStripDropDownButton tsbFiltrar;
        private ToolStripMenuItem bordeToolStripMenuItem;
        private ToolStripComboBox tsCboTipos;
        private ToolStripDropDownButton tsbOrdenar;
        private ToolStripMenuItem lado09ToolStripMenuItem;
        private ToolStripMenuItem lado90ToolStripMenuItem;
        private ToolStripButton tsDetalles;
        private DataGridViewTextBoxColumn colNro;
        private DataGridViewTextBoxColumn colPrestatario;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colMonto;
        private DataGridViewTextBoxColumn colPlazo;
        private DataGridViewTextBoxColumn colTasa;
    }
}
