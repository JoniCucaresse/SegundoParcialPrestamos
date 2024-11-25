namespace SegundoParcialPrestamos.Windows
{
    partial class frmPrestamoAE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtDni = new TextBox();
            btnValidar = new Button();
            gbPrestatario = new GroupBox();
            txtApellido = new TextBox();
            label3 = new Label();
            txtNombres = new TextBox();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            gbPrestamo = new GroupBox();
            txtTasa = new TextBox();
            cboPlazos = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            txtMonto = new TextBox();
            label6 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            rbtDolares = new RadioButton();
            rbtPesos = new RadioButton();
            dtpFecha = new DateTimePicker();
            label4 = new Label();
            btnOK = new Button();
            btnCancelar = new Button();
            gbPrestatario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            gbPrestamo.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(64, 19);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(185, 20);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // gbPrestatario
            // 
            gbPrestatario.Controls.Add(txtApellido);
            gbPrestatario.Controls.Add(label3);
            gbPrestatario.Controls.Add(txtNombres);
            gbPrestatario.Controls.Add(label2);
            gbPrestatario.Location = new Point(29, 66);
            gbPrestatario.Name = "gbPrestatario";
            gbPrestatario.Size = new Size(403, 100);
            gbPrestatario.TabIndex = 3;
            gbPrestatario.TabStop = false;
            gbPrestatario.Text = " Prestatario ";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(82, 49);
            txtApellido.MaxLength = 100;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(295, 23);
            txtApellido.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 52);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 0;
            label3.Text = "Apellido:";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(82, 20);
            txtNombres.MaxLength = 100;
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(295, 23);
            txtNombres.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 23);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombres:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // gbPrestamo
            // 
            gbPrestamo.Controls.Add(txtTasa);
            gbPrestamo.Controls.Add(cboPlazos);
            gbPrestamo.Controls.Add(label8);
            gbPrestamo.Controls.Add(label7);
            gbPrestamo.Controls.Add(txtMonto);
            gbPrestamo.Controls.Add(label6);
            gbPrestamo.Controls.Add(label5);
            gbPrestamo.Controls.Add(groupBox1);
            gbPrestamo.Controls.Add(dtpFecha);
            gbPrestamo.Controls.Add(label4);
            gbPrestamo.Location = new Point(33, 180);
            gbPrestamo.Name = "gbPrestamo";
            gbPrestamo.Size = new Size(399, 200);
            gbPrestamo.TabIndex = 4;
            gbPrestamo.TabStop = false;
            gbPrestamo.Text = " Préstamo ";
            // 
            // txtTasa
            // 
            txtTasa.Location = new Point(200, 149);
            txtTasa.Name = "txtTasa";
            txtTasa.ReadOnly = true;
            txtTasa.Size = new Size(58, 23);
            txtTasa.TabIndex = 6;
            // 
            // cboPlazos
            // 
            cboPlazos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlazos.FormattingEnabled = true;
            cboPlazos.Location = new Point(79, 149);
            cboPlazos.Name = "cboPlazos";
            cboPlazos.Size = new Size(58, 23);
            cboPlazos.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(264, 152);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 3;
            label8.Text = "Anual";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(162, 152);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 3;
            label7.Text = "Tasa:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(79, 116);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 152);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 3;
            label6.Text = "Plazo;";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 119);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 3;
            label5.Text = "Monto:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtDolares);
            groupBox1.Controls.Add(rbtPesos);
            groupBox1.Location = new Point(20, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 52);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = " Tipo ";
            // 
            // rbtDolares
            // 
            rbtDolares.AutoSize = true;
            rbtDolares.Location = new Point(100, 18);
            rbtDolares.Name = "rbtDolares";
            rbtDolares.Size = new Size(64, 19);
            rbtDolares.TabIndex = 0;
            rbtDolares.Text = "Dólares";
            rbtDolares.UseVisualStyleBackColor = true;
            // 
            // rbtPesos
            // 
            rbtPesos.AutoSize = true;
            rbtPesos.Checked = true;
            rbtPesos.Location = new Point(15, 18);
            rbtPesos.Name = "rbtPesos";
            rbtPesos.Size = new Size(55, 19);
            rbtPesos.TabIndex = 0;
            rbtPesos.TabStop = true;
            rbtPesos.Text = "Pesos";
            rbtPesos.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(62, 20);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(113, 23);
            dtpFecha.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 26);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 0;
            label4.Text = "Fecha:";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(36, 397);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 41);
            btnOK.TabIndex = 5;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(357, 397);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmPrestamoAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(gbPrestamo);
            Controls.Add(gbPrestatario);
            Controls.Add(btnValidar);
            Controls.Add(txtDni);
            Controls.Add(label1);
            MaximumSize = new Size(485, 489);
            MinimumSize = new Size(485, 489);
            Name = "frmPrestamoAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrestamoAE";
            gbPrestatario.ResumeLayout(false);
            gbPrestatario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            gbPrestamo.ResumeLayout(false);
            gbPrestamo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDni;
        private Button btnValidar;
        private GroupBox gbPrestatario;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtNombres;
        private Label label2;
        private ErrorProvider errorProvider1;
        private Button btnCancelar;
        private Button btnOK;
        private GroupBox gbPrestamo;
        private GroupBox groupBox1;
        private DateTimePicker dtpFecha;
        private Label label4;
        private Label label5;
        private RadioButton rbtDolares;
        private RadioButton rbtPesos;
        private ComboBox cboPlazos;
        private TextBox txtMonto;
        private Label label6;
        private Label label7;
        private TextBox txtTasa;
        private Label label8;
    }
}