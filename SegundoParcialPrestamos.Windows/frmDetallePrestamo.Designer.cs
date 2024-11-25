namespace SegundoParcialPrestamos.Windows
{
    partial class frmDetallePrestamo
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
            splitContainer1 = new SplitContainer();
            btnCerrar = new Button();
            txtPlazo = new TextBox();
            label3 = new Label();
            txtMonto = new TextBox();
            label5 = new Label();
            txtTipo = new TextBox();
            label4 = new Label();
            txtFecha = new TextBox();
            label2 = new Label();
            txtPrestatario = new TextBox();
            label1 = new Label();
            dgvDatos = new DataGridView();
            colCuota = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            colCapital = new DataGridViewTextBoxColumn();
            colIntereses = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnCerrar);
            splitContainer1.Panel1.Controls.Add(txtPlazo);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(txtMonto);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(txtTipo);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(txtFecha);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(txtPrestatario);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvDatos);
            splitContainer1.Size = new Size(663, 643);
            splitContainer1.SplitterDistance = 164;
            splitContainer1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(561, 18);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 43);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // txtPlazo
            // 
            txtPlazo.Location = new Point(236, 76);
            txtPlazo.Name = "txtPlazo";
            txtPlazo.ReadOnly = true;
            txtPlazo.Size = new Size(86, 23);
            txtPlazo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 79);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 0;
            label3.Text = "Plazo:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(94, 76);
            txtMonto.Name = "txtMonto";
            txtMonto.ReadOnly = true;
            txtMonto.Size = new Size(87, 23);
            txtMonto.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 79);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 0;
            label5.Text = "Monto:";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(235, 47);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(87, 23);
            txtTipo.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 50);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 0;
            label4.Text = "Tipo:";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(95, 47);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(86, 23);
            txtFecha.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 50);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 0;
            label2.Text = "Fecha:";
            // 
            // txtPrestatario
            // 
            txtPrestatario.Location = new Point(95, 18);
            txtPrestatario.Name = "txtPrestatario";
            txtPrestatario.ReadOnly = true;
            txtPrestatario.Size = new Size(401, 23);
            txtPrestatario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Prestatario:";
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colCuota, colFecha, colMonto, colCapital, colIntereses });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.Size = new Size(663, 475);
            dgvDatos.TabIndex = 0;
            // 
            // colCuota
            // 
            colCuota.HeaderText = "Cuota Nro.";
            colCuota.Name = "colCuota";
            colCuota.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha Vto.";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colMonto
            // 
            colMonto.HeaderText = "Monto";
            colMonto.Name = "colMonto";
            colMonto.ReadOnly = true;
            // 
            // colCapital
            // 
            colCapital.HeaderText = "Capital";
            colCapital.Name = "colCapital";
            colCapital.ReadOnly = true;
            // 
            // colIntereses
            // 
            colIntereses.HeaderText = "Intereses";
            colIntereses.Name = "colIntereses";
            colIntereses.ReadOnly = true;
            // 
            // frmDetallePrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 643);
            Controls.Add(splitContainer1);
            MaximumSize = new Size(679, 682);
            MinimumSize = new Size(679, 682);
            Name = "frmDetallePrestamo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDetallePrestamo";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colCuota;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colMonto;
        private DataGridViewTextBoxColumn colCapital;
        private DataGridViewTextBoxColumn colIntereses;
        private TextBox txtPlazo;
        private Label label3;
        private TextBox txtMonto;
        private Label label5;
        private TextBox txtTipo;
        private Label label4;
        private TextBox txtFecha;
        private Label label2;
        private TextBox txtPrestatario;
        private Label label1;
        private Button btnCerrar;
    }
}